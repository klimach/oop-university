namespace Lab5Project
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
            input = new RichTextBox();
            output = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(12, 42);
            input.Name = "input";
            input.Size = new Size(453, 176);
            input.TabIndex = 0;
            input.Text = "";
            input.TextChanged += input_TextChanged;
            // 
            // output
            // 
            output.Location = new Point(12, 258);
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(453, 180);
            output.TabIndex = 1;
            output.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 240);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(output);
            Controls.Add(input);
            Name = "Form1";
            Text = "Lab. 5 Var 1 (Клімач О.П. 101-пТК)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox input;
        private RichTextBox output;
        private Label label1;
        private Label label2;
    }
}
