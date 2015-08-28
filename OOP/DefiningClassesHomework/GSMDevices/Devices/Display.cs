using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMDevices
{
    public class Display
    {
        //size 
        //number of colors
        //All unknown data fill with null. (developer note: So nullable types are used)

        private double size;
        private int? colorsNumber;

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, int? colorsNumber)
            : this(size)
        {
            this.ColorsNumber = colorsNumber;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display size cannot be less or equal to zero.");
                }
                this.size = value;
            }
        }

        public int? ColorsNumber
        {
            get
            {
                return this.colorsNumber;
            }
            set
            {
                if (value != null && value <= 0)
                {
                    throw new ArgumentException("Colors number cannot be less or equal to zero.");
                }
                this.colorsNumber = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("Display information: \n  Size: {0} \n  Number  of colors: {1}",
                                            this.Size, this.DisplayColorsToString(this.ColorsNumber));

            return result;
        }

        private string DisplayColorsToString(int? colorsNumber)
        {
            string result = string.Empty;
            int oneMb = 1024;

            if (colorsNumber == null)
            {
                return result;
            }

            string measure = "K";
            int? numbers = colorsNumber;

            if (numbers >= oneMb)
            {
                measure = "M";
                numbers /= oneMb;
            }

            result = string.Format("{0} {1}", numbers, measure);


            return result;
        }
    }
}
