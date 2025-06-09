namespace Lab10
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
            panel1 = new Panel();
            panel2 = new Panel();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 191);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(236, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 191);
            panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(461, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(197, 191);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 220);
            button1.Name = "button1";
            button1.Size = new Size(197, 23);
            button1.TabIndex = 3;
            button1.Text = "Запустити 1 потік";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(12, 249);
            button2.Name = "button2";
            button2.Size = new Size(197, 23);
            button2.TabIndex = 4;
            button2.Text = "Зупинити 1 потік";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button5_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Brown;
            button3.Location = new Point(236, 249);
            button3.Name = "button3";
            button3.Size = new Size(197, 23);
            button3.TabIndex = 6;
            button3.Text = "Зупинити 2 потік";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(236, 220);
            button4.Name = "button4";
            button4.Size = new Size(197, 23);
            button4.TabIndex = 5;
            button4.Text = "Запустити 2 потік";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button2_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.Brown;
            button5.Location = new Point(461, 249);
            button5.Name = "button5";
            button5.Size = new Size(197, 23);
            button5.TabIndex = 8;
            button5.Text = "Зупинити 3 потік";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(461, 220);
            button6.Name = "button6";
            button6.Size = new Size(197, 23);
            button6.TabIndex = 7;
            button6.Text = "Запустити 3 потік";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button3_Click;
            // 
            // button7
            // 
            button7.ForeColor = Color.Brown;
            button7.Location = new Point(12, 320);
            button7.Name = "button7";
            button7.Size = new Size(646, 23);
            button7.TabIndex = 10;
            button7.Text = "Зупинити всі потоки";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button8_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 291);
            button8.Name = "button8";
            button8.Size = new Size(646, 23);
            button8.TabIndex = 9;
            button8.Text = "Запустити всі потоки";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 355);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Lab10 - Клімач О.П. - 101-пТК (приклад)";
            FormClosed += Form1_Formclosed;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
