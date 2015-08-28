using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square: Rectangle 
    {
        public Square(double widht)
            : base(widht, widht)
        {
        }

        public override string ToString()
        {
            return string.Format("{0}: Width = {1} ", this.GetType().Name, Width);
        }
    }
}
