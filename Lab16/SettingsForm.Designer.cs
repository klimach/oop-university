namespace Lab16
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
            hostTextBox = new TextBox();
            btnFont = new Button();
            lblFontPreview = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            hostLbl = new Label();
            label2 = new Label();
            label3 = new Label();
            remotePortTextBox = new TextBox();
            localPortTextBox = new TextBox();
            SuspendLayout();
            // 
            // hostTextBox
            // 
            hostTextBox.Location = new Point(105, 12);
            hostTextBox.Name = "hostTextBox";
            hostTextBox.Size = new Size(152, 23);
            hostTextBox.TabIndex = 0;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(101, 128);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(75, 23);
            btnFont.TabIndex = 3;
            btnFont.Text = "Шрифт";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // lblFontPreview
            // 
            lblFontPreview.AutoSize = true;
            lblFontPreview.Location = new Point(121, 167);
            lblFontPreview.Name = "lblFontPreview";
            lblFontPreview.Size = new Size(31, 15);
            lblFontPreview.TabIndex = 4;
            lblFontPreview.Text = "Font";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(101, 241);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 5;
            btnOk.Text = "ОК";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(182, 241);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Відміна";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // hostLbl
            // 
            hostLbl.AutoSize = true;
            hostLbl.Location = new Point(17, 15);
            hostLbl.Name = "hostLbl";
            hostLbl.Size = new Size(56, 15);
            hostLbl.TabIndex = 7;
            hostLbl.Text = "Хост (IP):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 43);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Local - порт:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 72);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 9;
            label3.Text = "Remote - порт:";
            // 
            // remotePortTextBox
            // 
            remotePortTextBox.Location = new Point(105, 69);
            remotePortTextBox.Name = "remotePortTextBox";
            remotePortTextBox.Size = new Size(152, 23);
            remotePortTextBox.TabIndex = 10;
            // 
            // localPortTextBox
            // 
            localPortTextBox.Location = new Point(105, 40);
            localPortTextBox.Name = "localPortTextBox";
            localPortTextBox.Size = new Size(152, 23);
            localPortTextBox.TabIndex = 11;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 276);
            Controls.Add(localPortTextBox);
            Controls.Add(remotePortTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(hostLbl);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblFontPreview);
            Controls.Add(btnFont);
            Controls.Add(hostTextBox);
            Name = "SettingsForm";
            Text = "Налаштування";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hostTextBox;
        private Button btnFont;
        private Label lblFontPreview;
        private Button btnOk;
        private Button btnCancel;
        private Label hostLbl;
        private Label label2;
        private Label label3;
        private TextBox remotePortTextBox;
        private TextBox localPortTextBox;
    }
}