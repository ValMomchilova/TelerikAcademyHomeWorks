namespace Statistics
{
    using System;

    /// <summary>
    /// Statistics main.
    /// </summary>
    public class StatisticsMain
    {
        /// <summary>
        /// Main method. Entry point of the application
        /// </summary>
        public static void Main()
        {
            // generate test statistical data
            int dataCount = 10;
            double[] statisticalData = new double[dataCount];

            for (int i = 0; i < statisticalData.Length; i++)
            {
                statisticalData[i] = i + 1;
            }

            // calcualte statistical data
            StatisticsCalculator statisticsCalculator = new StatisticsCalculator();
            int countOfRecordsToBeProcessed = 6;
            Statistics statistics = statisticsCalculator.CalculateStatistics(statisticalData, countOfRecordsToBeProcessed);

            // print statistical data
            StatisticsPrinter statisticsPrinter = new StatisticsPrinter();
            statisticsPrinter.Print(statistics);
        }
    }
}
