namespace Lab12
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnChooseCertType = new Button();
            certTypeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // btnChooseCertType
            // 
            btnChooseCertType.Location = new Point(120, 44);
            btnChooseCertType.Name = "btnChooseCertType";
            btnChooseCertType.Size = new Size(139, 36);
            btnChooseCertType.TabIndex = 1;
            btnChooseCertType.Text = "Обрати сертифікат";
            btnChooseCertType.UseVisualStyleBackColor = true;
            btnChooseCertType.Click += btnChooseCertType_Click;
            // 
            // certTypeComboBox
            // 
            certTypeComboBox.FormattingEnabled = true;
            certTypeComboBox.Location = new Point(12, 12);
            certTypeComboBox.Name = "certTypeComboBox";
            certTypeComboBox.Size = new Size(353, 23);
            certTypeComboBox.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 90);
            Controls.Add(certTypeComboBox);
            Controls.Add(btnChooseCertType);
            Name = "MainForm";
            Text = "Lab12 - Клімач О.П. - 101-пТК";
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnChooseCertType;
        private ComboBox certTypeComboBox;
    }
}
