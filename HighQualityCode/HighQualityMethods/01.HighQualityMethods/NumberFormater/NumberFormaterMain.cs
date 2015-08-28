namespace NumberFormater
{
    using System;

    public class NumberFormaterMain
    {
        public static void Main()
        {
            NumberPrinter numberPinter = new NumberPrinter();
            numberPinter.PrintAsNumber(1.3, new FixedPointFormater());
            numberPinter.PrintAsNumber(0.75, new PercentFormater());
            numberPinter.PrintAsNumber(2.30, new RightAlignFormater(8));
        }
    }
}
