﻿namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {        
        public Figure()
        {
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        public override string ToString()
        {
            string info = string.Format(
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                this.CalcPerimeter(),
                this.CalcSurface());

            return info;
        }
    }
}
