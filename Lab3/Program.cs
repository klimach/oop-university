namespace Lab3Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();

            Integer int1 = new(random.Next(1, 100));
            Integer int2 = new(random.Next(1, 100));
            Real real1 = new(random.NextDouble() * 100);
            Real real2 = new(random.NextDouble() * 100);

            Console.WriteLine($"Integer 1: {int1}");
            Console.WriteLine($"Integer 2: {int2}");
            Console.WriteLine($"Real 1: {real1}");
            Console.WriteLine($"Real 2: {real2}");

            PerformOperations(int1, int2, "INT/INT");
            PerformOperations(int1, real1, "INT/REAL");
            PerformOperations(real1, int2, "REAL/INT");
            PerformOperations(real1, real2, "REAL/REAL");
        }

        static void PerformOperations(Number num1, Number num2, string label)
        {
            Number sum = num1 + num2;
            Number difference = num1 - num2;
            Number product = num1 * num2;
            Number fraction = num1 / num2;

            Console.WriteLine($"\n----- {label} -----");
            Console.WriteLine($"Sum of {num1} and {num2}: {sum}");
            Console.WriteLine($"Difference of {num1} and {num2}: {difference}");
            Console.WriteLine($"Product of {num1} and {num2}: {product}");
            Console.WriteLine($"Fraction of {num1} and {num2}: {fraction}");
        }
    }
}
