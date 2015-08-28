namespace Statistics
{
    using System;

    /// <summary>
    /// Defines statistical indicators.
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Statistics" /> class.
        /// </summary>
        /// <param name="max">Defines "maximum" statistical indicator value</param>
        /// <param name="min">Defines "minimum" statistical indicator value</param>
        /// <param name="average">Defines "average" statistical indicator value</param>
        public Statistics(double max = 0, double min = 0, double average = 0)
        {
            this.Max = max;
            this.Min = min;
            this.Average = average;
        }

        /// <summary>
        /// Gets or sets "maximum" indicator value
        /// </summary>
        public double Max { get; set; }

        /// <summary>
        /// Gets or sets "minimum" indicator value
        /// </summary>
        public double Min { get; set; }

        /// <summary>
        /// Gets or sets "average" indicator value
        /// </summary>
        public double Average { get; set; }
    }
}
