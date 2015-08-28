namespace MaxFinder
{
    using System;

    public class MaxFinder
    {
        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("elements");
            }

            if (elements.Length == 0)
            {
                throw new ArithmeticException("elements.Length must be more that zero.");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }
    }
}
