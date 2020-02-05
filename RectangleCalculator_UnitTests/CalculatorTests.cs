using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleCalculator;
using System.Collections.Generic;

namespace RectangleCalculator_UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        ICalculator _calc;

        [TestInitialize]
        public void TestInitialize()
        {
            _calc = new Calculator();
        }

        [TestMethod]
        public void CalculateNoOfRectangles_When_Simple_Square_Returns_1()
        {
            // Arrange
            var points = new List<Point>()
            {
                new Point(2,2),
                new Point(2,8),
                new Point(8,8),
                new Point(8,2)
            };

            // Act
            var result = _calc.CalculateNoOfRectangles(points);

            // Assert
            Assert.AreEqual(1, result);
        }

        public void CalculateNoOfRectangles_When_Two_Rectangles_Same_Height_Side_By_Side_Returns_3()
        {
            // Arrange
            var points = new List<Point>()
            {
                new Point(2,2),
                new Point(4,2),
                new Point(7,2),
                new Point(2,8),
                new Point(4,8),
                new Point(7,8)
            };

            // Act
            var result = _calc.CalculateNoOfRectangles(points);

            // Assert
            Assert.AreEqual(3, result);
        }

        public void CalculateNoOfRectangles_When_Two_Rectangles_Different_Heights_Side_By_Side_Returns_2()
        {
            // Arrange
            var points = new List<Point>()
            {
                new Point(2,2),
                new Point(4,2),
                new Point(7,2),
                new Point(2,8),
                new Point(4,8),
                new Point(4,6),
                new Point(7,6)
            };

            // Act
            var result = _calc.CalculateNoOfRectangles(points);

            // Assert
            Assert.AreEqual(2, result);
        }

        public void CalculateNoOfRectangles_When_Four_Rectangles_Same_Height_Arranged_2x2_Returns_9()
        {
            // Arrange
            var points = new List<Point>()
            {
                new Point(2,2),
                new Point(4,2),
                new Point(7,2),
                new Point(2,6),
                new Point(4,6),
                new Point(7,6),
                new Point(2,8),
                new Point(4,8),
                new Point(7,8)
            };

            // Act
            var result = _calc.CalculateNoOfRectangles(points);

            // Assert
            Assert.AreEqual(9, result);
        }

        public void CalculateNoOfRectangles_When_Square_With_Central_Inner_Square_Returns_2()
        {
            // Arrange
            var points = new List<Point>()
            {
                // Outer
                new Point(2,2),
                new Point(8,2),
                new Point(2,8),
                new Point(8,8),

                // Inner
                new Point(4,4),
                new Point(6,4),
                new Point(4,6),
                new Point(6,6)
            };

            // Act
            var result = _calc.CalculateNoOfRectangles(points);

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
