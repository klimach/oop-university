namespace RGR
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
            components = new System.ComponentModel.Container();
            lvPeople = new ListView();
            cmsLVPeople = new ContextMenuStrip(components);
            smiDetails = new ToolStripMenuItem();
            smiRemove = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            smiAddNew = new ToolStripMenuItem();
            btnSelectAll = new Button();
            gbTemplateChoice = new GroupBox();
            clbTemplates = new CheckedListBox();
            gbOutputFolder = new GroupBox();
            btnSelectFolder = new Button();
            tbOutputFolder = new TextBox();
            btnGenerateDocs = new Button();
            gbWordProviderChoise = new GroupBox();
            cbOpenXml = new CheckBox();
            cbInterop = new CheckBox();
            btnAddNew = new Button();
            btnDetails = new Button();
            btnRemove = new Button();
            cmsLVPeople.SuspendLayout();
            gbTemplateChoice.SuspendLayout();
            gbOutputFolder.SuspendLayout();
            gbWordProviderChoise.SuspendLayout();
            SuspendLayout();
            // 
            // lvPeople
            // 
            lvPeople.CheckBoxes = true;
            lvPeople.ContextMenuStrip = cmsLVPeople;
            lvPeople.FullRowSelect = true;
            lvPeople.Location = new Point(12, 41);
            lvPeople.Margin = new Padding(4, 3, 4, 3);
            lvPeople.MultiSelect = false;
            lvPeople.Name = "lvPeople";
            lvPeople.Size = new Size(760, 137);
            lvPeople.Sorting = SortOrder.Ascending;
            lvPeople.TabIndex = 0;
            lvPeople.UseCompatibleStateImageBehavior = false;
            lvPeople.View = View.Details;
            lvPeople.SelectedIndexChanged += lvPeople_SelectedIndexChanged;
            // 
            // cmsLVPeople
            // 
            cmsLVPeople.Items.AddRange(new ToolStripItem[] { smiDetails, smiRemove, toolStripSeparator1, smiAddNew });
            cmsLVPeople.Name = "contextMenuStrip1";
            cmsLVPeople.ShowImageMargin = false;
            cmsLVPeople.Size = new Size(160, 76);
            cmsLVPeople.Opening += cmsLVPeople_Opening;
            // 
            // smiDetails
            // 
            smiDetails.Name = "smiDetails";
            smiDetails.Size = new Size(159, 22);
            smiDetails.Text = "Деталі запису";
            smiDetails.Click += rowDetails_Click;
            // 
            // smiRemove
            // 
            smiRemove.Name = "smiRemove";
            smiRemove.Size = new Size(159, 22);
            smiRemove.Text = "Видалити запис";
            smiRemove.Click += rowRemove_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(156, 6);
            // 
            // smiAddNew
            // 
            smiAddNew.Name = "smiAddNew";
            smiAddNew.Size = new Size(159, 22);
            smiAddNew.Text = "Додати новий запис";
            smiAddNew.Click += rowAddNew_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.Location = new Point(12, 12);
            btnSelectAll.Margin = new Padding(4, 3, 4, 3);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(99, 23);
            btnSelectAll.TabIndex = 1;
            btnSelectAll.Text = "Обрати всі";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // gbTemplateChoice
            // 
            gbTemplateChoice.Controls.Add(clbTemplates);
            gbTemplateChoice.Location = new Point(12, 184);
            gbTemplateChoice.Margin = new Padding(4, 3, 4, 3);
            gbTemplateChoice.Name = "gbTemplateChoice";
            gbTemplateChoice.Padding = new Padding(4, 3, 4, 3);
            gbTemplateChoice.Size = new Size(290, 159);
            gbTemplateChoice.TabIndex = 2;
            gbTemplateChoice.TabStop = false;
            gbTemplateChoice.Text = "Шаблони документу(-ів)";
            // 
            // clbTemplates
            // 
            clbTemplates.FormattingEnabled = true;
            clbTemplates.Location = new Point(6, 22);
            clbTemplates.Margin = new Padding(4, 3, 4, 3);
            clbTemplates.Name = "clbTemplates";
            clbTemplates.Size = new Size(278, 130);
            clbTemplates.TabIndex = 0;
            // 
            // gbOutputFolder
            // 
            gbOutputFolder.Controls.Add(btnSelectFolder);
            gbOutputFolder.Controls.Add(tbOutputFolder);
            gbOutputFolder.Location = new Point(310, 184);
            gbOutputFolder.Margin = new Padding(4, 3, 4, 3);
            gbOutputFolder.Name = "gbOutputFolder";
            gbOutputFolder.Padding = new Padding(4, 3, 4, 3);
            gbOutputFolder.Size = new Size(464, 56);
            gbOutputFolder.TabIndex = 3;
            gbOutputFolder.TabStop = false;
            gbOutputFolder.Text = "Обрати папку";
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(346, 22);
            btnSelectFolder.Margin = new Padding(4, 3, 4, 3);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(112, 23);
            btnSelectFolder.TabIndex = 6;
            btnSelectFolder.Text = "Вибір папки";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // tbOutputFolder
            // 
            tbOutputFolder.Location = new Point(6, 22);
            tbOutputFolder.Margin = new Padding(4, 3, 4, 3);
            tbOutputFolder.Name = "tbOutputFolder";
            tbOutputFolder.Size = new Size(332, 23);
            tbOutputFolder.TabIndex = 5;
            // 
            // btnGenerateDocs
            // 
            btnGenerateDocs.BackColor = Color.YellowGreen;
            btnGenerateDocs.FlatStyle = FlatStyle.Popup;
            btnGenerateDocs.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateDocs.ForeColor = Color.Transparent;
            btnGenerateDocs.Location = new Point(495, 255);
            btnGenerateDocs.Margin = new Padding(4, 3, 4, 3);
            btnGenerateDocs.Name = "btnGenerateDocs";
            btnGenerateDocs.Size = new Size(276, 88);
            btnGenerateDocs.TabIndex = 4;
            btnGenerateDocs.Text = "Згенерувати документ";
            btnGenerateDocs.UseVisualStyleBackColor = false;
            btnGenerateDocs.Click += btnGenerateDocs_Click;
            // 
            // gbWordProviderChoise
            // 
            gbWordProviderChoise.Controls.Add(cbOpenXml);
            gbWordProviderChoise.Controls.Add(cbInterop);
            gbWordProviderChoise.Location = new Point(310, 247);
            gbWordProviderChoise.Name = "gbWordProviderChoise";
            gbWordProviderChoise.Size = new Size(178, 96);
            gbWordProviderChoise.TabIndex = 5;
            gbWordProviderChoise.TabStop = false;
            gbWordProviderChoise.Text = "Word-Провайдер";
            // 
            // cbOpenXml
            // 
            cbOpenXml.AutoSize = true;
            cbOpenXml.Enabled = false;
            cbOpenXml.Location = new Point(40, 58);
            cbOpenXml.Name = "cbOpenXml";
            cbOpenXml.Size = new Size(82, 19);
            cbOpenXml.TabIndex = 1;
            cbOpenXml.Text = "Open XML";
            cbOpenXml.UseVisualStyleBackColor = true;
            cbOpenXml.CheckedChanged += cbWordProvider_CheckedChanged;
            // 
            // cbInterop
            // 
            cbInterop.AutoSize = true;
            cbInterop.Checked = true;
            cbInterop.CheckState = CheckState.Checked;
            cbInterop.Location = new Point(40, 33);
            cbInterop.Name = "cbInterop";
            cbInterop.Size = new Size(99, 19);
            cbInterop.TabIndex = 0;
            cbInterop.Text = "Office Interop";
            cbInterop.UseVisualStyleBackColor = true;
            cbInterop.CheckedChanged += cbWordProvider_CheckedChanged;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(316, 12);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(129, 23);
            btnAddNew.TabIndex = 6;
            btnAddNew.Text = "Додати новий";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += rowAddNew_Click;
            // 
            // btnDetails
            // 
            btnDetails.Enabled = false;
            btnDetails.Location = new Point(615, 12);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(75, 23);
            btnDetails.TabIndex = 7;
            btnDetails.Text = "Деталі";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += rowDetails_Click;
            // 
            // btnRemove
            // 
            btnRemove.Enabled = false;
            btnRemove.Location = new Point(696, 12);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Видалити";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += rowRemove_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 349);
            Controls.Add(btnRemove);
            Controls.Add(btnDetails);
            Controls.Add(btnAddNew);
            Controls.Add(gbWordProviderChoise);
            Controls.Add(btnGenerateDocs);
            Controls.Add(gbOutputFolder);
            Controls.Add(gbTemplateChoice);
            Controls.Add(btnSelectAll);
            Controls.Add(lvPeople);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "РГР - Клімач О.П. - 101-пТК";
            Load += MainForm_Load;
            cmsLVPeople.ResumeLayout(false);
            gbTemplateChoice.ResumeLayout(false);
            gbOutputFolder.ResumeLayout(false);
            gbOutputFolder.PerformLayout();
            gbWordProviderChoise.ResumeLayout(false);
            gbWordProviderChoise.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvPeople;
        private Button btnSelectAll;
        private ContextMenuStrip cmsLVPeople;
        private ToolStripMenuItem smiDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem smiRemove;
        private ToolStripMenuItem smiAddNew;
        private GroupBox gbTemplateChoice;
        private CheckedListBox clbTemplates;
        private GroupBox gbOutputFolder;
        private Button btnGenerateDocs;
        private TextBox tbOutputFolder;
        private Button btnSelectFolder;
        private GroupBox gbWordProviderChoise;
        private CheckBox cbOpenXml;
        private CheckBox cbInterop;
        private Button btnAddNew;
        private Button btnDetails;
        private Button btnRemove;
    }
}
