using RGR.Controllers;
using RGR.Models;
using System.Text.RegularExpressions;

namespace RGR
{
    public partial class PersonDetailsForm : Form
    {
        public bool IsUpdated = false;

        private readonly DBController _dbController;
        private Person? _person = null;
        private bool _onEdit = false;

        public PersonDetailsForm(DBController dbController)
        {
            _dbController = dbController;
            InitializeComponent();
            _onEdit = true;
            btnEdit.Visible = false;
            SetFieldsEditable(true);
            ValidateAge();
        }

        public PersonDetailsForm(DBController dbController, Person person)
        {
            _dbController = dbController;
            InitializeComponent();
            SetFieldsEditable(false);
            PopulatePersonInfo(person);
            ValidateAge();
            _person = person;
        }

        private void ToggleOnEdit()
        {
            _onEdit = !_onEdit;
            btnEdit.Text = _onEdit ? "Скасувати" : "Редагувати";
            btnSave.Enabled = _onEdit;
            btnEdit.BackColor = _onEdit ? Color.LightCoral : Color.White;
            btnEdit.ForeColor = _onEdit ? Color.White : SystemColors.ControlText;
        }

        private void SetFieldsEditable(bool isEnabled)
        {
            btnSave.Enabled = isEnabled;

            tbSecondName.Enabled = isEnabled;
            tbFirstName.Enabled = isEnabled;
            tbMiddleName.Enabled = isEnabled;
            cbGender.Enabled = isEnabled;
            dtpBirthDate.Enabled = isEnabled;
            rtbAddress.Enabled = isEnabled;
            tbPhoneNumber.Enabled = isEnabled;
            tbEmail.Enabled = isEnabled;
            tbPassportNumber.Enabled = isEnabled;
            dtpPassportIssueDate.Enabled = isEnabled;
            rtbPassportIssuedBy.Enabled = isEnabled;
            tbJobTitle.Enabled = isEnabled;
            tbOrganization.Enabled = isEnabled;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!_onEdit)
            {
                SetFieldsEditable(true);
                ToggleOnEdit();
            }
            else
            {
                PopulatePersonInfo(_person!);
                SetFieldsEditable(false);
                ToggleOnEdit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSecondName.Text) ||
                string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                cbGender.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(rtbAddress.Text) ||
                tbPhoneNumber.Text.Length != 13 ||
                !IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Не всі обов'язкові поля заповнені або некоректні");
                return;
            }
            if (_person == null)
            {
                _person = new Person()
                {
                    FirstName = "",
                    SecondName = "",
                    Gender = "",
                    BirthDate = DateTime.Today.ToString("yyyy-MM-dd"),
                    Address = "",
                    Phone = "",
                    Email = ""
                };
                UpdatePersonFromForm(_person);
                _dbController.AddPerson(_person);
                MessageBox.Show("Запис успішно створено");
            }
            else
            {
                UpdatePersonFromForm(_person);
                _dbController.UpdatePerson(_person);
                MessageBox.Show("Дані успішно оновлено");
            }
            btnEdit.Visible = true;
            ToggleOnEdit();
            SetFieldsEditable(false);
            this.Text = $"Деталі запису - [{_person.FullName}]";
            IsUpdated = true;
        }

        #region Phone number validation
        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (tbPhoneNumber.Text.Length == 0)
            {
                if (e.KeyChar == '+' || e.KeyChar == '3' || e.KeyChar == '0')
                {
                    e.Handled = true;
                    tbPhoneNumber.Text = "+380";
                    tbPhoneNumber.SelectionStart = tbPhoneNumber.Text.Length;
                }
                else
                {
                    e.Handled = true;
                }
                return;
            }

            if (tbPhoneNumber.SelectionStart < 4)
            {
                e.Handled = true;
                tbPhoneNumber.SelectionStart = tbPhoneNumber.Text.Length;
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tbPhoneNumber.Text.Length >= 13)
            {
                e.Handled = true;
            }
        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbPhoneNumber.Text.Length < 4)
            {
                tbPhoneNumber.Text = "+380";
                tbPhoneNumber.SelectionStart = tbPhoneNumber.Text.Length;
                return;
            }

            if (tbPhoneNumber.Text.Length == 13)
            {
                tbPhoneNumber.ForeColor = SystemColors.ControlText;
            }
            else
            {
                tbPhoneNumber.ForeColor = Color.LightCoral;
            }
        }

        private void tbPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.Back) && 
                tbPhoneNumber.SelectionStart <= 4)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        #endregion

        #region Email validation
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(tbEmail.Text))
            {
                tbEmail.ForeColor = SystemColors.ControlText;
            }
            else
            {
                tbEmail.ForeColor = Color.LightCoral;
            }
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
        #endregion

        #region Birth date validation
        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            ValidateAge();
        }

        private void ValidateAge()
        {
            int age = CalculateAge();
            if (age >= 18)
            {
                gbPassport.Enabled = true;
                gbJobInfo.Enabled = true;
            }
            else if (age >= 14)
            {
                gbPassport.Enabled = true;
                gbJobInfo.Enabled = false;
            }
            else
            {
                gbPassport.Enabled = false;
                gbJobInfo.Enabled = false;
            }
        }

        private int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dtpBirthDate.Value.Year;
            if (dtpBirthDate.Value.Date > today.AddYears(-age)) age--;
            return age;
        }
        #endregion

        private void PopulatePersonInfo(Person person)
        {
            tbSecondName.Text = person.SecondName;
            tbFirstName.Text = person.FirstName;
            tbMiddleName.Text = person.MiddleName;
            cbGender.Text = person.Gender;

            dtpBirthDate.Value = DateTime.ParseExact(
                person.BirthDate, "yyyy-MM-dd", 
                System.Globalization.CultureInfo.InvariantCulture);
            rtbAddress.Text = person.Address;
            tbPhoneNumber.Text = person.Phone;
            tbEmail.Text = person.Email;

            tbPassportNumber.Text = person.PassportNumber;
            if (!string.IsNullOrWhiteSpace(person.PassportIssueDate))
            {
                dtpPassportIssueDate.Value = DateTime.ParseExact(
                    person.PassportIssueDate, "yyyy-MM-dd", 
                    System.Globalization.CultureInfo.InvariantCulture);
                dtpPassportIssueDate.Checked = true;
            }
            else
            {
                dtpPassportIssueDate.Value = DateTime.Today;
                dtpPassportIssueDate.Checked = false;
            }
            rtbPassportIssuedBy.Text = person.PassportIssuedBy;
            tbJobTitle.Text = person.JobTitle;
            tbOrganization.Text = person.Organization;

            this.Text = $"Деталі запису - [{person.FullName}]";
        }

        private void UpdatePersonFromForm(Person person)
        {
            person.SecondName = tbSecondName.Text.Trim();
            person.FirstName = tbFirstName.Text.Trim();
            person.MiddleName = string.IsNullOrWhiteSpace(tbMiddleName.Text) ? 
                null : tbMiddleName.Text.Trim();
            person.Gender = cbGender.SelectedItem!.ToString()!;
            person.BirthDate = dtpBirthDate.Value.ToString("yyyy-MM-dd");
            person.Address = rtbAddress.Text.Trim();
            person.Phone = tbPhoneNumber.Text.Trim();
            person.Email = tbEmail.Text.Trim();
            person.PassportNumber = string.IsNullOrWhiteSpace(tbPassportNumber.Text) ? 
                null : tbPassportNumber.Text.Trim();
            person.PassportIssueDate = (dtpPassportIssueDate.Checked)
                ? dtpPassportIssueDate.Value.ToString("yyyy-MM-dd")
                : null;
            person.PassportIssuedBy = string.IsNullOrWhiteSpace(rtbPassportIssuedBy.Text) ? 
                null : rtbPassportIssuedBy.Text.Trim();
            person.JobTitle = string.IsNullOrWhiteSpace(tbJobTitle.Text) ? 
                null : tbJobTitle.Text.Trim();
            person.Organization = string.IsNullOrWhiteSpace(tbOrganization.Text) ? 
                null : tbOrganization.Text.Trim();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
