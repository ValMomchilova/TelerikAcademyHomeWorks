namespace AreaCalculator
{
    using System;

    public class AreaCalculator
    {
        private IAreaCalculatable figure;

        public AreaCalculator(IAreaCalculatable figure)
        {
            this.figure = figure;
        }

        public double CalcArea()
        {
            double area = this.figure.CalcArea();

            return area;
        }
    }
}
