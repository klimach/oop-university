using System.Diagnostics;
using System.Text;

namespace Lab18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadProcesses();
        }

        private void LoadProcesses()
        {
            lvProcesses.Items.Clear();
            foreach (var proc in Process.GetProcesses().OrderBy(p => p.ProcessName))
            {
                var item = new ListViewItem(
                [
                    proc.ProcessName,
                    proc.Id.ToString(),
                    proc.Responding ? "Відгукується" : "Ні",
                    $"{proc.WorkingSet64/1024:N0} KB"
                ])
                {
                    Tag = proc
                };
                lvProcesses.Items.Add(item);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
            => LoadProcesses();

        private void btnExport_Click(object sender, EventArgs e)
        {
            using var dlg = new SaveFileDialog { Filter = "Text files|*.txt", FileName = "process_list.txt" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            var sb = new StringBuilder();
            foreach (ListViewItem item in lvProcesses.Items)
                sb.AppendLine($"{item.SubItems[0].Text}\tPID={item.SubItems[1].Text}\t{item.SubItems[2].Text}\t{item.SubItems[3].Text}");
            File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
            MessageBox.Show("Успішно експортовано.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Process? SelectedProcess
            => lvProcesses.SelectedItems.Count > 0
               ? lvProcesses.SelectedItems[0].Tag as Process
               : null;

        private void showInfo_tsmi_Click(object sender, EventArgs e)
        {
            var proc = SelectedProcess;
            if (proc == null) return;

            try
            {
                proc.Refresh();
                string info =
                    $"Ім'я: {proc.ProcessName}\n" +
                    $"PID: {proc.Id}\n" +
                    $"Запуск: {proc.StartTime}\n" +
                    $"Пам'ять: {proc.WorkingSet64 / 1024:N0} KB\n" +
                    $"Поточний шлях: {proc.MainModule.FileName}";
                MessageBox.Show(info, "Інформація про процес", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося отримати інформацію:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopProcess_tsmi_Click(object sender, EventArgs e)
        {
            var proc = SelectedProcess;
            if (proc == null) return;

            if (MessageBox.Show($"Дійсно зупинити {proc.ProcessName} (PID={proc.Id})?",
                "Підтвердіть", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                proc.Kill();
                proc.WaitForExit(2000);
                LoadProcesses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося зупинити процес:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void threadsAndModules_tsmi_Click(object sender, EventArgs e)
        {
            var proc = SelectedProcess;
            if (proc == null) return;

            try
            {
                proc.Refresh();
                var threads = proc.Threads
                                 .Cast<ProcessThread>()
                                 .Select(t => $"ID={t.Id}, стан={t.ThreadState}");
                var modules = proc.Modules
                                 .Cast<ProcessModule>()
                                 .Select(m => Path.GetFileName(m.FileName));

                var msg = "Потоки:\n" + string.Join("\n", threads)
                          + "\n\nМодулі:\n" + string.Join("\n", modules);
                MessageBox.Show(msg, "Потоки та модулі", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося отримати деталі:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
