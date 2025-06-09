using System.Windows.Forms;

namespace Lab13
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(200, 400);
            treeView1.TabIndex = 0;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderType });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(218, 38);
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
            lblProperties.Location = new Point(218, 262);
            lblProperties.Name = "lblProperties";
            lblProperties.Size = new Size(200, 151);
            lblProperties.TabIndex = 2;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(218, 12);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(200, 23);
            txtFilter.TabIndex = 3;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(424, 12);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(88, 23);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Фільтр";
            btnFilter.Click += btnFilter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(423, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(424, 262);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(194, 147);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // btnShowSecurity
            // 
            btnShowSecurity.Location = new Point(518, 12);
            btnShowSecurity.Name = "btnShowSecurity";
            btnShowSecurity.Size = new Size(100, 23);
            btnShowSecurity.TabIndex = 7;
            btnShowSecurity.Text = "Атр. безпеки";
            btnShowSecurity.Click += btnShowSecurity_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(629, 421);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(lblProperties);
            Controls.Add(txtFilter);
            Controls.Add(btnFilter);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(btnShowSecurity);
            Name = "MainForm";
            Text = "Lab13 - Клімач О.П. - 101-пТК";
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
    }
}
