using System;

namespace CircleTriangleSquare
{
    public class Circle: IFigureInfo
    {
        public double _radius { get; set; }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public bool CheckIncomeData()
        {
            return _radius > 0;
        }

        public double CalculateArea()
        {
            var checkRadius = CheckIncomeData();
            if (!checkRadius)
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            }

            return Math.PI * Math.Pow(_radius, 2);
        }

        public double CalculatePerimeter()
        {
            var checkRadius = CheckIncomeData();
            if (!checkRadius)
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            }

            return 2 * Math.PI * _radius;
        }
    }
}
