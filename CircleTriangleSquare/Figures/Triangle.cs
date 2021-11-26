using System;

namespace CircleTriangleSquare
{
    public class Triangle: Figure
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public bool isTriangleRight(double a, double b, double c)
        {
            return a == b || b == c || a == c;
        }

        public double getRightTriangleSquare(double a, double b, double c)
        {
            if (a == b)
            {
                return a * c / 2;
            }
            if (b == c)
            {
                return a * b / 2;
            }

            return b * c / 2;
        }

        public override double GetArea()
        {
            double p = GetPerimeter()/2;
            if (isTriangleRight(sideA, sideB, sideC))
            {
                return getRightTriangleSquare(sideA, sideB, sideC);
            }
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public override double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}