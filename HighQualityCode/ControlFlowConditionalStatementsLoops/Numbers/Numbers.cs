namespace Numbers
{
    using System;

    public class Numbers
    {
        public static void Main()
        {
            // prepare test data
            int count = 100;

            int[] numbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            int expectedValue = 60;

            // look for expectedValue
            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                if (i % 10 == 0)
                {
                    if (numbers[i] == expectedValue)
                    {
                        isFound = true;
                    }
                }
            }

            //// More code here

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
