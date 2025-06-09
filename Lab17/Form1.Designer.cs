namespace Lab17
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
            txtUserName = new TextBox();
            btnLogin = new Button();
            rtbChat = new RichTextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(96, 29);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(183, 23);
            txtUserName.TabIndex = 0;
            txtUserName.Text = "Анонім";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(285, 29);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(97, 23);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Доєднатися";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // rtbChat
            // 
            rtbChat.Location = new Point(19, 58);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(414, 96);
            rtbChat.TabIndex = 2;
            rtbChat.Text = "";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(19, 160);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Введіть повідомлення";
            txtMessage.Size = new Size(320, 23);
            txtMessage.TabIndex = 3;
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(345, 159);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(88, 23);
            btnSend.TabIndex = 4;
            btnSend.Text = "Відправити";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 33);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "Нік:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 201);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(rtbChat);
            Controls.Add(btnLogin);
            Controls.Add(txtUserName);
            Name = "Form1";
            Text = "Lab 17 - Клімач О.П. - 101-пТК";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Button btnLogin;
        private RichTextBox rtbChat;
        private TextBox txtMessage;
        private Button btnSend;
        private Label label1;
    }
}
