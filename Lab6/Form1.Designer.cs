namespace Lab6Project
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sideA_textBox = new TextBox();
            sideB_textBox = new TextBox();
            sideC_textBox = new TextBox();
            output = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Side A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Side B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Side C";
            // 
            // sideA_textBox
            // 
            sideA_textBox.Location = new Point(56, 19);
            sideA_textBox.Name = "sideA_textBox";
            sideA_textBox.Size = new Size(100, 23);
            sideA_textBox.TabIndex = 3;
            sideA_textBox.KeyPress += textBox_KeyPress;
            // 
            // sideB_textBox
            // 
            sideB_textBox.Location = new Point(56, 51);
            sideB_textBox.Name = "sideB_textBox";
            sideB_textBox.Size = new Size(100, 23);
            sideB_textBox.TabIndex = 4;
            sideB_textBox.KeyPress += textBox_KeyPress;
            // 
            // sideC_textBox
            // 
            sideC_textBox.Location = new Point(56, 84);
            sideC_textBox.Name = "sideC_textBox";
            sideC_textBox.Size = new Size(100, 23);
            sideC_textBox.TabIndex = 5;
            sideC_textBox.KeyPress += textBox_KeyPress;
            // 
            // output
            // 
            output.Location = new Point(12, 113);
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(352, 132);
            output.TabIndex = 7;
            output.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(180, 42);
            button1.Name = "button1";
            button1.Size = new Size(174, 39);
            button1.TabIndex = 8;
            button1.Text = "Calculate Triangle Area";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 257);
            Controls.Add(button1);
            Controls.Add(output);
            Controls.Add(sideC_textBox);
            Controls.Add(sideB_textBox);
            Controls.Add(sideA_textBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(392, 296);
            MinimumSize = new Size(392, 296);
            Name = "Form1";
            Text = "Lab. 6 Var. 1 (Клімач О.П. 101-пТК)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox sideA_textBox;
        private TextBox sideB_textBox;
        private TextBox sideC_textBox;
        private RichTextBox output;
        private Button button1;
    }
}
