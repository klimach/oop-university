namespace Lab3Project
{
    public partial class Form1 : Form
    {
        private readonly string[] numTypes = ["Integer", "Real"];

        public Form1()
        {
            InitializeComponent();

            number1comboBox.Items.AddRange(numTypes);
            number2comboBox.Items.AddRange(numTypes);
            number1comboBox.SelectedItem = number1comboBox.Items[0];
            number2comboBox.SelectedItem = number2comboBox.Items[0];
        }

        private void printOutput(string output) => outputBox.Text = output;

        private void addButton_Click(object sender, EventArgs e)
        {
            Number number1 = GetNumber1Object();
            Number number2 = GetNumber2Object();

            printOutput($"Sum of {number1} and {number2} = {number1 + number2}");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            Number number1 = GetNumber1Object();
            Number number2 = GetNumber2Object();

            printOutput($"Difference of {number1} and {number2} = {number1 - number2}");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            Number number1 = GetNumber1Object();
            Number number2 = GetNumber2Object();

            printOutput($"Product of {number1} and {number2} = {number1 * number2}");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            Number number1 = GetNumber1Object();
            Number number2 = GetNumber2Object();

            printOutput($"Fraction of {number1} and {number2} = {number1 / number2}");
        }

        private void number1textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (number1comboBox.Text)
            {
                case "Integer":
                    IntegerValidate(sender, e);
                    break;
                case "Real":
                    RealValidate(sender, e);
                    break;
                default:
                    throw new ArgumentException($"Unknown number type: '{number1comboBox.Text}'");
            }
        }

        private void number2textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (number2comboBox.Text)
            {
                case "Integer":
                    IntegerValidate(sender, e);
                    break;
                case "Real":
                    RealValidate(sender, e);
                    break;
                default:
                    throw new ArgumentException($"Unknown number type: '{number2comboBox.Text}'");
            }
        }

        private void number1comboBox_SelectedValueChanged(object sender, EventArgs e) => number1textBox.Text = "0";
        private void number2comboBox_SelectedValueChanged(object sender, EventArgs e) => number2textBox.Text = "0";

        private void RealValidate(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (textBox.Text.Length == 1 && textBox.Text == "0" && Char.IsDigit(e.KeyChar)) 
            {
                textBox.Text = e.KeyChar.ToString();
                textBox.SelectionStart = textBox.Text.Length;
                e.Handled = true;
                return;
            }
            if (textBox.Text.Length == 0 && e.KeyChar == '-') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBox.Text.Length == 0)
                {
                    textBox.Text = "0,";
                    textBox.SelectionStart = textBox.Text.Length;
                    e.Handled = true;
                }
                else if (textBox.Text.Length == 1 && textBox.Text == "-")
                {
                    textBox.Text = "-0,";
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
        private void IntegerValidate(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox) return;
            if (textBox.Text.Length == 1 && textBox.Text == "0" && Char.IsDigit(e.KeyChar))
            {
                textBox.Text = e.KeyChar.ToString();
                textBox.SelectionStart = textBox.Text.Length;
                e.Handled = true;
                return;
            }
            if (char.IsDigit(e.KeyChar)) return;
            if (textBox.Text.Length == 0 && e.KeyChar == '-') return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    SelectNextControl(textBox, true, true, true, true);
                return;
            }
            e.Handled = true;
        }

        private Number GetNumber1Object()
        {
            switch (number1comboBox.Text)
            {
                case "Integer":
                    return new Integer(int.Parse(number1textBox.Text));
                case "Real":
                    return new Real(double.Parse(number1textBox.Text));
                default:
                    throw new ArgumentException($"Unknown number type: '{number1comboBox.Text}'");
            }
        }
        private Number GetNumber2Object() 
        {
            switch (number2comboBox.Text)
            {
                case "Integer":
                    return new Integer(int.Parse(number2textBox.Text));
                case "Real":
                    return new Real(double.Parse(number2textBox.Text));
                default:
                    throw new ArgumentException($"Unknown number type: '{number2comboBox.Text}'");
            }
        }
    }
}
