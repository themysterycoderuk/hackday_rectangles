using RectangleCalculator;
using System;
using System.Collections.Generic;

namespace RecatnagleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calc = new Calculator();
            var points = getExamplePoints();
            var noOfRectangles = calc.CalculateNoOfRectangles(points);

            Console.WriteLine($"Number of rectangles = {noOfRectangles}");
            Console.ReadKey();
        }

        private static IList<Point> getExamplePoints()
        {
            return new List<Point>()
             {
                 new Point(2,2),
                 new Point(6,2),
                 new Point(2,4),
                 new Point(4,6),
                 new Point(2,6),
                 new Point(6,6),
                 new Point(4,2),
                 new Point(6,4)
             };
        }
    }
}
