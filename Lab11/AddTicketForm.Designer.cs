namespace Lab11
{
    partial class AddTicketForm
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
            txtPassengerName = new TextBox();
            txtPrice = new TextBox();
            dateTimePickerPurchase = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboFlights = new ComboBox();
            SuspendLayout();
            // 
            // txtPassengerName
            // 
            txtPassengerName.Location = new Point(106, 41);
            txtPassengerName.Name = "txtPassengerName";
            txtPassengerName.Size = new Size(200, 23);
            txtPassengerName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(106, 70);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 2;
            // 
            // dateTimePickerPurchase
            // 
            dateTimePickerPurchase.Location = new Point(146, 99);
            dateTimePickerPurchase.Name = "dateTimePickerPurchase";
            dateTimePickerPurchase.Size = new Size(160, 23);
            dateTimePickerPurchase.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(7, 149);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 5;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddTicket_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 149);
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
            label2.Size = new Size(85, 15);
            label2.TabIndex = 8;
            label2.Text = "Ім'я пасажира";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 73);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 9;
            label3.Text = "Ціна квитка";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 105);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 10;
            label4.Text = "Дата купівлі";
            // 
            // comboFlights
            // 
            comboFlights.FormattingEnabled = true;
            comboFlights.Location = new Point(106, 12);
            comboFlights.Name = "comboFlights";
            comboFlights.Size = new Size(200, 23);
            comboFlights.TabIndex = 12;
            // 
            // AddTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 183);
            Controls.Add(comboFlights);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePickerPurchase);
            Controls.Add(txtPrice);
            Controls.Add(txtPassengerName);
            Name = "AddTicketForm";
            Text = "Додати білет";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassengerName;
        private TextBox txtPrice;
        private DateTimePicker dateTimePickerPurchase;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboFlights;
    }
}