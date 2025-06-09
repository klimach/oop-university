namespace Lab12
{
    partial class EduTmplForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            companyTextBox = new TextBox();
            amountTextBox = new TextBox();
            infoRichBox = new RichTextBox();
            numberTextBox = new TextBox();
            siteTextBox = new TextBox();
            expiredAtDateTimePicker = new DateTimePicker();
            btnCreateCert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 21);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Компанія";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 53);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Сума";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 106);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Інформація";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 155);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 185);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Сайт";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 217);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 5;
            label6.Text = "Дійсний до";
            // 
            // companyTextBox
            // 
            companyTextBox.Location = new Point(94, 18);
            companyTextBox.Name = "companyTextBox";
            companyTextBox.Size = new Size(177, 23);
            companyTextBox.TabIndex = 6;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(94, 50);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(177, 23);
            amountTextBox.TabIndex = 7;
            amountTextBox.KeyPress += amountTextBox_KeyPress;
            // 
            // infoRichBox
            // 
            infoRichBox.Location = new Point(94, 86);
            infoRichBox.Name = "infoRichBox";
            infoRichBox.Size = new Size(177, 60);
            infoRichBox.TabIndex = 8;
            infoRichBox.Text = "";
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(94, 152);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(177, 23);
            numberTextBox.TabIndex = 9;
            // 
            // siteTextBox
            // 
            siteTextBox.Location = new Point(94, 182);
            siteTextBox.Name = "siteTextBox";
            siteTextBox.Size = new Size(177, 23);
            siteTextBox.TabIndex = 10;
            // 
            // expiredAtDateTimePicker
            // 
            expiredAtDateTimePicker.Location = new Point(94, 211);
            expiredAtDateTimePicker.Name = "expiredAtDateTimePicker";
            expiredAtDateTimePicker.Size = new Size(177, 23);
            expiredAtDateTimePicker.TabIndex = 11;
            // 
            // btnCreateCert
            // 
            btnCreateCert.Location = new Point(73, 250);
            btnCreateCert.Name = "btnCreateCert";
            btnCreateCert.Size = new Size(142, 23);
            btnCreateCert.TabIndex = 12;
            btnCreateCert.Text = "Створити сертифікат";
            btnCreateCert.UseVisualStyleBackColor = true;
            btnCreateCert.Click += btnCreateCert_Click;
            // 
            // EduTmplForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 285);
            Controls.Add(btnCreateCert);
            Controls.Add(expiredAtDateTimePicker);
            Controls.Add(siteTextBox);
            Controls.Add(numberTextBox);
            Controls.Add(infoRichBox);
            Controls.Add(amountTextBox);
            Controls.Add(companyTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EduTmplForm";
            Text = "Сертифікат на навчання";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox companyTextBox;
        private TextBox amountTextBox;
        private RichTextBox infoRichBox;
        private TextBox numberTextBox;
        private TextBox siteTextBox;
        private DateTimePicker expiredAtDateTimePicker;
        private Button btnCreateCert;
    }
}