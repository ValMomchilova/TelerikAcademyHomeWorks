namespace Rotater
{
    using System;

    /// <summary>
    /// Provides rotation methods
    /// </summary>
    public class Rotater
    {
        /// <summary>
        /// Rotates a point in the two dimensional coordinate system. The center of rotation is fixed - the zero point.
        /// </summary>
        /// <param name="point">Defines point in the two dimensional coordinate system</param>
        /// <param name="rotationAngleDegree">Defines angle of rotation in degree</param>
        /// <returns>Rotated point in the two dimensional coordinate system</returns>
        public Point RotatePoint(Point point, double rotationAngleDegree)
        {
            double rotationAngleRadians = (rotationAngleDegree * Math.PI) / 180;
            double absAngleCos = Math.Abs(Math.Cos(rotationAngleRadians));

            double absAngleSin = Math.Abs(Math.Sin(rotationAngleRadians));           

            double newX = (absAngleSin * point.X) +
                (absAngleCos * point.Y);

            double newY = (absAngleCos * point.X) -
              (absAngleSin * point.Y);

            Point rotatedPoint = new Point(newX, newY);

            return rotatedPoint;
        }
    }
}
