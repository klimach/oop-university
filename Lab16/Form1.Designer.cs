namespace Lab16
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
            userNameTextBox = new TextBox();
            loginButton = new Button();
            logoutButton = new Button();
            sendButton = new Button();
            chatTextBox = new RichTextBox();
            messageTextBox = new RichTextBox();
            label1 = new Label();
            settingsBtn = new Button();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(218, 25);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(177, 23);
            userNameTextBox.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(401, 12);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(103, 23);
            loginButton.TabIndex = 1;
            loginButton.Text = "Вхід";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(401, 41);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(103, 23);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Вихід";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(401, 315);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(123, 66);
            sendButton.TabIndex = 5;
            sendButton.Text = "Відправити";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // chatTextBox
            // 
            chatTextBox.Location = new Point(12, 70);
            chatTextBox.Name = "chatTextBox";
            chatTextBox.Size = new Size(512, 239);
            chatTextBox.TabIndex = 6;
            chatTextBox.Text = "";
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(12, 315);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(383, 66);
            messageTextBox.TabIndex = 7;
            messageTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 8;
            label1.Text = "Введіть ім'я:";
            // 
            // settingsBtn
            // 
            settingsBtn.Location = new Point(12, 15);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(101, 40);
            settingsBtn.TabIndex = 9;
            settingsBtn.Text = "Налаштування";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 392);
            Controls.Add(settingsBtn);
            Controls.Add(label1);
            Controls.Add(messageTextBox);
            Controls.Add(chatTextBox);
            Controls.Add(sendButton);
            Controls.Add(logoutButton);
            Controls.Add(loginButton);
            Controls.Add(userNameTextBox);
            Name = "Form1";
            Text = "Lab16 - Клімач О.П. - 101-пТК";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private Button loginButton;
        private Button logoutButton;
        private Button sendButton;
        private RichTextBox chatTextBox;
        private RichTextBox messageTextBox;
        private Label label1;
        private Button settingsBtn;
    }
}
