namespace MaxFinder
{
    using System;

    public class MaxFinderMain
    {
        public static void Main()
        {
            int max = MaxFinder.FindMax(5, -1, 3, 2, 14, 2, 3);
            Console.WriteLine(max);
        }
    }
}
