namespace AreaCalculator
{
    using System;

    public class Triangle : IAreaCalculatable
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double SideA
        {
            get
            {
                return this.sideA;
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("sideA shluld be greater than 0");
                }

                this.sideA = value; 
            }
        }

        public double SideB
        {
            get 
            {
                return this.sideB;
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("SideB shluld be greater than 0");
                }

                this.sideB = value; 
            }
        }

        public double SideC
        {
            get
            {
                return this.sideC;
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("SideC shluld be greater than 0");
                }

                this.sideC = value; 
            }
        }

        public double CalcArea()
        {
            double halfPerimeter = (this.SideA + this.SideB + this.SideC) / 2;
            double area = Math.Sqrt(
                halfPerimeter * (halfPerimeter - this.SideA) * (halfPerimeter - this.SideB) * (halfPerimeter - this.SideC));

            return area;
        }
    }
}
