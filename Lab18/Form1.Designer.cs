namespace Lab18
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lvProcesses = new ListView();
            name = new ColumnHeader();
            pid = new ColumnHeader();
            status = new ColumnHeader();
            memory = new ColumnHeader();
            cmsProcess = new ContextMenuStrip(components);
            showInfo_tsmi = new ToolStripMenuItem();
            stopProcess_tsmi = new ToolStripMenuItem();
            threadsAndModules_tsmi = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            cmsProcess.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lvProcesses
            // 
            lvProcesses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProcesses.Columns.AddRange(new ColumnHeader[] { name, pid, status, memory });
            lvProcesses.ContextMenuStrip = cmsProcess;
            lvProcesses.FullRowSelect = true;
            lvProcesses.Location = new Point(0, 25);
            lvProcesses.Name = "lvProcesses";
            lvProcesses.Size = new Size(407, 301);
            lvProcesses.TabIndex = 2;
            lvProcesses.UseCompatibleStateImageBehavior = false;
            lvProcesses.View = View.Details;
            // 
            // name
            // 
            name.Tag = "";
            name.Text = "Ім'я";
            name.Width = 100;
            // 
            // pid
            // 
            pid.Text = "PID";
            pid.Width = 100;
            // 
            // status
            // 
            status.Text = "Статус";
            status.Width = 100;
            // 
            // memory
            // 
            memory.Text = "Пам'ять";
            memory.Width = 100;
            // 
            // cmsProcess
            // 
            cmsProcess.Items.AddRange(new ToolStripItem[] { showInfo_tsmi, stopProcess_tsmi, threadsAndModules_tsmi });
            cmsProcess.Name = "contextMenuStrip1";
            cmsProcess.Size = new Size(197, 70);
            // 
            // showInfo_tsmi
            // 
            showInfo_tsmi.Name = "showInfo_tsmi";
            showInfo_tsmi.Size = new Size(196, 22);
            showInfo_tsmi.Text = "Показати інформацію";
            showInfo_tsmi.Click += showInfo_tsmi_Click;
            // 
            // stopProcess_tsmi
            // 
            stopProcess_tsmi.Name = "stopProcess_tsmi";
            stopProcess_tsmi.Size = new Size(196, 22);
            stopProcess_tsmi.Text = "Зупинити процес";
            stopProcess_tsmi.Click += stopProcess_tsmi_Click;
            // 
            // threadsAndModules_tsmi
            // 
            threadsAndModules_tsmi.Name = "threadsAndModules_tsmi";
            threadsAndModules_tsmi.Size = new Size(196, 22);
            threadsAndModules_tsmi.Text = "Потоки і модулі";
            threadsAndModules_tsmi.Click += threadsAndModules_tsmi_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(407, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(59, 22);
            toolStripButton1.Text = "Оновити";
            toolStripButton1.Click += btnRefresh_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(85, 22);
            toolStripButton2.Text = "Експортувати";
            toolStripButton2.Click += btnExport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 326);
            Controls.Add(toolStrip1);
            Controls.Add(lvProcesses);
            Name = "Form1";
            Text = "Lab18 - Клімач О.П. - 101-пТК";
            cmsProcess.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvProcesses;
        private ContextMenuStrip cmsProcess;
        private ToolStripMenuItem showInfo_tsmi;
        private ToolStripMenuItem stopProcess_tsmi;
        private ToolStripMenuItem threadsAndModules_tsmi;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ColumnHeader name;
        private ColumnHeader pid;
        private ColumnHeader status;
        private ColumnHeader memory;
    }
}
