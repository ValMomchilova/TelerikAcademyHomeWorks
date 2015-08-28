namespace NumberFormater
{
    using System;

    public class NumberPrinter
    {
       public void PrintAsNumber(object number, INumberFormater formater)
        {
            string textToPrint = formater.FormatNumber(number);
            Console.WriteLine(textToPrint);
        }
    }
}
