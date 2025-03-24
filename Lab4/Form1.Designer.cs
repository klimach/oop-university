namespace Lab4Project
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
            tabPage2 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            twoDimBotRight = new TextBox();
            twoDimTopLeft = new TextBox();
            twoDimNelements = new TextBox();
            twoDimArray_textBox = new RichTextBox();
            twoDimGenerate = new Button();
            label5 = new Label();
            tabPage1 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            oneDimSortOutput = new RichTextBox();
            oneDimUntilMinSum = new TextBox();
            oneDimPositiveSum = new TextBox();
            oneDimNelements = new TextBox();
            oneDimArray_textBox = new RichTextBox();
            oneDimGenerate = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(twoDimBotRight);
            tabPage2.Controls.Add(twoDimTopLeft);
            tabPage2.Controls.Add(twoDimNelements);
            tabPage2.Controls.Add(twoDimArray_textBox);
            tabPage2.Controls.Add(twoDimGenerate);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(486, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Two-Dimensional Array";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(294, 321);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 11;
            label7.Text = "Bottom-Right Element";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 321);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 10;
            label6.Text = "Top-Left Element";
            // 
            // twoDimBotRight
            // 
            twoDimBotRight.Location = new Point(310, 339);
            twoDimBotRight.MaxLength = 2;
            twoDimBotRight.Name = "twoDimBotRight";
            twoDimBotRight.ReadOnly = true;
            twoDimBotRight.Size = new Size(91, 23);
            twoDimBotRight.TabIndex = 9;
            // 
            // twoDimTopLeft
            // 
            twoDimTopLeft.Location = new Point(47, 339);
            twoDimTopLeft.MaxLength = 2;
            twoDimTopLeft.Name = "twoDimTopLeft";
            twoDimTopLeft.ReadOnly = true;
            twoDimTopLeft.Size = new Size(91, 23);
            twoDimTopLeft.TabIndex = 8;
            // 
            // twoDimNelements
            // 
            twoDimNelements.Location = new Point(91, 12);
            twoDimNelements.MaxLength = 2;
            twoDimNelements.Name = "twoDimNelements";
            twoDimNelements.Size = new Size(47, 23);
            twoDimNelements.TabIndex = 5;
            twoDimNelements.KeyPress += Integer_KeyPress;
            // 
            // twoDimArray_textBox
            // 
            twoDimArray_textBox.Location = new Point(6, 41);
            twoDimArray_textBox.Name = "twoDimArray_textBox";
            twoDimArray_textBox.ReadOnly = true;
            twoDimArray_textBox.Size = new Size(474, 256);
            twoDimArray_textBox.TabIndex = 4;
            twoDimArray_textBox.Text = "";
            // 
            // twoDimGenerate
            // 
            twoDimGenerate.Location = new Point(363, 11);
            twoDimGenerate.Name = "twoDimGenerate";
            twoDimGenerate.Size = new Size(117, 23);
            twoDimGenerate.TabIndex = 7;
            twoDimGenerate.Text = "Generate";
            twoDimGenerate.UseVisualStyleBackColor = true;
            twoDimGenerate.Click += twoDimGenerate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 16);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 6;
            label5.Text = "N-elements";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(oneDimSortOutput);
            tabPage1.Controls.Add(oneDimUntilMinSum);
            tabPage1.Controls.Add(oneDimPositiveSum);
            tabPage1.Controls.Add(oneDimNelements);
            tabPage1.Controls.Add(oneDimArray_textBox);
            tabPage1.Controls.Add(oneDimGenerate);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(486, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "One-Dimensional Array";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 234);
            label4.Name = "label4";
            label4.Size = new Size(223, 15);
            label4.TabIndex = 9;
            label4.Text = "Sorted separately even and odd elements";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 201);
            label3.Name = "label3";
            label3.Size = new Size(249, 15);
            label3.TabIndex = 8;
            label3.Text = "Sum of elements before first minimal element";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 165);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 7;
            label2.Text = "Sum of positive elements";
            // 
            // oneDimSortOutput
            // 
            oneDimSortOutput.Location = new Point(6, 252);
            oneDimSortOutput.Name = "oneDimSortOutput";
            oneDimSortOutput.ReadOnly = true;
            oneDimSortOutput.Size = new Size(474, 140);
            oneDimSortOutput.TabIndex = 6;
            oneDimSortOutput.Text = "";
            // 
            // oneDimUntilMinSum
            // 
            oneDimUntilMinSum.Location = new Point(271, 198);
            oneDimUntilMinSum.MaxLength = 2;
            oneDimUntilMinSum.Name = "oneDimUntilMinSum";
            oneDimUntilMinSum.ReadOnly = true;
            oneDimUntilMinSum.Size = new Size(209, 23);
            oneDimUntilMinSum.TabIndex = 5;
            // 
            // oneDimPositiveSum
            // 
            oneDimPositiveSum.Location = new Point(162, 162);
            oneDimPositiveSum.MaxLength = 2;
            oneDimPositiveSum.Name = "oneDimPositiveSum";
            oneDimPositiveSum.ReadOnly = true;
            oneDimPositiveSum.Size = new Size(318, 23);
            oneDimPositiveSum.TabIndex = 4;
            // 
            // oneDimNelements
            // 
            oneDimNelements.Location = new Point(91, 14);
            oneDimNelements.MaxLength = 2;
            oneDimNelements.Name = "oneDimNelements";
            oneDimNelements.Size = new Size(47, 23);
            oneDimNelements.TabIndex = 1;
            oneDimNelements.KeyPress += Integer_KeyPress;
            // 
            // oneDimArray_textBox
            // 
            oneDimArray_textBox.Location = new Point(6, 43);
            oneDimArray_textBox.Name = "oneDimArray_textBox";
            oneDimArray_textBox.ReadOnly = true;
            oneDimArray_textBox.Size = new Size(474, 113);
            oneDimArray_textBox.TabIndex = 0;
            oneDimArray_textBox.Text = "";
            // 
            // oneDimGenerate
            // 
            oneDimGenerate.Location = new Point(363, 13);
            oneDimGenerate.Name = "oneDimGenerate";
            oneDimGenerate.Size = new Size(117, 23);
            oneDimGenerate.TabIndex = 3;
            oneDimGenerate.Text = "Generate";
            oneDimGenerate.UseVisualStyleBackColor = true;
            oneDimGenerate.Click += oneDimGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "N-elements";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(494, 426);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Lab. 4 Var. 2 (Клімач О.П. 101-пТК)";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox oneDimSortOutput;
        private TextBox oneDimUntilMinSum;
        private TextBox oneDimPositiveSum;
        private TextBox oneDimNelements;
        private RichTextBox oneDimArray_textBox;
        private Button oneDimGenerate;
        private Label label1;
        private TabControl tabControl1;
        private TextBox twoDimNelements;
        private RichTextBox twoDimArray_textBox;
        private Button twoDimGenerate;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox twoDimBotRight;
        private TextBox twoDimTopLeft;
    }
}
