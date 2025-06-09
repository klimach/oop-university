using System.IO.Compression;
using System.Security.AccessControl;

namespace Lab14
{
    public partial class MainForm : Form
    {
        private readonly string[] imgExt = [".jpg", ".jpeg", ".png", ".bmp", ".gif"];
        private readonly string[] txtExt = [".txt", ".log", ".csv"];
        public MainForm()
        {
            InitializeComponent();
            btnSaveText.Enabled = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }

        private void LoadDrives()
        {
            treeView1.Nodes.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode node = new(drive.Name)
                {
                    Tag = drive.RootDirectory.FullName
                };
                node.Nodes.Add("");
                treeView1.Nodes.Add(node);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "")
            {
                e.Node.Nodes.Clear();
                try
                {
                    string path = (string)e.Node.Tag;
                    foreach (string dir in Directory.GetDirectories(path))
                    {
                        TreeNode node = new(Path.GetFileName(dir))
                        {
                            Tag = dir
                        };
                        node.Nodes.Add("");
                        e.Node.Nodes.Add(node);
                    }
                }
                catch { }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = (string)e.Node!.Tag;
            DisplayDirectoryContent(path);
            DisplayDirectoryProperties(path);
        }

        private void DisplayDirectoryContent(string path)
        {
            listView1.Items.Clear();

            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    ListViewItem item = new(Path.GetFileName(dir));
                    item.SubItems.Add("Directory");
                    item.Tag = dir;
                    listView1.Items.Add(item);
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    ListViewItem item = new(Path.GetFileName(file));
                    item.SubItems.Add("File");
                    item.Tag = file;
                    listView1.Items.Add(item);
                }
            }
            catch { }
        }

        private void DisplayDirectoryProperties(string path)
        {
            DirectoryInfo dirInfo = new(path);
            lblProperties.Text = $"Каталог: {dirInfo.FullName}\n" +
                                 $"Створено: {dirInfo.CreationTime}\n" +
                                 $"Атрибути: {dirInfo.Attributes}";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var selectedItem = listView1.SelectedItems[0];
            string path = (string)selectedItem.Tag;

            if (selectedItem.SubItems[1].Text == "File")
                DisplayFileProperties(path);
            else
                DisplayDirectoryProperties(path);
        }

        private void DisplayFileProperties(string path)
        {
            FileInfo fileInfo = new(path);
            lblProperties.Text = $"Файл: {fileInfo.FullName}\n" +
                                 $"Розмір: {fileInfo.Length} байт\n" +
                                 $"Створено: {fileInfo.CreationTime}\n" +
                                 $"Атрибути: {fileInfo.Attributes}";

            if (IsImageFile(path))
            {
                pictureBox1.ImageLocation = path;
                pictureBox1.Visible = true;
                richTextBox1.Visible = false;
            }
            else if (IsTextFile(path))
            {
                pictureBox1.Visible = false;
                richTextBox1.Visible = true;
                try
                {
                    richTextBox1.Text = File.ReadAllText(path);
                }
                catch { richTextBox1.Text = "Не вдалося прочитати файл."; }
            }
            else
            {
                pictureBox1.Visible = false;
                richTextBox1.Visible = false;
            }
        }

        private bool IsImageFile(string path)
        {

            string ext = Path.GetExtension(path).ToLower();
            return imgExt.Contains(ext);
        }

        private bool IsTextFile(string path)
        {
            string ext = Path.GetExtension(path).ToLower();
            return txtExt.Contains(ext);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string? path = ((TreeNode)treeView1.SelectedNode)?.Tag?.ToString();
            if (string.IsNullOrEmpty(path)) return;

            string filter = txtFilter.Text.Trim().ToLower();
            listView1.Items.Clear();

            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    if (string.IsNullOrEmpty(filter) || Path.GetFileName(dir).Contains(filter, StringComparison.CurrentCultureIgnoreCase))
                    {
                        ListViewItem item = new(Path.GetFileName(dir));
                        item.SubItems.Add("Directory");
                        item.Tag = dir;
                        listView1.Items.Add(item);
                    }
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    if (string.IsNullOrEmpty(filter) || Path.GetFileName(file).Contains(filter, StringComparison.CurrentCultureIgnoreCase))
                    {
                        ListViewItem item = new(Path.GetFileName(file));
                        item.SubItems.Add("File");
                        item.Tag = file;
                        listView1.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        private void btnShowSecurity_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var selectedItem = listView1.SelectedItems[0];
            string path = (string)selectedItem.Tag;

            string result = "";

            try
            {
                if (selectedItem.SubItems[1].Text == "File")
                {
                    FileInfo fi = new(path);
                    FileSecurity security = fi.GetAccessControl();

                    AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));

                    foreach (FileSystemAccessRule rule in rules)
                    {
                        result += $"Користувач/група: {rule.IdentityReference.Value}\n" +
                                  $"Права: {rule.FileSystemRights}\n" +
                                  $"Тип доступу: {rule.AccessControlType}\n" +
                                  $"Успадковується: {rule.IsInherited}\n\n";
                    }
                }
                else
                {
                    DirectoryInfo di = new(path);
                    DirectorySecurity security = di.GetAccessControl();

                    AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));

                    foreach (FileSystemAccessRule rule in rules)
                    {
                        result += $"Користувач/група: {rule.IdentityReference.Value}\n" +
                                  $"Права: {rule.FileSystemRights}\n" +
                                  $"Тип доступу: {rule.AccessControlType}\n" +
                                  $"Успадковується: {rule.IsInherited}\n\n";
                    }
                }
            }
            catch (Exception ex)
            {
                result = "Помилка отримання атрибутів безпеки: " + ex.Message;
            }

            MessageBox.Show(result, "Атрибути безпеки");
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            string path = (string)treeView1.SelectedNode.Tag;

            string folderName = Microsoft.VisualBasic.Interaction.InputBox("Введіть ім'я каталогу:", "Створити каталог", "New Folder");
            if (string.IsNullOrWhiteSpace(folderName)) return;

            string newFolderPath = Path.Combine(path, folderName);
            try
            {
                Directory.CreateDirectory(newFolderPath);
                DisplayDirectoryContent(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка створення каталогу: " + ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            string path = (string)treeView1.SelectedNode.Tag;

            string fileName = Microsoft.VisualBasic.Interaction.InputBox("Введіть ім'я файлу:", "Створити файл", "NewFile.txt");
            if (string.IsNullOrWhiteSpace(fileName)) return;

            string newFilePath = Path.Combine(path, fileName);
            try
            {
                File.WriteAllText(newFilePath, ""); // Порожній файл
                DisplayDirectoryContent(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка створення файлу: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var selectedItem = listView1.SelectedItems[0];
            string path = (string)selectedItem.Tag;

            if (MessageBox.Show($"Ви дійсно хочете видалити '{Path.GetFileName(path)}'?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (selectedItem.SubItems[1].Text == "File")
                        File.Delete(path);
                    else
                        Directory.Delete(path, true);

                    DisplayDirectoryContent(((TreeNode)treeView1.SelectedNode).Tag.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка видалення: " + ex.Message);
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var selectedItem = listView1.SelectedItems[0];
            string path = (string)selectedItem.Tag;

            string destPath = Microsoft.VisualBasic.Interaction.InputBox("Введіть шлях призначення:", "Копіювати", Path.GetDirectoryName(path)!);

            try
            {
                if (selectedItem.SubItems[1].Text == "File")
                    File.Copy(path, Path.Combine(destPath, Path.GetFileName(path)), true);
                else
                    CopyDirectory(path, Path.Combine(destPath, Path.GetFileName(path)));

                DisplayDirectoryContent(((TreeNode)treeView1.SelectedNode).Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка копіювання: " + ex.Message);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var selectedItem = listView1.SelectedItems[0];
            string sourcePath = (string)selectedItem.Tag;

            // Спитати користувача куди перемістити
            string destDir = Microsoft.VisualBasic.Interaction.InputBox("Введіть шлях призначення:", "Перемістити", Path.GetDirectoryName(sourcePath)!);
            if (string.IsNullOrWhiteSpace(destDir)) return;

            string destPath = Path.Combine(destDir, Path.GetFileName(sourcePath));

            try
            {
                if (selectedItem.SubItems[1].Text == "File")
                {
                    File.Move(sourcePath, destPath);
                }
                else
                {
                    Directory.Move(sourcePath, destPath);
                }

                MessageBox.Show("Успішно переміщено.");
                DisplayDirectoryContent(((TreeNode)treeView1.SelectedNode).Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка переміщення: " + ex.Message);
            }
        }

        private void CopyDirectory(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), true);
            }
            foreach (string dir in Directory.GetDirectories(sourceDir))
            {
                CopyDirectory(dir, Path.Combine(targetDir, Path.GetFileName(dir)));
            }
        }

        private void btnEditAttributes_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var selectedItem = listView1.SelectedItems[0];
            string path = (string)selectedItem.Tag;

            try
            {
                FileAttributes currentAttributes = File.GetAttributes(path);

                using EditAttributesForm form = new EditAttributesForm(currentAttributes);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    File.SetAttributes(path, form.SelectedAttributes);
                    MessageBox.Show("Атрибути оновлено.");

                    if (selectedItem.SubItems[1].Text == "File")
                        DisplayFileProperties(path);
                    else
                        DisplayDirectoryProperties(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка редагування атрибутів: " + ex.Message);
            }
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var selectedItem = listView1.SelectedItems[0];
            string path = (string)selectedItem.Tag;

            if (!IsTextFile(path)) return;

            try
            {
                File.WriteAllText(path, richTextBox1.Text);
                btnSaveText.Enabled = false;
                MessageBox.Show("Файл збережено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження файлу: " + ex.Message);
            }
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var selectedItem = listView1.SelectedItems[0];
            string path = (string)selectedItem.Tag;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ZIP files (*.zip)|*.zip";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (selectedItem.SubItems[1].Text == "Directory")
                    {
                        ZipFile.CreateFromDirectory(path, saveFileDialog.FileName);
                    }
                    else
                    {
                        string tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                        Directory.CreateDirectory(tempDir);
                        File.Copy(path, Path.Combine(tempDir, Path.GetFileName(path)));
                        ZipFile.CreateFromDirectory(tempDir, saveFileDialog.FileName);
                        Directory.Delete(tempDir, true);
                    }

                    MessageBox.Show("Архів створено.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка архівації: " + ex.Message);
                }
            }
        }

        private void btnUnzip_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ZIP files (*.zip)|*.zip";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ZipFile.ExtractToDirectory(openFileDialog.FileName, folderDialog.SelectedPath);
                        MessageBox.Show("Архів розпаковано.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка розпакування: " + ex.Message);
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            btnSaveText.Enabled = true;
        }
    }
}
