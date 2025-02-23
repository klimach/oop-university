namespace Lab4Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------One-Dimensional Array-----------");
            OneDimensionalArray();
            Console.WriteLine("-----------Two-Dimensional Array-----------");
            TwoDimensionalArray();
        }

        static void OneDimensionalArray()
        {
            int ARRAY_NUMBERS_COUNT = 20;
            double[] oneDimArray = new double[ARRAY_NUMBERS_COUNT];

            Random random = new();
            for (int index = 0; index < ARRAY_NUMBERS_COUNT; index++)
            {
                oneDimArray[index] = Math.Round(random.NextDouble() * 200 - 100, 3);
            }
            Console.WriteLine(string.Join(", ", oneDimArray));
            Console.WriteLine("-------------------------------------------");

            double product = oneDimArray.Where(el => el > 0).Sum();
            Console.WriteLine($"Product of positive numbers: {product}");

            double sum = oneDimArray.Take(Array.IndexOf(oneDimArray, oneDimArray.Min())).Sum();
            Console.WriteLine($"Sum of numbers before minimal element: {sum}");

            Console.WriteLine("-----------Sorted Odd elements------------");
            var oddIndexed = oneDimArray.Where((_, index) => index % 2 == 0).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", oddIndexed));
            Console.WriteLine("-----------Sorted Event elements-----------");
            var evenIndexed = oneDimArray.Where((_, index) => index % 2 != 0).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", evenIndexed));

            Console.WriteLine("-----------Final sorting result------------");
            int oddIndex = 0, evenIndex = 0;
            var sortedArr = oneDimArray.Select((_, index) => index % 2 == 0 ? oddIndexed[oddIndex++] : evenIndexed[evenIndex++]).ToArray();
            Console.WriteLine(string.Join(", ", sortedArr));
            Console.WriteLine("-------------------------------------------");
        }

        static void TwoDimensionalArray()
        {
            int ARRAY_NUMBERS_COUNT = 10;
            double[][] twoDimArray = [
                new double[ARRAY_NUMBERS_COUNT], 
                new double[ARRAY_NUMBERS_COUNT]
            ];

            Random random = new();
            for (int dim = 0; dim < twoDimArray.Length; dim++)
            {
                for (int index = 0; index < ARRAY_NUMBERS_COUNT; index++)
                {
                    twoDimArray[dim][index] = Math.Round(random.NextDouble() * 200 - 100, 3);
                }
            }

            Console.WriteLine(string.Join("\n", twoDimArray.Select(el => string.Join(", ", el))));
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Top-Left: {twoDimArray[0][0]}\nBottom-Right: {twoDimArray[^1][^1]}");
        }
    }
}
