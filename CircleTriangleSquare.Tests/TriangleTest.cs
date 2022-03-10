using System;
using NUnit.Framework;

namespace CircleTriangleSquare.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void TriangleAreaTestMethod()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.CalculateArea();

            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [Test]
        public void TriangleAreaWithBelowZeroParameters()
        {
            double a = -3;
            double b = -4;
            double c = -5;

            Triangle triangle = new Triangle(a, b, c);

            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.CalculateArea());
        }
    }
}
