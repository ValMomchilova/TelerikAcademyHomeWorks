namespace Statistics
{
    using System;

    /// <summary>
    /// Provide statistics print
    /// </summary>
    public class StatisticsPrinter
    {
        /// <summary>
        /// Prints statistics
        /// </summary>
        /// <param name="statistics">Defines statistics to be printed</param>
        public void Print(Statistics statistics)
        {
            this.PrintMax(statistics.Max);
            this.PrintMin(statistics.Min);
            this.PrintAverage(statistics.Average);
        }

        /// <summary>
        /// Prints "maximum" statistical indicator value
        /// </summary>
        /// <param name="max">Defines "maximum" statistical indicator value</param>
        private void PrintMax(double max)
        {
            Console.WriteLine(StatisticsText.MaxText, max);
        }

        /// <summary>
        /// Prints "minimum" statistical indicator value
        /// </summary>
        /// <param name="min">Defines "minimum" statistical indicator value</param>
        private void PrintMin(double min)
        {
            Console.WriteLine(StatisticsText.MinText, min);
        }

        /// <summary>
        /// Prints "average" statistical indicator value
        /// </summary>
        /// <param name="average">Defines "average" statistical indicator value</param>
        private void PrintAverage(double average)
        {
            Console.WriteLine(StatisticsText.AverageText, average);
        }
    }
}
