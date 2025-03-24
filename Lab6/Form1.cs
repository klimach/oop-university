namespace Lab6Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBox.Text.Length == 0)
                {
                    textBox.Text = "0,";
                    textBox.SelectionStart = textBox.Text.Length;
                    e.Handled = true;
                }
                else if (textBox.Text.Contains(','))
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    SelectNextControl(textBox, true, true, true, true);
                return;
            }
            e.Handled = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            string outputString;
            try
            {
                Triangle triangle = new(
                    double.Parse(sideA_textBox.Text),
                    double.Parse(sideB_textBox.Text),
                    double.Parse(sideC_textBox.Text));
                outputString = $"Triangle Area = {String.Format("{0:N}", triangle.GetTriangleArea())}";
            }
            catch (FormatException ex)
            {
                outputString = "Enter all sides fields";
            }
            catch (ArgumentException ex)
            {
                outputString = ex.Message;
            }
            catch (ArithmeticException ex)
            {
                outputString = ex.Message;
            }
            catch (Exception ex)
            {
                outputString = $"Unexpected error occured. Please check input fields and try again.\n{ex.Message}";
            }
                
            output.Text = outputString;
        }
    }
}
