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
    public partial class HouseTmplForm : Form
    {
        public HouseTmplForm()
        {
            InitializeComponent();

            houseTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            houseTypeComboBox.Items.AddRange(["Квартира", "Будинок", "Таунхаус", "Пентхаус"]);
            houseTypeComboBox.SelectedIndex = 0;
        }

        private bool ValidateFields()
        {
            bool isValid = true;

            if (houseTypeComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(houseTypeComboBox.Text))
            {
                houseTypeComboBox.BackColor = Color.LightPink;
                isValid = false;
            }
            else
            {
                houseTypeComboBox.BackColor = Color.White;
            }


            var fieldsToValidate = new Dictionary<TextBox, string>
            {
                { residentialComplexTextBox, @".+" },
                { cityTextBox, @".+" }
            };

            foreach (var pair in fieldsToValidate)
            {
                var textBox = pair.Key;
                string pattern = pair.Value;

                if (!Regex.IsMatch(textBox.Text, pattern))
                {
                    textBox.BackColor = Color.LightPink;
                    isValid = false;
                }
                else
                {
                    textBox.BackColor = Color.White;
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
                    string templatePath = Path.Combine(baseDir, "Templates", "Сертифікат на будинок.docx");

                    using var wordProvider = new WordTemplateProvider(templatePath);
                    wordProvider.ReplacePlaceholder("{житло}", houseTypeComboBox.Text.Trim());
                    wordProvider.ReplacePlaceholder("{місто}", cityTextBox.Text.Trim());
                    wordProvider.ReplacePlaceholder("{ЖК}", residentialComplexTextBox.Text.Trim());
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
