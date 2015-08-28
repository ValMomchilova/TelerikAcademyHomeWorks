namespace ThreeNumbers
{
    using System;
    using System.Collections.Generic;

    public class Numbers
    {
        private List<long> numbers;

        public Numbers(long minAlowedValue = long.MinValue, long maxAlowedValue = long.MaxValue, int numbersCount = 2)
        {
            this.numbers = new List<long>();
            this.MinAlowedValue = minAlowedValue;
            this.MaxAlowedValue = maxAlowedValue;
            this.NumbersCount = numbersCount;
        }        

        public long MinAlowedValue { get; set; }

        public long MaxAlowedValue { get; set; }

        public int NumbersCount { get; set; }

        public void ReadNumbers()
        {
            for (int i = 0; i < this.NumbersCount; i++)
            {
                long number = this.ReadNumber();
                this.numbers.Add(number);
            }
        }

        public void PrintStatistics()
        {
            long max = this.CalculateMax();
            Console.WriteLine(max);

            long min = this.CalculateMin();
            Console.WriteLine(min);

            double average = this.CalculateAverage();
            Console.WriteLine("{0:F2}", average);
        }

        private long CalculateMin()
        {
            long min = long.MaxValue;

            foreach (var number in this.numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }

        private long CalculateMax()
        {
            long max = long.MinValue;

            foreach (var number in this.numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }

        private double CalculateAverage()
        {
            long sum = 0;
            foreach (var number in this.numbers)
            {
                sum += number;
            }

            double average = sum / (double)this.numbers.Count;

            return average;
        }

        private long ReadNumber()
        {
            Console.Write("Enter an integer number between {0} and {1}: ", this.MinAlowedValue, this.MaxAlowedValue);
            long number = 0;
            try
            {
                number = long.Parse(Console.ReadLine());
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Invalid number", e);
            }
            catch (FormatException e) 
            {
                throw new FormatException("Invalid number", e);
            }
            catch (OverflowException e) 
            {
                throw new OverflowException("Invalid number", e);
            }
            catch (Exception e)
            {
                throw new Exception("Invalid number", e);
            }

            if (number <= this.MinAlowedValue || number >= this.MaxAlowedValue)
            {
                throw new Exception(string.Format("Invalid number: number must be in interval between {0} and {1}.", this.MinAlowedValue, this.MaxAlowedValue));
            }

            return number;
        }
    }
}
