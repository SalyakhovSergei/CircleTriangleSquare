using System;
using NUnit.Framework;

namespace CircleTriangleSquare.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CircleAreaTestMethod()
        {
            double r = 3;
            double expected = 28.274333882308138;

            Circle circle = new Circle(r);
            double actual = circle.CalculateArea();

            Assert.AreEqual(expected, actual, "Method is incorrect");
            
        }

        [Test]
        public void CircleAreaWithBelowZeroParameters()
        {
            double r = -3;
            
            Circle circle = new Circle(r);

            Assert.Throws<ArgumentOutOfRangeException>(() => circle.CalculateArea());
        }
    }
}