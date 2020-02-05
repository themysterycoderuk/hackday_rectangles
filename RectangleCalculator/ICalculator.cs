using System.Collections.Generic;

namespace RectangleCalculator
{
    public interface ICalculator
    {
        int CalculateNoOfRectangles(IList<Point> points);
    }
}
