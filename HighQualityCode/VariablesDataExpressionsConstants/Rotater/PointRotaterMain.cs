namespace Rotater
{
    using System;

    /// <summary>
    /// Main class. Processes a point rotation.
    /// </summary>
    public class PointRotaterMain
    {
        /// <summary>
        /// Main method. Entry point of the application
        /// </summary>
        public static void Main()
        {
            double x = 10;
            double y = 20;
            Point point = new Point(x, y);
            Console.WriteLine("Point x = {0} y = {1}", point.X, point.Y);

            Rotater rotater = new Rotater();
            double rotationAngle = 90;
            Console.WriteLine("Rotation Angle = {0}", rotationAngle);
            Point rotatedPoint = rotater.RotatePoint(point, rotationAngle);
            Console.WriteLine("Rotated Point x = {0} y = {1}", rotatedPoint.X, rotatedPoint.Y);
        }       
    }
}
