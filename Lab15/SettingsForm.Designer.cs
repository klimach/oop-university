namespace Lab15
{
    partial class SettingsForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            // tbHost
            this.tbHost.Location = new System.Drawing.Point(12, 12);
            this.tbHost.Size = new System.Drawing.Size(300, 20);
            this.tbHost.Text = "ftp://127.0.0.1/";

            // tbUser
            this.tbUser.Location = new System.Drawing.Point(12, 38);
            this.tbUser.Size = new System.Drawing.Size(300, 20);
            this.tbUser.Text = "User";

            // tbPass
            this.tbPass.Location = new System.Drawing.Point(12, 64);
            this.tbPass.Size = new System.Drawing.Size(300, 20);
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.Text = "Password";

            // btnSave
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(12, 100);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnLoad
            this.btnLoad.Text = "Load";
            this.btnLoad.Location = new System.Drawing.Point(100, 100);
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(200, 100);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // SettingsForm
            this.ClientSize = new System.Drawing.Size(330, 150);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClose);
            this.Text = "Налаштування клієнта";
        }

        #endregion

        private TextBox tbHost;
        private TextBox tbUser;
        private TextBox tbPass;
        private Button btnSave;
        private Button btnLoad;
        private Button btnClose;
    }
}