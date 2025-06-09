using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab15
{
    public partial class SettingsForm : Form
    {
        private string settingsFile = "settings.txt";

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllLines(settingsFile, new string[]
                {
                    tbHost.Text,
                    tbUser.Text,
                    tbPass.Text
                });

                MessageBox.Show("Налаштування збережено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(settingsFile))
                {
                    string[] lines = File.ReadAllLines(settingsFile);
                    tbHost.Text = lines.Length > 0 ? lines[0] : "";
                    tbUser.Text = lines.Length > 1 ? lines[1] : "";
                    tbPass.Text = lines.Length > 2 ? lines[2] : "";

                    MessageBox.Show("Налаштування завантажено!");
                }
                else
                {
                    MessageBox.Show("Файл налаштувань не знайдено.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження: " + ex.Message);
            }
        }

        public string Host => tbHost.Text;
        public string User => tbUser.Text;
        public string Pass => tbPass.Text;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
