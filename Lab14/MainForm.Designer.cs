using System.Windows.Forms;

namespace Lab14
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            listView1 = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderType = new ColumnHeader();
            lblProperties = new Label();
            txtFilter = new TextBox();
            btnFilter = new Button();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            btnShowSecurity = new Button();
            btnCreateDir = new Button();
            btnCreateFile = new Button();
            btnDelete = new Button();
            btnCopy = new Button();
            btnMove = new Button();
            btnZip = new Button();
            btnUnzip = new Button();
            btnSaveText = new Button();
            btnEditAttributes = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(200, 404);
            treeView1.TabIndex = 0;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderType });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(217, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(400, 221);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 250;
            // 
            // columnHeaderType
            // 
            columnHeaderType.Text = "Type";
            columnHeaderType.Width = 100;
            // 
            // lblProperties
            // 
            lblProperties.BorderStyle = BorderStyle.FixedSingle;
            lblProperties.Location = new Point(217, 236);
            lblProperties.Name = "lblProperties";
            lblProperties.Size = new Size(200, 151);
            lblProperties.TabIndex = 2;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(217, 393);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(200, 23);
            txtFilter.TabIndex = 3;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(423, 393);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(88, 23);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Фільтр";
            btnFilter.Click += btnFilter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(422, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(423, 236);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(194, 151);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // btnShowSecurity
            // 
            btnShowSecurity.Location = new Point(491, 427);
            btnShowSecurity.Name = "btnShowSecurity";
            btnShowSecurity.Size = new Size(126, 23);
            btnShowSecurity.TabIndex = 7;
            btnShowSecurity.Text = "Атр. безпеки";
            btnShowSecurity.Click += btnShowSecurity_Click;
            // 
            // btnCreateDir
            // 
            btnCreateDir.Location = new Point(12, 427);
            btnCreateDir.Name = "btnCreateDir";
            btnCreateDir.Size = new Size(128, 23);
            btnCreateDir.TabIndex = 8;
            btnCreateDir.Text = "Створити теку";
            btnCreateDir.UseVisualStyleBackColor = true;
            btnCreateDir.Click += btnCreateFolder_Click;
            // 
            // btnCreateFile
            // 
            btnCreateFile.Location = new Point(12, 456);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(128, 23);
            btnCreateFile.TabIndex = 9;
            btnCreateFile.Text = "Створити файл";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += btnCreateFile_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(146, 427);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(146, 456);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 11;
            btnCopy.Text = "Копіювати";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(227, 456);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(100, 23);
            btnMove.TabIndex = 12;
            btnMove.Text = "Перемістити";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // btnZip
            // 
            btnZip.Location = new Point(333, 427);
            btnZip.Name = "btnZip";
            btnZip.Size = new Size(75, 23);
            btnZip.TabIndex = 13;
            btnZip.Text = "Zip";
            btnZip.UseVisualStyleBackColor = true;
            btnZip.Click += btnZip_Click;
            // 
            // btnUnzip
            // 
            btnUnzip.Location = new Point(333, 456);
            btnUnzip.Name = "btnUnzip";
            btnUnzip.Size = new Size(75, 23);
            btnUnzip.TabIndex = 14;
            btnUnzip.Text = "UnZip";
            btnUnzip.UseVisualStyleBackColor = true;
            btnUnzip.Click += btnUnzip_Click;
            // 
            // btnSaveText
            // 
            btnSaveText.Location = new Point(542, 393);
            btnSaveText.Name = "btnSaveText";
            btnSaveText.Size = new Size(75, 23);
            btnSaveText.TabIndex = 15;
            btnSaveText.Text = "Зберегти";
            btnSaveText.UseVisualStyleBackColor = true;
            btnSaveText.Click += btnSaveText_Click;
            // 
            // btnEditAttributes
            // 
            btnEditAttributes.Location = new Point(491, 456);
            btnEditAttributes.Name = "btnEditAttributes";
            btnEditAttributes.Size = new Size(126, 23);
            btnEditAttributes.TabIndex = 16;
            btnEditAttributes.Text = "Атр. редагувати";
            btnEditAttributes.UseVisualStyleBackColor = true;
            btnEditAttributes.Click += btnEditAttributes_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(629, 483);
            Controls.Add(btnEditAttributes);
            Controls.Add(btnSaveText);
            Controls.Add(btnUnzip);
            Controls.Add(btnZip);
            Controls.Add(btnMove);
            Controls.Add(btnCopy);
            Controls.Add(btnDelete);
            Controls.Add(btnCreateFile);
            Controls.Add(btnCreateDir);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(lblProperties);
            Controls.Add(txtFilter);
            Controls.Add(btnFilter);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(btnShowSecurity);
            Name = "MainForm";
            Text = "Lab14 - Клімач О.П. - 101-пТК";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ListView listView1;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderType;
        private Label lblProperties;
        private TextBox txtFilter;
        private Button btnFilter;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Button btnShowSecurity;
        private Button btnCreateDir;
        private Button btnCreateFile;
        private Button btnDelete;
        private Button btnCopy;
        private Button btnMove;
        private Button btnZip;
        private Button btnUnzip;
        private Button btnSaveText;
        private Button btnEditAttributes;
    }
}
