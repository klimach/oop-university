using System.IO.Compression;
using System.Security.AccessControl;
using static System.Net.Mime.MediaTypeNames;

namespace Lab13
{
    public partial class MainForm : Form
    {
        private readonly string[] imgExt = [".jpg", ".jpeg", ".png", ".bmp", ".gif"];
        private readonly string[] txtExt = [".txt", ".log", ".csv"];
        public MainForm()
        {
            InitializeComponent();
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
    }
}
