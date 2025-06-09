using Microsoft.VisualBasic.ApplicationServices;

namespace Lab15
{
    public partial class MainForm : Form
    {

        private bool isListMode = false;

        private string host = string.Empty;
        private string user = string.Empty;
        private string password = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                string settingsFile = "settings.txt";

                if (File.Exists(settingsFile))
                {
                    string[] lines = File.ReadAllLines(settingsFile);
                    host = lines.Length > 0 ? lines[0] : "";
                    user = lines.Length > 1 ? lines[1] : "";
                    password = lines.Length > 2 ? lines[2] : "";
                }
                else
                {
                    host = "ftp://127.0.0.1/";
                    user = "admin";
                    password = "admin";

                    MessageBox.Show("Помилка завантаження налаштувань. Файл налаштувань відсутній. Встановлені стандартні значення");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження налаштувань: " + ex.Message);
            }
        }

        private void SetButtonsEnable()
        {
            btnUpload.Enabled = true;
            btnUploadUnique.Enabled = true;
            btnAppend.Enabled = true;
            btnDownload.Enabled = true;
            btnDelete.Enabled = true;
            btnMDTM.Enabled = true;
            btnSIZE.Enabled = true;
            btnMKD.Enabled = true;
            btnRMD.Enabled = true;
            btnRENAME.Enabled = true;
            btnUploadDirectory.Enabled = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!isListMode)
                return;

            string fileName = e.Node.Text;
            string fullListLine = e.Node.Tag != null ? e.Node.Tag.ToString() : "";

            MessageBox.Show($"Ім'я: {fileName}\nІнформація з LIST: {fullListLine}");
        }

        private void btnLIST_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            try
            {
                string[] entries = FtpHelper.ListDirectoryDetails(host, user, password);


                foreach (var entry in entries)
                {
                    string[] parts = entry.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                    string fileName = parts.Length >= 9 ? parts[8] : "";
                    var node = new TreeNode(fileName)
                    {
                        Tag = entry
                    };
                    treeView1.Nodes.Add(node);
                }
                isListMode = true;
                SetButtonsEnable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnNLIST_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            try
            {
                string[] entries = FtpHelper.ListNames(host, user, password);
                foreach (var entry in entries)
                {
                    treeView1.Nodes.Add(new TreeNode(entry));
                }
                isListMode = false;
                SetButtonsEnable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ftpPath = host + System.IO.Path.GetFileName(openFileDialog1.FileName);
                    FtpHelper.UploadFile(ftpPath, user, password, openFileDialog1.FileName);
                    MessageBox.Show("Успішно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void btnUploadUnique_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ftpPath = host;
                    FtpHelper.UploadFileUnique(ftpPath, user, password, openFileDialog1.FileName);
                    MessageBox.Show("Успішно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }

            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ftpPath = host + Path.GetFileName(openFileDialog1.FileName);
                    FtpHelper.AppendFile(ftpPath, user, password, openFileDialog1.FileName);
                    MessageBox.Show("Успішно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ftpPath = host + treeView1.SelectedNode.Text;
                    FtpHelper.DownloadFile(ftpPath, user, password, saveFileDialog1.FileName);
                    MessageBox.Show("Успішно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                try
                {
                    string ftpPath = host + treeView1.SelectedNode.Text;
                    FtpHelper.DeleteFile(ftpPath, user, password);
                    MessageBox.Show("Файл успішно видалено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void btnMDTM_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                try
                {
                    string ftpPath = host + treeView1.SelectedNode.Text;
                    DateTime dt = FtpHelper.GetModifiedTime(ftpPath, user, password);
                    MessageBox.Show("Зміни внесено: " + dt.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void btnSIZE_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                try
                {
                    string ftpPath = host + treeView1.SelectedNode.Text;
                    long size = FtpHelper.GetFileSize(ftpPath, user, password);
                    MessageBox.Show("Розмір: " + size + " bytes");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void btnMKD_Click(object sender, EventArgs e)
        {
            string newDir = Microsoft.VisualBasic.Interaction.InputBox("Введіть ім'я нового каталогу:");
            if (!string.IsNullOrEmpty(newDir))
            {
                try
                {
                    string ftpPath = host + newDir;
                    FtpHelper.CreateDirectory(ftpPath, user, password);
                    MessageBox.Show("Теку створено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void btnRMD_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                try
                {
                    string ftpPath = host + treeView1.SelectedNode.Text;
                    FtpHelper.RemoveDirectory(ftpPath, user, password);
                    MessageBox.Show("Теку видалено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void btnRENAME_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                try
                {
                    string ftpPath = host + treeView1.SelectedNode.Text;
                    string newName = Microsoft.VisualBasic.Interaction.InputBox("Введіть нове ім'я:");
                    if (!string.IsNullOrEmpty(newName))
                    {
                        FtpHelper.Rename(ftpPath, user, password, newName);
                        MessageBox.Show("Успішно перейменовано");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void btnUploadDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string localDirPath = fbd.SelectedPath;
                        string ftpTargetDir = host + Path.GetFileName(localDirPath);

                        UploadDirectory(localDirPath, ftpTargetDir);

                        MessageBox.Show("Каталог завантажено!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка: " + ex.Message);
                    }

                }
            }
        }

        void UploadDirectory(string localDirPath, string ftpDirPath)
        {
            FtpHelper.CreateDirectory(ftpDirPath, user, password);
            string[] files = Directory.GetFiles(localDirPath);
            foreach (string filePath in files)
            {
                string ftpFilePath = ftpDirPath + "/" + Path.GetFileName(filePath);
                FtpHelper.UploadFile(ftpFilePath, user, password, filePath);
            }
            string[] subDirs = Directory.GetDirectories(localDirPath);
            foreach (string subDir in subDirs)
            {
                string ftpSubDirPath = ftpDirPath + "/" + Path.GetFileName(subDir);
                UploadDirectory(subDir, ftpSubDirPath);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

            host = settingsForm.Host;
            user = settingsForm.User;
            password = settingsForm.Pass;
        }
    }
}
