using System.Text.RegularExpressions;

namespace Lab1Project
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool ValidateDecimalInput(string input, out decimal value)
        {
            value = 0;
            return !string.IsNullOrWhiteSpace(input) && decimal.TryParse(input, out value);
        }

        private static bool ValidateIntegerInput(string input, out int value)
        {
            value = 0;
            return !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out value);
        }

        private void Decimal_TextBoxInputHandler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox) return;
            if (char.IsDigit(e.KeyChar)) return;
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

        private void Integer_TextBoxInputHandler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox) return;
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

        /////////////// TASK 1 ///////////////

        private void Task1buttonCalculate_Click(object sender, EventArgs e)
        {
            List<string> emptyFields = [];

            if (!ValidateDecimalInput(task1textBoxVariableA.Text, out decimal varA))
                emptyFields.Add("A");

            if (!ValidateDecimalInput(task1textBoxVariableB.Text, out decimal varB))
                emptyFields.Add("B");

            if (!ValidateDecimalInput(task1textBoxVariableC.Text, out decimal varC))
                emptyFields.Add("C");

            if (!ValidateDecimalInput(task1textBoxVariableD.Text, out decimal varD))
                emptyFields.Add("D");

            if (emptyFields.Count != 0)
            {
                task1richBoxOutput.Text = $"Next variables are not populated: {string.Join(',', emptyFields)}";
                return;
            }
            try
            {
                decimal result = (varA / varB) * (varB / varD) - ((varA * varB - varC) / (varC * varD));
                task1richBoxOutput.Text = $"{result}";
            }
            catch (DivideByZeroException)
            {
                task1richBoxOutput.Text = $"Devide by zero. Please check variables";
            }

            return;
        }

        /////////////// TASK 2 ///////////////
        private void Task2button_Calculate_Click(object sender, EventArgs e)
        {
            if (!(ValidateDecimalInput(task2textBox_BoatSpeed.Text, out decimal boatSpeed) &&
                  ValidateDecimalInput(task2textBox_RiverSpeed.Text, out decimal riverSpeed) &&
                  ValidateDecimalInput(task2textBox_LakeTime.Text, out decimal lakeTime) &&
                  ValidateDecimalInput(task2textBox_AgainstRiverTime.Text, out decimal againstRiverTime)))
            {
                task2richText_Output.Text = "Заповніть всі поля та спробуйте ще раз";
                return;
            }

            if (boatSpeed > riverSpeed)
            {
                decimal distanceOnLake = boatSpeed * lakeTime;
                decimal distanceOnRiver = (boatSpeed - riverSpeed) * againstRiverTime;
                decimal totalDistance = distanceOnLake + distanceOnRiver;

                string output = $"Дистанція пройдена по озеру: {distanceOnLake} км";
                output += $"\nДистанція пройдена по річці: {distanceOnRiver} км";
                output += $"\nЗагалом пройдено шлях: {totalDistance} км";

                task2richText_Output.Text = output;
            } else
            {
                task2richText_Output.Text = "Дистанція проти течії не може бути вищою ніж по озеру";
            }


        }

        /////////////// TASK 3 ///////////////
        private void Task3textBoxInputHandler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox) return;
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (textBox.Text.Length >= 3)
                {
                    e.Handled = true;
                    return;
                }
                else if (textBox.Text.Length < 2)
                {
                    task3labelAnswer.Text = "false";
                }
                else if (textBox.Text.Length == 2)
                {
                    int sum = (textBox.Text + e.KeyChar).Select(ch => int.Parse(ch.ToString())).Sum();
                    task3labelAnswer.Text = (sum % 2 == 0).ToString().ToLower();
                }

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /////////////// TASK 4 ///////////////

        private static int CrossProductSign(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3)
        {
            decimal crossProduct = (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);
            return Math.Sign(crossProduct);
        }

        private void Task4buttonCheck_Click(object sender, EventArgs e)
        {
            if (!(ValidateDecimalInput(task4textBoxA_X.Text, out decimal varA_X) &&
                ValidateDecimalInput(task4textBoxA_Y.Text, out decimal varA_Y) &&
                ValidateDecimalInput(task4textBoxB_X.Text, out decimal varB_X) &&
                ValidateDecimalInput(task4textBoxB_Y.Text, out decimal varB_Y) &&
                ValidateDecimalInput(task4textBoxC_X.Text, out decimal varC_X) &&
                ValidateDecimalInput(task4textBoxC_Y.Text, out decimal varC_Y) &&
                ValidateDecimalInput(task4textBoxD_X.Text, out decimal varD_X) &&
                ValidateDecimalInput(task4textBoxD_Y.Text, out decimal varD_Y)))
            {
                task4reachTextOutput.Text = "Заповніть всі поля та спробуйте ще раз";
                return;
            }

            int sign1 = CrossProductSign(varA_X, varA_Y, varB_X, varB_Y, varC_X, varC_Y);
            int sign2 = CrossProductSign(varB_X, varB_Y, varC_X, varC_Y, varD_X, varD_Y);
            int sign3 = CrossProductSign(varC_X, varC_Y, varD_X, varD_Y, varA_X, varA_Y);
            int sign4 = CrossProductSign(varD_X, varD_Y, varA_X, varA_Y, varB_X, varB_Y);

            task4reachTextOutput.Text =
                (sign1 == sign2 && sign2 == sign3 && sign3 == sign4) ? "Опуклий" : "Не опуклий";
        }

        /////////////// TASK 5 ///////////////

        public static List<int> FindIntegerRoots(int a, int b, int c, int d)
        {
            List<int> roots = [];
            List<int> divisors = [];

            for (int i = 1; i <= Math.Abs(d); i++)
            {
                if (d % i == 0) divisors.AddRange([i, -i]);
            }

            foreach (int root in divisors.OrderBy(el => el))
            {
                if (a * root * root * root + b * root * root + c * root + d == 0)
                    roots.Add(root);
            }

            return roots;
        }

        private void Task5buttonCalculate_Click(object sender, EventArgs e)
        {
            if (!(ValidateIntegerInput(task5textBoxVarA.Text, out int varA) &&
                  ValidateIntegerInput(task5textBoxVarB.Text, out int varB) &&
                  ValidateIntegerInput(task5textBoxVarC.Text, out int varC) &&
                  ValidateIntegerInput(task5textBoxVarD.Text, out int varD)))
            {
                task5richTextOutput.Text = "Заповніть всі поля та спробуйте ще раз";
                return;
            }

            List<int> roots = FindIntegerRoots(varA, varB, varC, varD);
            task5richTextOutput.Text = $"Цілі корені рівняння: {string.Join(',', roots)}";
        }

        /////////////// TASK 6 ///////////////

        private void Task6textBoxInputHandler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox) return;

            string currentText = textBox.Text.Trim();

            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '-')
            {
                if (currentText.Length == 0)
                {
                    textBox.Text = currentText += "-";
                }
                else if (currentText.EndsWith(';'))
                {
                    textBox.Text = currentText += " -";
                }
                textBox.SelectionStart = textBox.Text.Length;
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == ';')
            {
                if (currentText.Length != 0 && char.IsDigit(currentText.Last()))
                {
                    textBox.Text = currentText += "; ";
                }
                textBox.SelectionStart = textBox.Text.Length;
                e.Handled = true;
                return;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                if (currentText.Length != 0)
                {
                    if (Char.IsDigit(currentText.Last()))
                    {
                        textBox.Text = currentText += "; ";
                    }
                    else if (currentText.Last() is ';')
                    {
                        textBox.Text = currentText += " ";
                    }
                    textBox.SelectionStart = textBox.Text.Length;
                    e.Handled = true;
                    return;
                }
            }

            e.Handled = true;
        }

        private void Task6buttonRandom_Click(object sender, EventArgs e)
        {
            task6textBoxListA.Text = string.Empty;
            task6textBoxListB.Text = string.Empty;

            int listA_elementsCount = 20;
            int listB_elementsCount = 15;
            int numbersRange = 100;
            Random random = new();

            task6textBoxListA.Text = string.Join("; ",
                Enumerable.Range(1, listA_elementsCount)
                          .Select(_ => random.Next(-numbersRange, numbersRange + 1)));

            task6textBoxListB.Text = string.Join("; ",
                Enumerable.Range(1, listB_elementsCount)
                          .Select(_ => random.Next(-numbersRange, numbersRange + 1)));
        }

        private void Task6buttonCompare_Click(object sender, EventArgs e)
        {
            List<int> listA_elements = [];
            List<int> listB_elements = [];
            string output = string.Empty;

            listA_elements = task6textBoxListA.Text.Split(";", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).Select(el => int.Parse(el.Trim())).ToList();
            listB_elements = task6textBoxListB.Text.Split(";", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).Select(el => int.Parse(el.Trim())).ToList();


            if (listA_elements.Count == 0)
            {
                output = "Список А пустий";
                task6richTextOutput.Text = output;
                return;
            }
            else if (listB_elements.Count == 0)
            {
                output = "Список B пустий";
                task6richTextOutput.Text = output;
                return;
            }
            else if (listA_elements.Count <= listB_elements.Count)
            {
                output = "Список А має містити більше елементів ніж список B";
                task6richTextOutput.Text = output;
                return;
            }

            List<int> intersectedElements = listA_elements.Intersect(listB_elements).ToList();
            if (intersectedElements.Count == 0)
            {
                output = "Жоден елемент списку B не входить в список А";
            }
            else if (intersectedElements.Count == listB_elements.Count)
            {
                output = "Всі елементи списку B входять в список А";
            }
            else
            {
                output = $"{intersectedElements.Count} елементів списку B входять в список А";
            }
            task6richTextOutput.Text = output;
        }

        /////////////// TASK 7 ///////////////

        private void Task7buttonCheckWords_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(task7richTextInput.Text))
            {
                task7richTextOutput.Text = "Вхідні дані відсутні. Введіть текст.";
                return;
            }
            string output = string.Empty;
            string rePattern = @"\b[Bb]\w*";
            MatchCollection matches = Regex.Matches(task7richTextInput.Text, rePattern);
            List<string> foundWords = matches.Select(m => m.Value).ToList();
            output = $"Знайдено {foundWords.Count}";

            if (foundWords.Count > 0)
            {
                output += $"\nСлова: {string.Join(',', foundWords)}";
            }
            task7richTextOutput.Text = output;
        }

    }
}
