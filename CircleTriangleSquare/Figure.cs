using System;

namespace CircleTriangleSquare
{
    public abstract class Figure
    {
        private double Area { get; set; }

        public virtual double GetArea()
        {
            return Area;
        }

        public virtual double GetPerimeter()
        {
            return Area;
        }

    }


}