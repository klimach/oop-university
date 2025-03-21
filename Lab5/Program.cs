using System.Text.RegularExpressions;

namespace Lab5Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'Exit' for close programm");
            while (true)
            {
                Console.Write("Input >: ");
                string? input = Console.ReadLine();
                if (input != null)
                {
                    if (input.Trim().ToLower().Equals("exit"))
                    {
                        break;
                    }
                    Console.WriteLine($"Output >: {Regex.Replace(input, @"\s+", " ")}");
                }
            }
        }
    }
}
