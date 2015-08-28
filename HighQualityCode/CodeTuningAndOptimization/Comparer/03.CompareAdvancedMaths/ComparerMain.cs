namespace CompareAdvancedMaths
{
    using System;

    public class ComparerMain
    {
        public static void Main()
        {
            Comparer comparer = new Comparer();

            Console.WriteLine("SQUARE ROOT");
            comparer.TestSqrtFloat();
            comparer.TestSqrtDouble();
            comparer.TestSqrtDecimal();

            Console.WriteLine("NATURAL LOGARITHM");
            comparer.TestLogFloat();
            comparer.TestLogDouble();
            comparer.TestLogDecimal();

            Console.WriteLine("SINUS");
            comparer.TestSinFloat();
            comparer.TestSinDouble();
            comparer.TestSinDecimal();
        }
    }
}
