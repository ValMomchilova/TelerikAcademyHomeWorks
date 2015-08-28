using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    class Space3DTest
    {
        static void Main()
        {
            // test point3D
            Point3D point = new Point3D(5.5, 2.1, 100);
            Console.WriteLine("Point3D test:");
            Console.WriteLine(point);
            Console.WriteLine();

            // test zero point
            Console.WriteLine("Zero point test:");
            Console.WriteLine(Point3D.ZeroPoint);
            Console.WriteLine();

            //test calculate the distance 
            Console.WriteLine("Calculate distance tests:");
            Point3D point1 = new Point3D(-7, -4, 3);
            Console.WriteLine("Point1: {0}", point1);
            Point3D point2 = new Point3D(17, 6, 2.5);
            Console.WriteLine("Point2: {0}", point2);
            double distance = Space3D.CalculateDistance(point1, point2);
            Console.WriteLine("Distance between {0}, {1} = {2}", point1, point2, distance);
            Console.WriteLine();
            Point3D point3 = new Point3D(1, 1, 1);
            distance = Space3D.CalculateDistance(Point3D.ZeroPoint, point3);
            Console.WriteLine("Distance between zero point and point {0} = {1}", point3, distance);
            Console.WriteLine();

            // test path
            Console.WriteLine("Test path:");            
            point = new Point3D(1, 2, 3);
            Path path = new Path(point);
            Console.WriteLine("Path is created with statrt point {0}", point);
            point = new Point3D(4, 5, 6);
            path.AddPoint(point);
            Console.WriteLine("Point {0} is added to the path", point);
            Point3D[] points = new Point3D[2];
            points[0] = new Point3D(10, 20, 30);
            points[1] = new Point3D(0.1, 200, 300.5);
            Console.WriteLine("Points {0} and {1} are added to the path", points[0], points[1]);
            path.AddPoints(points);
            Console.WriteLine("Path: ");
            Console.WriteLine(path);
            Console.WriteLine();

            List<Point3D> test = path.Points;
            point = new Point3D(100, 200, 300);
            test[0] = point;
            Console.WriteLine("Path: ");
            Console.WriteLine(path);
            Console.WriteLine();

            // test  PathStorage  
            Console.WriteLine("Test PathStorage:");
            string filePath = @"..\..\PathStorageTest.txt";
            PathStorage.SavePath(path, filePath);
            Console.WriteLine("The path is stored to file {0}", filePath);
            Path pathReaded = PathStorage.LoadPath(filePath);
            Console.WriteLine("The path is readed from file {0}", filePath);
            Console.WriteLine("Path readed from file: ");
            Console.WriteLine(pathReaded);
            path.Clear();
            // test clear path
            Console.WriteLine("The first created path is cleared");            
            Console.WriteLine(path);

        }
    }
}
