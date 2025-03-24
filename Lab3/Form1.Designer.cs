namespace Lab3Project
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
            number1 = new Label();
            number2 = new Label();
            number1textBox = new TextBox();
            number2textBox = new TextBox();
            number1comboBox = new ComboBox();
            number2comboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            addButton = new Button();
            subtractButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            outputBox = new RichTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // number1
            // 
            number1.AutoSize = true;
            number1.Location = new Point(12, 21);
            number1.Name = "number1";
            number1.Size = new Size(60, 15);
            number1.TabIndex = 0;
            number1.Text = "Number 1";
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.Location = new Point(12, 59);
            number2.Name = "number2";
            number2.Size = new Size(60, 15);
            number2.TabIndex = 1;
            number2.Text = "Number 2";
            // 
            // number1textBox
            // 
            number1textBox.Location = new Point(181, 18);
            number1textBox.Name = "number1textBox";
            number1textBox.Size = new Size(286, 23);
            number1textBox.TabIndex = 2;
            number1textBox.KeyPress += number1textBox_KeyPress;
            // 
            // number2textBox
            // 
            number2textBox.Location = new Point(181, 56);
            number2textBox.Name = "number2textBox";
            number2textBox.Size = new Size(286, 23);
            number2textBox.TabIndex = 3;
            number2textBox.KeyPress += number2textBox_KeyPress;
            // 
            // number1comboBox
            // 
            number1comboBox.FormattingEnabled = true;
            number1comboBox.Location = new Point(78, 18);
            number1comboBox.Name = "number1comboBox";
            number1comboBox.Size = new Size(76, 23);
            number1comboBox.TabIndex = 4;
            number1comboBox.SelectedValueChanged += number1comboBox_SelectedValueChanged;
            number1comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // number2comboBox
            // 
            number2comboBox.FormattingEnabled = true;
            number2comboBox.Location = new Point(78, 56);
            number2comboBox.Name = "number2comboBox";
            number2comboBox.Size = new Size(76, 23);
            number2comboBox.TabIndex = 5;
            number2comboBox.SelectedValueChanged += number2comboBox_SelectedValueChanged;
            number2comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 21);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 6;
            label1.Text = "=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 59);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 7;
            label2.Text = "=";
            // 
            // addButton
            // 
            addButton.Location = new Point(105, 104);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(186, 104);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(75, 23);
            subtractButton.TabIndex = 9;
            subtractButton.Text = "Subtract";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(267, 104);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(75, 23);
            multiplyButton.TabIndex = 10;
            multiplyButton.Text = "Multiply";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(348, 104);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(75, 23);
            divideButton.TabIndex = 11;
            divideButton.Text = "Divide";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // outputBox
            // 
            outputBox.Location = new Point(12, 151);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(455, 45);
            outputBox.TabIndex = 12;
            outputBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 108);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 13;
            label3.Text = "Actions";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 201);
            Controls.Add(label3);
            Controls.Add(outputBox);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(number2comboBox);
            Controls.Add(number1comboBox);
            Controls.Add(number2textBox);
            Controls.Add(number1textBox);
            Controls.Add(number2);
            Controls.Add(number1);
            Name = "Form1";
            Text = "Lab 3 Var 2. (Клімач О.П. - 101 пТК)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label number1;
        private Label number2;
        private TextBox number1textBox;
        private TextBox number2textBox;
        private ComboBox number1comboBox;
        private ComboBox number2comboBox;
        private Label label1;
        private Label label2;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button divideButton;
        private RichTextBox outputBox;
        private Label label3;
    }
}
