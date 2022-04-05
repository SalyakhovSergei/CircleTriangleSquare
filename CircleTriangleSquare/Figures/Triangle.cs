using System;

namespace CircleTriangleSquare
{
    public class Triangle: IFigureInfo
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        
        public double SideA 
        { 
            get => _sideA;
            init => _sideA = value;
        }
        public double SideB 
        { 
            get => _sideB;
            init => _sideB = value;
        }
        public double SideC 
        { 
            get => _sideC;
            init => _sideC = value;
        }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        private bool IsTriangleRight()
        {
            double sideAPow2 = Math.Pow(_sideA, 2);
            double sideBPow2 = Math.Pow(_sideB, 2);
            double sideCPow2 = Math.Pow(_sideC, 2);

            return (sideAPow2 + sideBPow2) == sideCPow2 ||
                   (sideAPow2 + sideCPow2) == sideBPow2 ||
                   (sideBPow2 + sideCPow2) == sideAPow2;
        }

        public bool CheckIncomeData()
        {
            return SideA > 0 & SideB > 0 & SideC > 0;
        }

        public double CalculateRightTriangleSquare()
        {
            double square = 0;
            
            if (SideA == SideB && IsTriangleRight())
            {
                square = SideA * SideB / 2;
            }
            if (SideB == SideC && IsTriangleRight())
            {
                square = SideB * SideC / 2;
            }
            if (SideA == SideC && IsTriangleRight())
            {
                square = SideB * SideC / 2;
            }

            return square;
        }

        public double CalculateArea()
        {
            if (!CheckIncomeData())
            {
                throw new ArgumentOutOfRangeException("Любой из параметров не может быть отрицательным");
            }
          
            if (IsTriangleRight())
            {
                return CalculateRightTriangleSquare();
            }
            
            double perimeter = CalculatePerimeter()/2;

            var area = Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));

            return area;
        }

        public double CalculatePerimeter()
        {
            if (!CheckIncomeData())
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            }

            return SideA + SideB + SideC;
        }

    }
}