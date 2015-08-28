using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    public class PathStorage
    {
        public static void SavePath(Path path3D, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.Write(path3D);
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                int lineNumber = 0;
                while (!sr.EndOfStream)
                {
                    lineNumber++;
                    string currentText = sr.ReadLine();
                    string[] coordinatesStr = currentText.Split(new char[] { ' ', '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    double[] coordinates = new double[1]; 

                    try
                    {
                        coordinates = coordinatesStr.Select(x => double.Parse(x)).ToArray();
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException("Invalid file format", ex);
                    }

                    if (coordinates.Length != 3)
                    {
                        throw new ArgumentException(
                            string.Format("Invalid file format. There are expected coordinates in three directions. Line number: {0}", lineNumber)
                            );

                    }

                    Point3D point = new Point3D(coordinates[0], coordinates[1], coordinates[2]);
                    path.AddPoint(point);
                }
            }

            return path;
        }
    }
}
