namespace Abstraction
{
    using System;

    public class Rectangle : Figure, IFigure, IRectangle
    {
        private double width;

        private double height;

        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("width must be positive value");
                }

                this.width = value; 
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("height must be positive value");
                }

                this.height = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }

        public override string ToString()
        {
            string info = string.Format("I am a rectangle. {0}", base.ToString());
            return info;
        }
    }
}
