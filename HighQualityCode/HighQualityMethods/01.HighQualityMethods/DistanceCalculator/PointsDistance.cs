namespace DistanceCalculator
{
    using System;

    public class PointsDistance
    {
        public PointsDistance(Point point1, Point point2)
        {
            this.Point1 = point1;
            this.Point2 = point2;
        }

        public Point Point1 { get; set; }

        public Point Point2 { get; set; }

        public bool IsHorizontal
        {
            get 
            {
                bool isHorizontal = this.Point1.Y == this.Point2.Y;
                return isHorizontal;
            }           
        }

        public bool IsVertical
        {
            get
            {
                bool isVertical = this.Point1.X == this.Point2.X;
                return isVertical;
            }
        }        

        public double CalcDistance()
        {
            double xDifference = this.Point2.X - this.Point1.X;
            double xDifferencePow = Math.Pow(xDifference, 2);
            double yDifference = this.Point2.Y - this.Point1.Y;
            double yDifferencePow = Math.Pow(yDifference, 2);
            double powDifferencesSum = xDifferencePow + yDifferencePow;
            double distance = Math.Sqrt(powDifferencesSum);

            return distance;
        }
    }
}
