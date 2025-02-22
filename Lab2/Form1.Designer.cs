namespace Lab2Project
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
            components = new System.ComponentModel.Container();
            orgList_listBox = new ListBox();
            organizationBindingSource1 = new BindingSource(components);
            organizationBindingSource2 = new BindingSource(components);
            displayOrgAddress_richTextBox = new RichTextBox();
            label1 = new Label();
            countryOrgAddress_textBox = new TextBox();
            cityOrgAddress_textBox = new TextBox();
            label2 = new Label();
            stateOrgAddress_textBox = new TextBox();
            label3 = new Label();
            zipOrgAddress_textBox = new TextBox();
            label4 = new Label();
            streetOrgAddress_textBox = new TextBox();
            label5 = new Label();
            buildingOrgAddress_textBox = new TextBox();
            label6 = new Label();
            orgName_textBox = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            saveOrgAddress_button = new Button();
            addOrg_button = new Button();
            removeOrg_button = new Button();
            label8 = new Label();
            organizationBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)organizationBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)organizationBindingSource2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)organizationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // orgList_listBox
            // 
            orgList_listBox.FormattingEnabled = true;
            orgList_listBox.ItemHeight = 15;
            orgList_listBox.Location = new Point(12, 63);
            orgList_listBox.Name = "orgList_listBox";
            orgList_listBox.Size = new Size(434, 79);
            orgList_listBox.TabIndex = 0;
            orgList_listBox.SelectedIndexChanged += OrgList_listBox_SelectedIndexChanged;
            // 
            // displayOrgAddress_richTextBox
            // 
            displayOrgAddress_richTextBox.Location = new Point(212, 41);
            displayOrgAddress_richTextBox.Name = "displayOrgAddress_richTextBox";
            displayOrgAddress_richTextBox.ReadOnly = true;
            displayOrgAddress_richTextBox.Size = new Size(216, 168);
            displayOrgAddress_richTextBox.TabIndex = 1;
            displayOrgAddress_richTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Country:";
            // 
            // countryOrgAddress_textBox
            // 
            countryOrgAddress_textBox.Enabled = false;
            countryOrgAddress_textBox.Location = new Point(65, 41);
            countryOrgAddress_textBox.Name = "countryOrgAddress_textBox";
            countryOrgAddress_textBox.Size = new Size(141, 23);
            countryOrgAddress_textBox.TabIndex = 3;
            countryOrgAddress_textBox.TextChanged += CountryOrgAddress_textBox_TextChanged;
            // 
            // cityOrgAddress_textBox
            // 
            cityOrgAddress_textBox.Enabled = false;
            cityOrgAddress_textBox.Location = new Point(65, 70);
            cityOrgAddress_textBox.Name = "cityOrgAddress_textBox";
            cityOrgAddress_textBox.Size = new Size(141, 23);
            cityOrgAddress_textBox.TabIndex = 5;
            cityOrgAddress_textBox.TextChanged += CityStateOrgAddress_textBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "City:";
            // 
            // stateOrgAddress_textBox
            // 
            stateOrgAddress_textBox.Enabled = false;
            stateOrgAddress_textBox.Location = new Point(65, 99);
            stateOrgAddress_textBox.Name = "stateOrgAddress_textBox";
            stateOrgAddress_textBox.Size = new Size(141, 23);
            stateOrgAddress_textBox.TabIndex = 7;
            stateOrgAddress_textBox.TextChanged += CityStateOrgAddress_textBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 102);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "State:";
            // 
            // zipOrgAddress_textBox
            // 
            zipOrgAddress_textBox.Enabled = false;
            zipOrgAddress_textBox.Location = new Point(65, 128);
            zipOrgAddress_textBox.Name = "zipOrgAddress_textBox";
            zipOrgAddress_textBox.Size = new Size(141, 23);
            zipOrgAddress_textBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 131);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 8;
            label4.Text = "Zip:";
            // 
            // streetOrgAddress_textBox
            // 
            streetOrgAddress_textBox.Enabled = false;
            streetOrgAddress_textBox.Location = new Point(65, 157);
            streetOrgAddress_textBox.Name = "streetOrgAddress_textBox";
            streetOrgAddress_textBox.Size = new Size(141, 23);
            streetOrgAddress_textBox.TabIndex = 11;
            streetOrgAddress_textBox.TextChanged += StreetOrgAddress_textBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 160);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Street:";
            // 
            // buildingOrgAddress_textBox
            // 
            buildingOrgAddress_textBox.Enabled = false;
            buildingOrgAddress_textBox.Location = new Point(65, 186);
            buildingOrgAddress_textBox.Name = "buildingOrgAddress_textBox";
            buildingOrgAddress_textBox.Size = new Size(141, 23);
            buildingOrgAddress_textBox.TabIndex = 13;
            buildingOrgAddress_textBox.TextChanged += BuildingOrgAddress_textBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 189);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "Building:";
            // 
            // orgName_textBox
            // 
            orgName_textBox.Location = new Point(129, 6);
            orgName_textBox.Name = "orgName_textBox";
            orgName_textBox.Size = new Size(236, 23);
            orgName_textBox.TabIndex = 15;
            orgName_textBox.TextChanged += OrgName_textBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 14;
            label7.Text = "Organization name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveOrgAddress_button);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(displayOrgAddress_richTextBox);
            groupBox1.Controls.Add(countryOrgAddress_textBox);
            groupBox1.Controls.Add(buildingOrgAddress_textBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cityOrgAddress_textBox);
            groupBox1.Controls.Add(streetOrgAddress_textBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(stateOrgAddress_textBox);
            groupBox1.Controls.Add(zipOrgAddress_textBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 246);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Organization Address";
            // 
            // saveOrgAddress_button
            // 
            saveOrgAddress_button.Enabled = false;
            saveOrgAddress_button.Location = new Point(102, 215);
            saveOrgAddress_button.Name = "saveOrgAddress_button";
            saveOrgAddress_button.Size = new Size(75, 23);
            saveOrgAddress_button.TabIndex = 19;
            saveOrgAddress_button.Text = "Save";
            saveOrgAddress_button.UseVisualStyleBackColor = true;
            saveOrgAddress_button.Click += SaveOrgAddress_button_Click;
            // 
            // addOrg_button
            // 
            addOrg_button.Enabled = false;
            addOrg_button.Location = new Point(371, 6);
            addOrg_button.Name = "addOrg_button";
            addOrg_button.Size = new Size(75, 23);
            addOrg_button.TabIndex = 17;
            addOrg_button.Text = "Add";
            addOrg_button.UseVisualStyleBackColor = true;
            addOrg_button.Click += AddOrg_button_Click;
            // 
            // removeOrg_button
            // 
            removeOrg_button.Enabled = false;
            removeOrg_button.Location = new Point(371, 148);
            removeOrg_button.Name = "removeOrg_button";
            removeOrg_button.Size = new Size(75, 23);
            removeOrg_button.TabIndex = 18;
            removeOrg_button.Text = "Remove";
            removeOrg_button.UseVisualStyleBackColor = true;
            removeOrg_button.Click += RemoveOrg_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 45);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 19;
            label8.Text = "Organizations list:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 433);
            Controls.Add(label8);
            Controls.Add(removeOrg_button);
            Controls.Add(addOrg_button);
            Controls.Add(groupBox1);
            Controls.Add(orgName_textBox);
            Controls.Add(label7);
            Controls.Add(orgList_listBox);
            Name = "Form1";
            Text = "Lab 2 Var 2. (Клімач О.П. - 101 пТК)";
            ((System.ComponentModel.ISupportInitialize)organizationBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)organizationBindingSource2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)organizationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox orgList_listBox;
        private RichTextBox displayOrgAddress_richTextBox;
        private Label label1;
        private TextBox countryOrgAddress_textBox;
        private TextBox cityOrgAddress_textBox;
        private Label label2;
        private TextBox stateOrgAddress_textBox;
        private Label label3;
        private TextBox zipOrgAddress_textBox;
        private Label label4;
        private TextBox streetOrgAddress_textBox;
        private Label label5;
        private TextBox buildingOrgAddress_textBox;
        private Label label6;
        private TextBox orgName_textBox;
        private Label label7;
        private GroupBox groupBox1;
        private Button saveOrgAddress_button;
        private Button addOrg_button;
        private Button removeOrg_button;
        private Label label8;
        private BindingSource organizationBindingSource;
        private BindingSource organizationBindingSource2;
        private BindingSource organizationBindingSource1;
    }
}
