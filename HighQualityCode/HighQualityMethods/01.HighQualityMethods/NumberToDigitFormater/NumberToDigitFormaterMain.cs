namespace NumberToDigitFormater
{
    using System;

    public class NumberToDigitFormaterMain
    {
        public static void Main()
        {
            NumberToDigitFormater numberToDigitsFromater = new NumberToDigitFormater();
            string digit = numberToDigitsFromater.NumberToDigit(5);
            Console.WriteLine(digit);
        }
    }
}
