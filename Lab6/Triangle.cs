using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Project
{
    public class Triangle(double a, double b, double c)
    {
        private readonly double sideA = a;
        private readonly double sideB = b;
        private readonly double sideC = c;

        public double GetTriangleArea()
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException($"Side lengths must be positive. Received: a={sideA}, b={sideB}, c={sideC}");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException($"Triangle inequality not satisfied. Received: a={sideA}, b={sideB}, c={sideC}");

            double p = (sideA + sideB + sideC) / 2;
            double areaSquared = p * (p - sideA) * (p - sideB) * (p - sideC);

            if (areaSquared < 0)
                throw new ArithmeticException($"Area calculation failed. Expression under square root is negative: {areaSquared}");

            return Math.Sqrt(areaSquared);
        }
    }
}
