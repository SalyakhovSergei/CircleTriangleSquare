using System;

namespace CircleTriangleSquare
{
    public class Circle: Figure
    {
        public double _radius { get; set; }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);

        }
    }
}
