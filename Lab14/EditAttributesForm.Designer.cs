namespace Lab14
{
    partial class EditAttributesForm
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
            chkHidden = new CheckBox();
            chkReadOnly = new CheckBox();
            chkArchive = new CheckBox();
            chkSystem = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // chkHidden
            // 
            chkHidden.AutoSize = true;
            chkHidden.Location = new Point(12, 12);
            chkHidden.Name = "chkHidden";
            chkHidden.Size = new Size(65, 19);
            chkHidden.TabIndex = 0;
            chkHidden.Text = "Hidden";
            chkHidden.UseVisualStyleBackColor = true;
            // 
            // chkReadOnly
            // 
            chkReadOnly.AutoSize = true;
            chkReadOnly.Location = new Point(12, 37);
            chkReadOnly.Name = "chkReadOnly";
            chkReadOnly.Size = new Size(77, 19);
            chkReadOnly.TabIndex = 1;
            chkReadOnly.Text = "ReadOnly";
            chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // chkArchive
            // 
            chkArchive.AutoSize = true;
            chkArchive.Location = new Point(12, 62);
            chkArchive.Name = "chkArchive";
            chkArchive.Size = new Size(66, 19);
            chkArchive.TabIndex = 2;
            chkArchive.Text = "Archive";
            chkArchive.UseVisualStyleBackColor = true;
            // 
            // chkSystem
            // 
            chkSystem.AutoSize = true;
            chkSystem.Location = new Point(12, 87);
            chkSystem.Name = "chkSystem";
            chkSystem.Size = new Size(64, 19);
            chkSystem.TabIndex = 3;
            chkSystem.Text = "System";
            chkSystem.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(12, 112);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(80, 23);
            btnOK.TabIndex = 4;
            btnOK.Text = "Зберегти";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(98, 112);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Відміна";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditAttributesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(182, 145);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkSystem);
            Controls.Add(chkArchive);
            Controls.Add(chkReadOnly);
            Controls.Add(chkHidden);
            Name = "EditAttributesForm";
            Text = "Атрибути ред.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkHidden;
        private CheckBox chkReadOnly;
        private CheckBox chkArchive;
        private CheckBox chkSystem;
        private Button btnOK;
        private Button btnCancel;
    }
}