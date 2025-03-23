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

        private bool IsTriangleValid()
        {
            return sideA > 0 && sideB > 0 && sideC > 0 &&
                   sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        public double GetTriangleArea()
        {
            if (!IsTriangleValid())
                throw new ArgumentException("Incorrect sides");

            double p = (sideA + sideB + sideC) / 2;
            double areaSquared = p * (p - sideA) * (p - sideB) * (p - sideC);

            if (areaSquared < 0)
                throw new ArithmeticException("Impossible to calculate Area — Squared expression less then 0");

            return Math.Sqrt(areaSquared);
        }
    }
}
