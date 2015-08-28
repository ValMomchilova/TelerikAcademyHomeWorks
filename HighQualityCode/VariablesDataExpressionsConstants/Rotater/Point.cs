namespace Rotater
{
    using System;

    /// <summary>
    /// Defines point in a two dimensional coordinate system
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point" /> class. Defines point in the two dimensional coordinate system
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or sets x position
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets y position
        /// </summary>
        public double Y { get; set; }
    }
}
