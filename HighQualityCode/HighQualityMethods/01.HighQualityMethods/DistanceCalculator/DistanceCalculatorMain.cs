namespace DistanceCalculator
{
    using System;

    public class DistanceCalculatorMain
    {
        public static void Main()
        {
            Point point1 = new Point(3, -1);
            Point point2 = new Point(3, 2.5);
            PointsDistance pointsDistance = new PointsDistance(point1, point2);

            double distance = pointsDistance.CalcDistance();

            Console.WriteLine(distance);
            Console.WriteLine("Horizontal? " + pointsDistance.IsHorizontal);
            Console.WriteLine("Vertical? " + pointsDistance.IsVertical);
        }
    }
}
