namespace RGR
{
    partial class PersonDetailsForm
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
            tbSecondName = new TextBox();
            tbFirstName = new TextBox();
            tbMiddleName = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            rtbAddress = new RichTextBox();
            tbPhoneNumber = new TextBox();
            gbFullName = new GroupBox();
            lGender = new Label();
            lMiddleName = new Label();
            lFirstName = new Label();
            lSecondName = new Label();
            cbGender = new ComboBox();
            gbContact = new GroupBox();
            lEmail = new Label();
            lPhone = new Label();
            lAddress = new Label();
            dtpBirthDate = new DateTimePicker();
            lBirthDate = new Label();
            tbEmail = new TextBox();
            gbPassport = new GroupBox();
            lPassportIssuedBy = new Label();
            lPassportIssueDate = new Label();
            dtpPassportIssueDate = new DateTimePicker();
            lPassportNumber = new Label();
            rtbPassportIssuedBy = new RichTextBox();
            tbPassportNumber = new TextBox();
            gbJobInfo = new GroupBox();
            lOrganization = new Label();
            lJobTitle = new Label();
            tbOrganization = new TextBox();
            tbJobTitle = new TextBox();
            btnEdit = new Button();
            btnClose = new Button();
            btnSave = new Button();
            gbFullName.SuspendLayout();
            gbContact.SuspendLayout();
            gbPassport.SuspendLayout();
            gbJobInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tbSecondName
            // 
            tbSecondName.Location = new Point(98, 22);
            tbSecondName.Name = "tbSecondName";
            tbSecondName.Size = new Size(206, 23);
            tbSecondName.TabIndex = 0;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(98, 51);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(206, 23);
            tbFirstName.TabIndex = 1;
            // 
            // tbMiddleName
            // 
            tbMiddleName.Location = new Point(98, 80);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.Size = new Size(206, 23);
            tbMiddleName.TabIndex = 2;
            // 
            // rtbAddress
            // 
            rtbAddress.Location = new Point(78, 52);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(226, 62);
            rtbAddress.TabIndex = 5;
            rtbAddress.Text = "";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(135, 120);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(169, 23);
            tbPhoneNumber.TabIndex = 6;
            tbPhoneNumber.TextChanged += tbPhoneNumber_TextChanged;
            tbPhoneNumber.KeyDown += tbPhoneNumber_KeyDown;
            tbPhoneNumber.KeyPress += tbPhoneNumber_KeyPress;
            // 
            // gbFullName
            // 
            gbFullName.Controls.Add(lGender);
            gbFullName.Controls.Add(lMiddleName);
            gbFullName.Controls.Add(lFirstName);
            gbFullName.Controls.Add(lSecondName);
            gbFullName.Controls.Add(cbGender);
            gbFullName.Controls.Add(tbSecondName);
            gbFullName.Controls.Add(tbFirstName);
            gbFullName.Controls.Add(tbMiddleName);
            gbFullName.Location = new Point(12, 12);
            gbFullName.Name = "gbFullName";
            gbFullName.Size = new Size(324, 145);
            gbFullName.TabIndex = 7;
            gbFullName.TabStop = false;
            gbFullName.Text = "ПІБ/Стать";
            // 
            // lGender
            // 
            lGender.AutoSize = true;
            lGender.Location = new Point(15, 112);
            lGender.Name = "lGender";
            lGender.Size = new Size(48, 15);
            lGender.TabIndex = 7;
            lGender.Text = "Стать: *";
            // 
            // lMiddleName
            // 
            lMiddleName.AutoSize = true;
            lMiddleName.Location = new Point(15, 83);
            lMiddleName.Name = "lMiddleName";
            lMiddleName.Size = new Size(75, 15);
            lMiddleName.TabIndex = 6;
            lMiddleName.Text = "По батькові:";
            // 
            // lFirstName
            // 
            lFirstName.AutoSize = true;
            lFirstName.Location = new Point(15, 54);
            lFirstName.Name = "lFirstName";
            lFirstName.Size = new Size(39, 15);
            lFirstName.TabIndex = 5;
            lFirstName.Text = "Ім'я: *";
            // 
            // lSecondName
            // 
            lSecondName.AutoSize = true;
            lSecondName.Location = new Point(15, 25);
            lSecondName.Name = "lSecondName";
            lSecondName.Size = new Size(72, 15);
            lSecondName.TabIndex = 4;
            lSecondName.Text = "Прізвище: *";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Він", "Вона" });
            cbGender.Location = new Point(98, 109);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 3;
            // 
            // gbContact
            // 
            gbContact.Controls.Add(lEmail);
            gbContact.Controls.Add(lPhone);
            gbContact.Controls.Add(lAddress);
            gbContact.Controls.Add(dtpBirthDate);
            gbContact.Controls.Add(lBirthDate);
            gbContact.Controls.Add(tbEmail);
            gbContact.Controls.Add(rtbAddress);
            gbContact.Controls.Add(tbPhoneNumber);
            gbContact.Location = new Point(12, 163);
            gbContact.Name = "gbContact";
            gbContact.Size = new Size(324, 187);
            gbContact.TabIndex = 8;
            gbContact.TabStop = false;
            gbContact.Text = "Контактна інформація";
            // 
            // lEmail
            // 
            lEmail.AutoSize = true;
            lEmail.Location = new Point(15, 152);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(47, 15);
            lEmail.TabIndex = 13;
            lEmail.Text = "Email: *";
            // 
            // lPhone
            // 
            lPhone.AutoSize = true;
            lPhone.Location = new Point(15, 123);
            lPhone.Name = "lPhone";
            lPhone.Size = new Size(112, 15);
            lPhone.TabIndex = 12;
            lPhone.Text = "Номер телефону: *";
            // 
            // lAddress
            // 
            lAddress.AutoSize = true;
            lAddress.Location = new Point(15, 55);
            lAddress.Name = "lAddress";
            lAddress.Size = new Size(57, 15);
            lAddress.TabIndex = 11;
            lAddress.Text = "Адреса: *";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "yyyy-MM-dd";
            dtpBirthDate.Location = new Point(135, 22);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(134, 23);
            dtpBirthDate.TabIndex = 10;
            dtpBirthDate.ValueChanged += dtpBirthDate_ValueChanged;
            // 
            // lBirthDate
            // 
            lBirthDate.AutoSize = true;
            lBirthDate.Location = new Point(15, 28);
            lBirthDate.Name = "lBirthDate";
            lBirthDate.Size = new Size(114, 15);
            lBirthDate.TabIndex = 8;
            lBirthDate.Text = "Дата народження: *";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(68, 149);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(236, 23);
            tbEmail.TabIndex = 9;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // gbPassport
            // 
            gbPassport.Controls.Add(lPassportIssuedBy);
            gbPassport.Controls.Add(lPassportIssueDate);
            gbPassport.Controls.Add(dtpPassportIssueDate);
            gbPassport.Controls.Add(lPassportNumber);
            gbPassport.Controls.Add(rtbPassportIssuedBy);
            gbPassport.Controls.Add(tbPassportNumber);
            gbPassport.Enabled = false;
            gbPassport.Location = new Point(355, 12);
            gbPassport.Name = "gbPassport";
            gbPassport.Size = new Size(324, 145);
            gbPassport.TabIndex = 9;
            gbPassport.TabStop = false;
            gbPassport.Text = "Паспортні дані";
            // 
            // lPassportIssuedBy
            // 
            lPassportIssuedBy.AutoSize = true;
            lPassportIssuedBy.Location = new Point(6, 88);
            lPassportIssuedBy.Name = "lPassportIssuedBy";
            lPassportIssuedBy.Size = new Size(82, 15);
            lPassportIssuedBy.TabIndex = 13;
            lPassportIssuedBy.Text = "Ким виданий:";
            // 
            // lPassportIssueDate
            // 
            lPassportIssueDate.AutoSize = true;
            lPassportIssueDate.Location = new Point(6, 59);
            lPassportIssueDate.Name = "lPassportIssueDate";
            lPassportIssueDate.Size = new Size(73, 15);
            lPassportIssueDate.TabIndex = 12;
            lPassportIssueDate.Text = "Дата видачі:";
            // 
            // dtpPassportIssueDate
            // 
            dtpPassportIssueDate.CustomFormat = "yyyy-MM-dd";
            dtpPassportIssueDate.Location = new Point(94, 54);
            dtpPassportIssueDate.Name = "dtpPassportIssueDate";
            dtpPassportIssueDate.Size = new Size(130, 23);
            dtpPassportIssueDate.TabIndex = 11;
            // 
            // lPassportNumber
            // 
            lPassportNumber.AutoSize = true;
            lPassportNumber.Location = new Point(6, 25);
            lPassportNumber.Name = "lPassportNumber";
            lPassportNumber.Size = new Size(48, 15);
            lPassportNumber.TabIndex = 8;
            lPassportNumber.Text = "Номер:";
            // 
            // rtbPassportIssuedBy
            // 
            rtbPassportIssuedBy.Location = new Point(94, 83);
            rtbPassportIssuedBy.Name = "rtbPassportIssuedBy";
            rtbPassportIssuedBy.Size = new Size(210, 47);
            rtbPassportIssuedBy.TabIndex = 10;
            rtbPassportIssuedBy.Text = "";
            // 
            // tbPassportNumber
            // 
            tbPassportNumber.Location = new Point(94, 22);
            tbPassportNumber.Name = "tbPassportNumber";
            tbPassportNumber.Size = new Size(130, 23);
            tbPassportNumber.TabIndex = 10;
            // 
            // gbJobInfo
            // 
            gbJobInfo.Controls.Add(lOrganization);
            gbJobInfo.Controls.Add(lJobTitle);
            gbJobInfo.Controls.Add(tbOrganization);
            gbJobInfo.Controls.Add(tbJobTitle);
            gbJobInfo.Enabled = false;
            gbJobInfo.Location = new Point(355, 163);
            gbJobInfo.Name = "gbJobInfo";
            gbJobInfo.Size = new Size(324, 90);
            gbJobInfo.TabIndex = 12;
            gbJobInfo.TabStop = false;
            gbJobInfo.Text = "Дані про роботу";
            // 
            // lOrganization
            // 
            lOrganization.AutoSize = true;
            lOrganization.Location = new Point(6, 54);
            lOrganization.Name = "lOrganization";
            lOrganization.Size = new Size(86, 15);
            lOrganization.TabIndex = 15;
            lOrganization.Text = "Місце роботи:";
            // 
            // lJobTitle
            // 
            lJobTitle.AutoSize = true;
            lJobTitle.Location = new Point(6, 30);
            lJobTitle.Name = "lJobTitle";
            lJobTitle.Size = new Size(50, 15);
            lJobTitle.TabIndex = 14;
            lJobTitle.Text = "Посада:";
            // 
            // tbOrganization
            // 
            tbOrganization.Location = new Point(94, 52);
            tbOrganization.Name = "tbOrganization";
            tbOrganization.Size = new Size(210, 23);
            tbOrganization.TabIndex = 11;
            // 
            // tbJobTitle
            // 
            tbJobTitle.Location = new Point(94, 23);
            tbJobTitle.Name = "tbJobTitle";
            tbJobTitle.Size = new Size(210, 23);
            tbJobTitle.TabIndex = 10;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(355, 312);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 38);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(569, 312);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(101, 38);
            btnClose.TabIndex = 14;
            btnClose.Text = "Вихід";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(462, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 38);
            btnSave.TabIndex = 15;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // PersonDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 362);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(btnEdit);
            Controls.Add(gbJobInfo);
            Controls.Add(gbPassport);
            Controls.Add(gbContact);
            Controls.Add(gbFullName);
            Name = "PersonDetailsForm";
            Text = "Деталі запису";
            gbFullName.ResumeLayout(false);
            gbFullName.PerformLayout();
            gbContact.ResumeLayout(false);
            gbContact.PerformLayout();
            gbPassport.ResumeLayout(false);
            gbPassport.PerformLayout();
            gbJobInfo.ResumeLayout(false);
            gbJobInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbSecondName;
        private TextBox tbFirstName;
        private TextBox tbMiddleName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox4;
        private TextBox textBox5;
        private RichTextBox rtbAddress;
        private TextBox tbPhoneNumber;
        private GroupBox gbFullName;
        private GroupBox gbContact;
        private TextBox tbEmail;
        private GroupBox gbPassport;
        private RichTextBox rtbPassportIssuedBy;
        private TextBox tbPassportNumber;
        private Label lGender;
        private Label lMiddleName;
        private Label lFirstName;
        private Label lSecondName;
        private ComboBox cbGender;
        private GroupBox gbJobInfo;
        private TextBox tbOrganization;
        private TextBox tbJobTitle;
        private DateTimePicker dtpBirthDate;
        private Label lBirthDate;
        private TextBox textBox10;
        private Label lEmail;
        private Label lPhone;
        private Label lAddress;
        private Label lPassportNumber;
        private DateTimePicker dtpPassportIssueDate;
        private Label lPassportIssuedBy;
        private Label lPassportIssueDate;
        private Label lOrganization;
        private Label lJobTitle;
        private Button btnEdit;
        private Button btnClose;
        private Button btnSave;
    }
}