namespace Lab11
{
    partial class AddFlightForm
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
            txtFlightNumber = new TextBox();
            txtDepartureCity = new TextBox();
            txtArrivalCity = new TextBox();
            dateTimePickerDep = new DateTimePicker();
            dateTimePickerArr = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtFlightNumber
            // 
            txtFlightNumber.Location = new Point(106, 12);
            txtFlightNumber.Name = "txtFlightNumber";
            txtFlightNumber.Size = new Size(200, 23);
            txtFlightNumber.TabIndex = 0;
            // 
            // txtDepartureCity
            // 
            txtDepartureCity.Location = new Point(106, 41);
            txtDepartureCity.Name = "txtDepartureCity";
            txtDepartureCity.Size = new Size(200, 23);
            txtDepartureCity.TabIndex = 1;
            // 
            // txtArrivalCity
            // 
            txtArrivalCity.Location = new Point(106, 70);
            txtArrivalCity.Name = "txtArrivalCity";
            txtArrivalCity.Size = new Size(200, 23);
            txtArrivalCity.TabIndex = 2;
            // 
            // dateTimePickerDep
            // 
            dateTimePickerDep.Location = new Point(146, 99);
            dateTimePickerDep.Name = "dateTimePickerDep";
            dateTimePickerDep.Size = new Size(160, 23);
            dateTimePickerDep.TabIndex = 3;
            // 
            // dateTimePickerArr
            // 
            dateTimePickerArr.Location = new Point(146, 128);
            dateTimePickerArr.Name = "dateTimePickerArr";
            dateTimePickerArr.Size = new Size(160, 23);
            dateTimePickerArr.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 174);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 5;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 174);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 6;
            button2.Text = "Скасувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 7;
            label1.Text = "Номер польоту";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 44);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 8;
            label2.Text = "Відправлення з";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 73);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 9;
            label3.Text = "Прибуття в";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 105);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 10;
            label4.Text = "Дата відправлення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 134);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 11;
            label5.Text = "Дата прибуття";
            // 
            // AddFlightForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 209);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePickerArr);
            Controls.Add(dateTimePickerDep);
            Controls.Add(txtArrivalCity);
            Controls.Add(txtDepartureCity);
            Controls.Add(txtFlightNumber);
            Name = "AddFlightForm";
            Text = "Додати політ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFlightNumber;
        private TextBox txtDepartureCity;
        private TextBox txtArrivalCity;
        private DateTimePicker dateTimePickerDep;
        private DateTimePicker dateTimePickerArr;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}