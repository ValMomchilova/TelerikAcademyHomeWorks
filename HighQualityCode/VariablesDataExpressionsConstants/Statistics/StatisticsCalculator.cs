namespace Statistics
{
    using System;

    /// <summary>
    /// Provide statistical indicators calculations
    /// </summary>
    public class StatisticsCalculator
    {
        /// <summary>
        /// Calculates statistical indicators
        /// </summary>
        /// <param name="statisticalData">Defines statistical data</param>
        /// <param name="countOfRecordsToBeProcessed">Defines count of records to be processed</param>
        /// <returns>Calculated statistical indicators</returns>
        public Statistics CalculateStatistics(double[] statisticalData, int countOfRecordsToBeProcessed)
        {
            double max = this.CalculateMax(statisticalData, countOfRecordsToBeProcessed);
            double min = this.CalculateMin(statisticalData, countOfRecordsToBeProcessed);
            double average = this.CalculateAverage(statisticalData, countOfRecordsToBeProcessed);

            Statistics statistics = new Statistics(max, min, average);

            return statistics;
        }

        /// <summary>
        /// Calculates "maximum" statistical indicator value
        /// </summary>
        /// <param name="statisticalData">Defines statistical data</param>
        /// <param name="countOfRecordsToBeProcessed">Defines count of records to be processed</param>
        /// <returns>The calculated "maximum" statistical indicator value</returns>
        private double CalculateMax(double[] statisticalData, int countOfRecordsToBeProcessed)
        {
            double max;
            max = double.MinValue;

            for (int i = 0; i < countOfRecordsToBeProcessed; i++)
            {
                if (statisticalData[i] > max)
                {
                    max = statisticalData[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Calculates "minimum" statistical indicator value
        /// </summary>
        /// <param name="statisticalData">Defines statistical data</param>
        /// <param name="countOfRecordsToBeProcessed">Defines count of records to be processed</param>
        /// <returns>The calculated "minimum" statistical indicator value</returns>
        private double CalculateMin(double[] statisticalData, int countOfRecordsToBeProcessed)
        {
            double min;
            min = double.MaxValue;

            for (int i = 0; i < countOfRecordsToBeProcessed; i++)
            {
                if (statisticalData[i] < min)
                {
                    min = statisticalData[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Calculates "average" statistical indicator value
        /// </summary>
        /// <param name="statisticalData">Defines statistical data</param>
        /// <param name="countOfRecordsToBeProcessed">Defines count of records to be processed</param>
        /// <returns>The calculated "average" statistical indicator value</returns>
        private double CalculateAverage(double[] statisticalData, int countOfRecordsToBeProcessed)
        {
            double sum;
            sum = 0;

            for (int i = 0; i < countOfRecordsToBeProcessed; i++)
            {
                sum += statisticalData[i];
            }

            double average = sum / countOfRecordsToBeProcessed;

            return average;
        }
    }
}
