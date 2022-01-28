using System;

namespace CircleTriangleSquare
{
    public class Triangle: IFigureInfo
    {
        public double sideA { get; }
        public double sideB { get; }
        public double sideC { get; }

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public bool isTriangleRight()
        {
            double sideAPow2 = Math.Pow(sideA, 2);
            double sideBPow2 = Math.Pow(sideB, 2);
            double sideCPow2 = Math.Pow(sideC, 2);

            return (sideAPow2 + sideBPow2) == sideCPow2 ||
                   (sideAPow2 + sideCPow2) == sideBPow2 ||
                   (sideBPow2 + sideCPow2) == sideAPow2;
        }

        public bool CheckIncomeData()
        {
            return sideA > 0 & sideB > 0 & sideC > 0;
        }

        public double calculateRightTriangleSquare()
        {
            if (sideA == sideB)
            {
                return sideA * sideB / 2;
            }
            if (sideB == sideC)
            {
                return sideB * sideC / 2;
            }

            return sideA * sideC / 2;
        }

        

        public double GetArea()
        {
            var checkParameters = CheckIncomeData();

            if (!checkParameters)
            {
                throw new ArgumentOutOfRangeException("Любой из параметров не может быть отрицательным");
            }

            double perimeter = GetPerimeter()/2;

            if (isTriangleRight())
            {
                return calculateRightTriangleSquare();
            }

            return Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
        }

        public double GetPerimeter()
        {
            var checkParameters = CheckIncomeData();

            if (!checkParameters)
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            }

            return sideA + sideB + sideC;
        }

    }
}