using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            points = new List<Point3D>();
        }

        public Path(IEnumerable<Point3D> points)
            : this()
        {
            this.points.AddRange(points);
        }

        public Path(Point3D startPoint)
            : this()
        {
            this.points.Add(startPoint);
        }

        public List<Point3D> Points
        {
            get
            {
                return new List<Point3D> (this.points);
            }
        }

        public void AddPoints(IEnumerable<Point3D> points)
        {
            this.points.AddRange(points);
        }
        
        public void AddPoint(Point3D point)
        {
            points.Add(point);
        }

        public void DeletePoint(Point3D point)
        {
            points.Remove(point);
        }

        public void Clear()
        {
            this.points.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Points.Count; i++)
            {
                sb.Append(Points[i]);
                if (i < this.Points.Count - 1)
                {
                    sb.Append('\r');
                    sb.Append('\n');
                }
            }

            string result = sb.ToString();

            return result;
        }

    }
}
