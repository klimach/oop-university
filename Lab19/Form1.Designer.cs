namespace Lab19
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
            tabControl = new TabControl();
            cpuTabPage = new TabPage();
            listViewCPU = new ListView();
            gpuTabPage = new TabPage();
            listViewGPU = new ListView();
            driveTabPage = new TabPage();
            listViewDrive = new ListView();
            motherboardTabPage = new TabPage();
            listViewMotherboard = new ListView();
            networkTabPage = new TabPage();
            listViewNetwork = new ListView();
            biosTabPage = new TabPage();
            listViewBIOS = new ListView();
            tabControl.SuspendLayout();
            cpuTabPage.SuspendLayout();
            gpuTabPage.SuspendLayout();
            driveTabPage.SuspendLayout();
            motherboardTabPage.SuspendLayout();
            networkTabPage.SuspendLayout();
            biosTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(cpuTabPage);
            tabControl.Controls.Add(gpuTabPage);
            tabControl.Controls.Add(driveTabPage);
            tabControl.Controls.Add(motherboardTabPage);
            tabControl.Controls.Add(networkTabPage);
            tabControl.Controls.Add(biosTabPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // cpuTabPage
            // 
            cpuTabPage.Controls.Add(listViewCPU);
            cpuTabPage.Location = new Point(4, 24);
            cpuTabPage.Name = "cpuTabPage";
            cpuTabPage.Padding = new Padding(3);
            cpuTabPage.Size = new Size(792, 422);
            cpuTabPage.TabIndex = 0;
            cpuTabPage.Text = "CPU";
            cpuTabPage.UseVisualStyleBackColor = true;
            // 
            // listViewCPU
            // 
            listViewCPU.Dock = DockStyle.Fill;
            listViewCPU.Location = new Point(3, 3);
            listViewCPU.Name = "listViewCPU";
            listViewCPU.Size = new Size(786, 416);
            listViewCPU.TabIndex = 0;
            listViewCPU.UseCompatibleStateImageBehavior = false;
            listViewCPU.View = View.Details;
            // 
            // gpuTabPage
            // 
            gpuTabPage.Controls.Add(listViewGPU);
            gpuTabPage.Location = new Point(4, 24);
            gpuTabPage.Name = "gpuTabPage";
            gpuTabPage.Padding = new Padding(3);
            gpuTabPage.Size = new Size(792, 422);
            gpuTabPage.TabIndex = 1;
            gpuTabPage.Text = "GPU";
            gpuTabPage.UseVisualStyleBackColor = true;
            // 
            // listViewGPU
            // 
            listViewGPU.Dock = DockStyle.Fill;
            listViewGPU.Location = new Point(3, 3);
            listViewGPU.Name = "listViewGPU";
            listViewGPU.Size = new Size(786, 416);
            listViewGPU.TabIndex = 0;
            listViewGPU.UseCompatibleStateImageBehavior = false;
            listViewGPU.View = View.Details;
            // 
            // driveTabPage
            // 
            driveTabPage.Controls.Add(listViewDrive);
            driveTabPage.Location = new Point(4, 24);
            driveTabPage.Name = "driveTabPage";
            driveTabPage.Size = new Size(792, 422);
            driveTabPage.TabIndex = 2;
            driveTabPage.Text = "Drive";
            driveTabPage.UseVisualStyleBackColor = true;
            // 
            // listViewDrive
            // 
            listViewDrive.Dock = DockStyle.Fill;
            listViewDrive.Location = new Point(0, 0);
            listViewDrive.Name = "listViewDrive";
            listViewDrive.Size = new Size(792, 422);
            listViewDrive.TabIndex = 0;
            listViewDrive.UseCompatibleStateImageBehavior = false;
            listViewDrive.View = View.Details;
            // 
            // motherboardTabPage
            // 
            motherboardTabPage.Controls.Add(listViewMotherboard);
            motherboardTabPage.Location = new Point(4, 24);
            motherboardTabPage.Name = "motherboardTabPage";
            motherboardTabPage.Size = new Size(792, 422);
            motherboardTabPage.TabIndex = 3;
            motherboardTabPage.Text = "Motherboard";
            motherboardTabPage.UseVisualStyleBackColor = true;
            // 
            // listViewMotherboard
            // 
            listViewMotherboard.Dock = DockStyle.Fill;
            listViewMotherboard.Location = new Point(0, 0);
            listViewMotherboard.Name = "listViewMotherboard";
            listViewMotherboard.Size = new Size(792, 422);
            listViewMotherboard.TabIndex = 0;
            listViewMotherboard.UseCompatibleStateImageBehavior = false;
            listViewMotherboard.View = View.Details;
            // 
            // networkTabPage
            // 
            networkTabPage.Controls.Add(listViewNetwork);
            networkTabPage.Location = new Point(4, 24);
            networkTabPage.Name = "networkTabPage";
            networkTabPage.Size = new Size(792, 422);
            networkTabPage.TabIndex = 4;
            networkTabPage.Text = "Network";
            networkTabPage.UseVisualStyleBackColor = true;
            // 
            // listViewNetwork
            // 
            listViewNetwork.Dock = DockStyle.Fill;
            listViewNetwork.Location = new Point(0, 0);
            listViewNetwork.Name = "listViewNetwork";
            listViewNetwork.Size = new Size(792, 422);
            listViewNetwork.TabIndex = 0;
            listViewNetwork.UseCompatibleStateImageBehavior = false;
            listViewNetwork.View = View.Details;
            // 
            // biosTabPage
            // 
            biosTabPage.Controls.Add(listViewBIOS);
            biosTabPage.Location = new Point(4, 24);
            biosTabPage.Name = "biosTabPage";
            biosTabPage.Size = new Size(792, 422);
            biosTabPage.TabIndex = 5;
            biosTabPage.Text = "BIOS";
            biosTabPage.UseVisualStyleBackColor = true;
            // 
            // listViewBIOS
            // 
            listViewBIOS.Dock = DockStyle.Fill;
            listViewBIOS.Location = new Point(0, 0);
            listViewBIOS.Name = "listViewBIOS";
            listViewBIOS.Size = new Size(792, 422);
            listViewBIOS.TabIndex = 0;
            listViewBIOS.UseCompatibleStateImageBehavior = false;
            listViewBIOS.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            cpuTabPage.ResumeLayout(false);
            gpuTabPage.ResumeLayout(false);
            driveTabPage.ResumeLayout(false);
            motherboardTabPage.ResumeLayout(false);
            networkTabPage.ResumeLayout(false);
            biosTabPage.ResumeLayout(false);
            ResumeLayout(false);

            ConfigureListView(this.listViewCPU);
            ConfigureListView(this.listViewGPU);
            ConfigureListView(this.listViewDrive);
            ConfigureListView(this.listViewMotherboard);
            ConfigureListView(this.listViewNetwork);
            ConfigureListView(this.listViewBIOS);
        }
        private void ConfigureListView(ListView lv)
        {
            lv.Dock = DockStyle.Fill;
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Columns.Add("Property", 200, HorizontalAlignment.Left);
            lv.Columns.Add("Value", 550, HorizontalAlignment.Left);
        }
        #endregion

        private TabControl tabControl;
        private TabPage cpuTabPage;
        private TabPage gpuTabPage;
        private TabPage driveTabPage;
        private TabPage motherboardTabPage;
        private TabPage networkTabPage;
        private TabPage biosTabPage;
        private ListView listViewCPU;
        private ListView listViewGPU;
        private ListView listViewDrive;
        private ListView listViewMotherboard;
        private ListView listViewNetwork;
        private ListView listViewBIOS;
    }
}
