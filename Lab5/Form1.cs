using System.Text.RegularExpressions;

namespace Lab5Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            RichTextBox textBox = (RichTextBox)sender;
            output.Text = Regex.Replace(textBox.Text, @"\s+", " ");
        }
    }
}
