namespace AreaCalculator
{
    using System;

    public class AreaCalculatorMain
    {
        public static void Main()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            AreaCalculator areaCalculator = new AreaCalculator(triangle);
            double triangleArea = areaCalculator.CalcArea();
            Console.WriteLine(triangleArea);
        }
    }
}
