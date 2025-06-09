namespace Lab11
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
            dataGridView1 = new DataGridView();
            btnOpenAddFlightForm = new Button();
            btnOpenAddTicketForm = new Button();
            button3 = new Button();
            button4 = new Button();
            dateTimePickerSearchDate = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(725, 263);
            dataGridView1.TabIndex = 0;
            // 
            // btnOpenAddFlightForm
            // 
            btnOpenAddFlightForm.Location = new Point(98, 12);
            btnOpenAddFlightForm.Name = "btnOpenAddFlightForm";
            btnOpenAddFlightForm.Size = new Size(222, 32);
            btnOpenAddFlightForm.TabIndex = 6;
            btnOpenAddFlightForm.Text = "Додати політ";
            btnOpenAddFlightForm.UseVisualStyleBackColor = true;
            btnOpenAddFlightForm.Click += btnOpenAddFlightForm_Click;
            // 
            // btnOpenAddTicketForm
            // 
            btnOpenAddTicketForm.Location = new Point(98, 50);
            btnOpenAddTicketForm.Name = "btnOpenAddTicketForm";
            btnOpenAddTicketForm.Size = new Size(222, 32);
            btnOpenAddTicketForm.TabIndex = 7;
            btnOpenAddTicketForm.Text = "Додати білет";
            btnOpenAddTicketForm.UseVisualStyleBackColor = true;
            btnOpenAddTicketForm.Click += btnOpenAddTicketForm_Click;
            // 
            // button3
            // 
            button3.Location = new Point(338, 50);
            button3.Name = "button3";
            button3.Size = new Size(198, 32);
            button3.TabIndex = 8;
            button3.Text = "Виручка за польотами";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnShowRevenueReport_Click;
            // 
            // button4
            // 
            button4.Location = new Point(338, 12);
            button4.Name = "button4";
            button4.Size = new Size(198, 32);
            button4.TabIndex = 9;
            button4.Text = "Кількість білетів за польотами";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnShowTicketReport_Click;
            // 
            // dateTimePickerSearchDate
            // 
            dateTimePickerSearchDate.Location = new Point(560, 47);
            dateTimePickerSearchDate.Name = "dateTimePickerSearchDate";
            dateTimePickerSearchDate.Size = new Size(144, 23);
            dateTimePickerSearchDate.TabIndex = 11;
            dateTimePickerSearchDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 29);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 12;
            label1.Text = "Пошук за датою вильоту";
            // 
            // button1
            // 
            button1.Location = new Point(35, 374);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 13;
            button1.Text = "Додати тестові дані";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLoadTestData_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(12, 12);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(67, 70);
            btnShowAll.TabIndex = 14;
            btnShowAll.Text = "Всі";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 400);
            Controls.Add(btnShowAll);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dateTimePickerSearchDate);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnOpenAddTicketForm);
            Controls.Add(btnOpenAddFlightForm);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Lab11 - Клімач О.П. - 101-пТК";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnOpenAddFlightForm;
        private Button btnOpenAddTicketForm;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePickerSearchDate;
        private Label label1;
        private Button button1;
        private Button btnShowAll;
    }
}
