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
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual, "Method is incorrect");
        }
    }
}
