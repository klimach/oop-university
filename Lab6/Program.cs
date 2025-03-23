using System.Text.RegularExpressions;

namespace Lab6Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string errorReason = string.Empty;
            try
            {
                Console.WriteLine("Enter 3 sides (one-by-one) of Triange to calculate it's Area:");
                Triangle triangle = RetrieveTriangleFromUser();
                Console.WriteLine($"Triangle Area =: {triangle.GetTriangleArea()}");
            }
            catch (FormatException ex)
            {
                errorReason = "Entered number is in incorrect format. Expected examples: '1', '124,5', '12.3'";
            }
            catch (ArgumentException ex)
            {
                errorReason = ex.Message;
            }
            catch (ArithmeticException ex)
            {
                errorReason = ex.Message;
            }
            catch (Exception ex)
            {
                errorReason = $"Unexpected error occured. Please check input values and try again.\n{ex.Message}";
            }

            if (!string.IsNullOrEmpty(errorReason))
            {
                Console.WriteLine(errorReason);
            }
        }

        private static Triangle RetrieveTriangleFromUser()
        {
            double[] sides = new double[3];
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Side {i} = ");
                string? consoleInput = Console.ReadLine();
                sides[i - 1] = double.Parse(consoleInput);
            }

            return new Triangle(sides[0], sides[1], sides[2]);
        }
    }
}
