namespace PrintTools
{
    using System;

    public class ConsolePrinter : IPrinter       
    {
        public void Print(object printableObject)
        {
            Console.WriteLine(printableObject);
        }
    }
}
