namespace CompareSimpleMaths
{
    using System;

    public class ComparerMain
    {
        public static void Main()
        {
            Comparer comparer = new Comparer();

            Console.WriteLine("ADDITION");
            comparer.TestAdditionInt();
            comparer.TestAdditionLong();
            comparer.TestAdditionFloat();
            comparer.TestAdditionDouble();
            comparer.TestAdditionDecimal();

            Console.WriteLine("SUBSTRACT");
            comparer.TestSubstractInt();
            comparer.TestSubstractLong();
            comparer.TestSubstractFloat();
            comparer.TestSubstractDouble();
            comparer.TestSubstractDecimal();

            Console.WriteLine("INCREMENT");
            comparer.TestIncrementInt();
            comparer.TestIncrementLong();
            comparer.TestIncrementFloat();
            comparer.TestIncrementDouble();
            comparer.TestIncrementDecimal();

            Console.WriteLine("MULTIPLY");
            comparer.TestMultiplyInt();
            comparer.TestMultiplyLong();
            comparer.TestMultiplyFloat();
            comparer.TestMultiplyDouble();
            comparer.TestMultiplyDecimal();

            Console.WriteLine("DIVIDE");
            comparer.TestDivideInt();
            comparer.TestDivideLong();
            comparer.TestDivideFloat();
            comparer.TestDivideDouble();
            comparer.TestDivideDecimal();
        }
    }
}
