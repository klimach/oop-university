using System.Text;

namespace Lab4Project
{
    public partial class Form1 : Form
    {
        double[] oneDimArray;
        double[][] twoDimArray;

        public Form1()
        {
            InitializeComponent();
        }

        private void oneDimGenerate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(oneDimNelements.Text))
            {
                oneDimArray_textBox.Text = "Set number of elements in array";
                oneDimPositiveSum.Text = "";
                oneDimUntilMinSum.Text = "";
                oneDimSortOutput.Text = "";
                return;
            }

            int numberOfElements = int.Parse(oneDimNelements.Text);
            oneDimArray = new double[numberOfElements];

            Random random = new();
            for (int index = 0; index < numberOfElements; index++)
            {
                oneDimArray[index] = Math.Round(random.NextDouble() * 200 - 100, 3);
            }

            double sumOfPositive = oneDimArray.Where(el => el > 0).Sum();
            double sumUntilFirstMinimal = oneDimArray.Take(Array.IndexOf(oneDimArray, oneDimArray.Min())).Sum();

            oneDimArray_textBox.Text = $"[{string.Join(", ", oneDimArray)}]";

            double[] oddIndexed = [.. oneDimArray.Where((_, index) => index % 2 == 0).OrderBy(x => x)];
            double[] evenIndexed = [.. oneDimArray.Where((_, index) => index % 2 != 0).OrderBy(x => x)];

            int oddIndex = 0, evenIndex = 0;
            double[] sortedArr = oneDimArray.Select((_, index) => index % 2 == 0 ? oddIndexed[oddIndex++] : evenIndexed[evenIndex++]).ToArray();

            oneDimPositiveSum.Text = string.Format("{0:N}", sumOfPositive);
            oneDimUntilMinSum.Text = string.Format("{0:N}", sumUntilFirstMinimal);

            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine("-----------Sorted Odd elements------------");
            stringBuilder.AppendLine($"[{string.Join(", ", oddIndexed)}]");
            stringBuilder.AppendLine("-----------Sorted Even elements-----------");
            stringBuilder.AppendLine($"[{string.Join(", ", evenIndexed)}]");
            stringBuilder.AppendLine("-----------Final sorting result-----------");
            stringBuilder.AppendLine($"[{string.Join(", ", sortedArr)}]");
            oneDimSortOutput.Text = stringBuilder.ToString();
        }

        private void twoDimGenerate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(twoDimNelements.Text))
            {
                twoDimArray_textBox.Text = "Set number of elements in array dimension";
                twoDimTopLeft.Text = "";
                twoDimBotRight.Text = "";
                return;
            }

            int numberOfElements = int.Parse(twoDimNelements.Text);
            twoDimArray = [
                new double[numberOfElements],
                new double[numberOfElements]
            ];

            Random random = new();
            for (int dim = 0; dim < twoDimArray.Length; dim++)
            {
                for (int index = 0; index < numberOfElements; index++)
                {
                    twoDimArray[dim][index] = Math.Round(random.NextDouble() * 200 - 100, 3);
                }
            }

            StringBuilder stringBuilder = new();
            stringBuilder.Append('[');
            stringBuilder.Append(string.Join("\n", twoDimArray.Select(el => $"[{string.Join(", ", el)}]")));
            stringBuilder.Append(']');
            twoDimArray_textBox.Text = stringBuilder.ToString();
            twoDimTopLeft.Text = twoDimArray[0][0].ToString();
            twoDimBotRight.Text = twoDimArray[^1][^1].ToString();
        }

        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
