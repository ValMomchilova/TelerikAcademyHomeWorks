namespace CohesionAndCoupling
{
    using System;

    public static class Geometry
    {
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double xDifference = x2 - x1;
            double xDifferencePow = xDifference * xDifference;

            double yDifference = y2 - y1;
            double yDifferencePow = yDifference * yDifference;

            double distance = Math.Sqrt(xDifferencePow + yDifferencePow);
           
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {            
            double xDifference = x2 - x1;
            double xDifferencePow = xDifference * xDifference;

            double yDifference = y2 - y1;
            double yDifferencePow = yDifference * yDifference;

            double zDifference = z2 - z1;
            double zDifferencePow = zDifference * zDifference; 
           
            double distance = Math.Sqrt(xDifferencePow + yDifferencePow + zDifferencePow);

            return distance;
        }
    }
}
