namespace Lab12
{
    partial class HouseTmplForm
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
            houseTypeComboBox = new ComboBox();
            residentialComplexTextBox = new TextBox();
            cityTextBox = new TextBox();
            expiredAtDateTimePicker = new DateTimePicker();
            btnCreateCert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Тип житла";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Назва ЖК";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Місто";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 99);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "Дійсний до";
            // 
            // houseTypeComboBox
            // 
            houseTypeComboBox.FormattingEnabled = true;
            houseTypeComboBox.Location = new Point(83, 6);
            houseTypeComboBox.Name = "houseTypeComboBox";
            houseTypeComboBox.Size = new Size(177, 23);
            houseTypeComboBox.TabIndex = 4;
            // 
            // residentialComplexTextBox
            // 
            residentialComplexTextBox.Location = new Point(83, 35);
            residentialComplexTextBox.Name = "residentialComplexTextBox";
            residentialComplexTextBox.Size = new Size(177, 23);
            residentialComplexTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(83, 66);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(177, 23);
            cityTextBox.TabIndex = 6;
            // 
            // expiredAtDateTimePicker
            // 
            expiredAtDateTimePicker.Location = new Point(83, 95);
            expiredAtDateTimePicker.Name = "expiredAtDateTimePicker";
            expiredAtDateTimePicker.Size = new Size(177, 23);
            expiredAtDateTimePicker.TabIndex = 7;
            // 
            // btnCreateCert
            // 
            btnCreateCert.Location = new Point(68, 136);
            btnCreateCert.Name = "btnCreateCert";
            btnCreateCert.Size = new Size(142, 23);
            btnCreateCert.TabIndex = 8;
            btnCreateCert.Text = "Створити сертифікат";
            btnCreateCert.UseVisualStyleBackColor = true;
            btnCreateCert.Click += btnCreateCert_Click;
            // 
            // HouseTmplForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 171);
            Controls.Add(btnCreateCert);
            Controls.Add(expiredAtDateTimePicker);
            Controls.Add(cityTextBox);
            Controls.Add(residentialComplexTextBox);
            Controls.Add(houseTypeComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HouseTmplForm";
            Text = "Сертифікат на будинок";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox houseTypeComboBox;
        private TextBox residentialComplexTextBox;
        private TextBox cityTextBox;
        private DateTimePicker expiredAtDateTimePicker;
        private Button btnCreateCert;
    }
}