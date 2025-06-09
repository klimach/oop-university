using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class EduTmplForm : Form
    {
        public EduTmplForm()
        {
            InitializeComponent();
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (char.IsControl(e.KeyChar)) return;
            if (e.KeyChar == '+')
            {
                if (tb.SelectionStart == 0 && !tb.Text.Contains('+'))
                {
                    return;
                }
                else
                {
                    e.Handled = true;
                    return;
                }
            }

            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private bool ValidateFields()
        {
            var fieldsToValidate = new Dictionary<Control, string>
            {
                { companyTextBox, @".+" },
                { amountTextBox, @"^\d+$" },
                { infoRichBox, @".+" },
                { numberTextBox, @"^\+?3?8?(0\d{9})$" },
                { siteTextBox, @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$" }
            };

            bool isValid = true;

            foreach (var pair in fieldsToValidate)
            {
                var control = pair.Key;
                string text = control is TextBox box ? box.Text :
                              control is RichTextBox ? ((RichTextBox)control).Text :
                              "";

                if (!Regex.IsMatch(text, pair.Value))
                {
                    control.BackColor = Color.LightPink;
                    isValid = false;
                }
                else
                {
                    control.BackColor = Color.White;
                }
            }

            return isValid;
        }

        private void btnCreateCert_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                using SaveFileDialog saveFileDialog = new();
                saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
                saveFileDialog.Title = "Виберіть шлях для збереження сертифіката";
                saveFileDialog.FileName = "Сертифікат.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputPath = saveFileDialog.FileName;

                    string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                    string templatePath = Path.Combine(baseDir, "Templates", "Сертифікат на навчання.docx");

                    using var wordProvider = new WordTemplateProvider(templatePath);
                    wordProvider.ReplacePlaceholder("{компанія}", companyTextBox.Text.Trim());
                    wordProvider.ReplacePlaceholder("{сума}", amountTextBox.Text.Trim() + "$");
                    wordProvider.ReplacePlaceholder("{інформація}", infoRichBox.Text.Trim());
                    wordProvider.ReplacePlaceholder("{номер}", numberTextBox.Text.Trim());
                    wordProvider.ReplacePlaceholder("{сайт}", siteTextBox.Text.Trim());
                    wordProvider.ReplacePlaceholder("{дата}", expiredAtDateTimePicker.Value.ToString("dd MMMM yyyy"));

                    wordProvider.SaveAs(outputPath);

                    MessageBox.Show("Сертифікат успішно збережено!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, перевірте заповнення полів!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
