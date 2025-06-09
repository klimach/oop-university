using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16
{
    public partial class SettingsForm : Form
    {
        public string Host { get; set; }
        public int LocalPort { get; set; }
        public int RemotePort { get; set; }
        public Font ChatFont { get; set; }

        public SettingsForm(string currentHost, int currentLocalPort, int currentRemotePort, Font currentFont)
        {
            InitializeComponent();

            hostTextBox.Text = currentHost;
            localPortTextBox.Text = currentLocalPort.ToString();
            remotePortTextBox.Text = currentRemotePort.ToString();
            ChatFont = currentFont;
            lblFontPreview.Font = currentFont;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<string> incorrectValues = [];
            
            if (string.IsNullOrWhiteSpace(hostTextBox.Text) || !IPAddress.TryParse(hostTextBox.Text, out _)) incorrectValues.Add("Хост (IP)");
            if (!Int32.TryParse(localPortTextBox.Text, out int localPortTBValue)) incorrectValues.Add("Local - порт");
            if (!Int32.TryParse(remotePortTextBox.Text, out int remotePortTBValue)) incorrectValues.Add("Remote - порт");

            if (incorrectValues.Count > 0)
            {
                MessageBox.Show("Некоректні значення:\n" + string.Join("\n", incorrectValues), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Host = hostTextBox.Text;
            LocalPort = localPortTBValue;
            RemotePort = remotePortTBValue;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            using FontDialog fontDialog = new();
            fontDialog.Font = ChatFont;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                ChatFont = fontDialog.Font;
                lblFontPreview.Font = ChatFont;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
