namespace Lab15
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            btnLIST = new Button();
            btnNLIST = new Button();
            btnUpload = new Button();
            btnUploadUnique = new Button();
            btnAppend = new Button();
            btnDownload = new Button();
            btnDelete = new Button();
            btnMDTM = new Button();
            btnSIZE = new Button();
            btnMKD = new Button();
            btnRMD = new Button();
            btnRENAME = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnUploadDirectory = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(247, 72);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(542, 389);
            treeView1.TabIndex = 3;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // btnLIST
            // 
            btnLIST.Location = new Point(247, 12);
            btnLIST.Name = "btnLIST";
            btnLIST.Size = new Size(105, 49);
            btnLIST.TabIndex = 4;
            btnLIST.Text = "Підключитися (LIST)";
            btnLIST.Click += btnLIST_Click;
            // 
            // btnNLIST
            // 
            btnNLIST.Location = new Point(358, 12);
            btnNLIST.Name = "btnNLIST";
            btnNLIST.Size = new Size(121, 49);
            btnNLIST.TabIndex = 5;
            btnNLIST.Text = "NLIST";
            btnNLIST.Click += btnNLIST_Click;
            // 
            // btnUpload
            // 
            btnUpload.Enabled = false;
            btnUpload.Location = new Point(12, 72);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(229, 30);
            btnUpload.TabIndex = 6;
            btnUpload.Text = "STOR (Завантажити)";
            btnUpload.Click += btnUpload_Click;
            // 
            // btnUploadUnique
            // 
            btnUploadUnique.Enabled = false;
            btnUploadUnique.Location = new Point(12, 108);
            btnUploadUnique.Name = "btnUploadUnique";
            btnUploadUnique.Size = new Size(229, 30);
            btnUploadUnique.TabIndex = 7;
            btnUploadUnique.Text = "STOU (Завантажити унік.)";
            btnUploadUnique.Click += btnUploadUnique_Click;
            // 
            // btnAppend
            // 
            btnAppend.Enabled = false;
            btnAppend.Location = new Point(12, 180);
            btnAppend.Name = "btnAppend";
            btnAppend.Size = new Size(229, 30);
            btnAppend.TabIndex = 8;
            btnAppend.Text = "APPE (Доповнити)";
            btnAppend.Click += btnAppend_Click;
            // 
            // btnDownload
            // 
            btnDownload.Enabled = false;
            btnDownload.Location = new Point(12, 144);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(229, 30);
            btnDownload.TabIndex = 9;
            btnDownload.Text = "RETR (Вивантажити)";
            btnDownload.Click += btnDownload_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(12, 216);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(229, 30);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "DELE (Видалити файл)";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMDTM
            // 
            btnMDTM.Enabled = false;
            btnMDTM.Location = new Point(12, 252);
            btnMDTM.Name = "btnMDTM";
            btnMDTM.Size = new Size(229, 30);
            btnMDTM.TabIndex = 11;
            btnMDTM.Text = "MDTM (Дата зміни)";
            btnMDTM.Click += btnMDTM_Click;
            // 
            // btnSIZE
            // 
            btnSIZE.Enabled = false;
            btnSIZE.Location = new Point(12, 288);
            btnSIZE.Name = "btnSIZE";
            btnSIZE.Size = new Size(229, 30);
            btnSIZE.TabIndex = 12;
            btnSIZE.Text = "SIZE (Розмір файлу)";
            btnSIZE.Click += btnSIZE_Click;
            // 
            // btnMKD
            // 
            btnMKD.Enabled = false;
            btnMKD.Location = new Point(12, 324);
            btnMKD.Name = "btnMKD";
            btnMKD.Size = new Size(229, 30);
            btnMKD.TabIndex = 13;
            btnMKD.Text = "MKD (Створити теку)";
            btnMKD.Click += btnMKD_Click;
            // 
            // btnRMD
            // 
            btnRMD.Enabled = false;
            btnRMD.Location = new Point(12, 359);
            btnRMD.Name = "btnRMD";
            btnRMD.Size = new Size(229, 30);
            btnRMD.TabIndex = 14;
            btnRMD.Text = "RMD (Видалити теку)";
            btnRMD.Click += btnRMD_Click;
            // 
            // btnRENAME
            // 
            btnRENAME.Enabled = false;
            btnRENAME.Location = new Point(12, 395);
            btnRENAME.Name = "btnRENAME";
            btnRENAME.Size = new Size(229, 30);
            btnRENAME.TabIndex = 15;
            btnRENAME.Text = "Перейменувати";
            btnRENAME.Click += btnRENAME_Click;
            // 
            // btnUploadDirectory
            // 
            btnUploadDirectory.Enabled = false;
            btnUploadDirectory.Location = new Point(12, 431);
            btnUploadDirectory.Name = "btnUploadDirectory";
            btnUploadDirectory.Size = new Size(229, 30);
            btnUploadDirectory.TabIndex = 16;
            btnUploadDirectory.Text = "Завантажити теку";
            btnUploadDirectory.Click += btnUploadDirectory_Click;
            // 
            // button1
            // 
            button1.Location = new Point(668, 9);
            button1.Name = "button1";
            button1.Size = new Size(121, 49);
            button1.TabIndex = 17;
            button1.Text = "Налаштування";
            button1.Click += btnSettings_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(801, 482);
            Controls.Add(button1);
            Controls.Add(btnUploadDirectory);
            Controls.Add(treeView1);
            Controls.Add(btnLIST);
            Controls.Add(btnNLIST);
            Controls.Add(btnUpload);
            Controls.Add(btnUploadUnique);
            Controls.Add(btnAppend);
            Controls.Add(btnDownload);
            Controls.Add(btnDelete);
            Controls.Add(btnMDTM);
            Controls.Add(btnSIZE);
            Controls.Add(btnMKD);
            Controls.Add(btnRMD);
            Controls.Add(btnRENAME);
            Name = "MainForm";
            Text = "Lab 15 - Клімач О.П. - 101-пТК";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private TreeView treeView1;

        private Button btnLIST;
        private Button btnNLIST;
        private Button btnUpload;
        private Button btnUploadUnique;
        private Button btnAppend;
        private Button btnDownload;
        private Button btnDelete;
        private Button btnMDTM;
        private Button btnSIZE;
        private Button btnMKD;
        private Button btnRMD;
        private Button btnRENAME;

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnUploadDirectory;
        private Button button1;
    }
}
