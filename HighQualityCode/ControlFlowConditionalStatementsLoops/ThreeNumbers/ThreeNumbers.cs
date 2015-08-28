namespace ThreeNumbers
{
    using System;

    public class ThreeNUmbers
    {
        public static void Main()
        {
            Numbers numbers = new Numbers(-200000000, 200000000, 3);
            numbers.ReadNumbers();
            numbers.PrintStatistics();
        }
    }
}
