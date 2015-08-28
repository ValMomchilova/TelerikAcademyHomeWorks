using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    public struct Point3D
    {
        private static readonly Point3D zeroPoint;
        
        static Point3D()
        {
            zeroPoint = new Point3D(0, 0, 0);
        }
        
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }       

        public static Point3D ZeroPoint
        {
            get 
            {
                return zeroPoint;

            }  
        }
        
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public override string ToString()
        { 
            string result = string.Format("{{{0}, {1}, {2}}}", this.X, this.Y, this.Z);

            return result;
        }
    }
}
