using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define abstract class  Shape  with only one  abstract  method  CalculateSurface()  and fields  width  and  height .
//• Define two new classes  Triangle  and  Rectangle  that implement the  virtual  method and return the surface of the figure 
//    (height * width for rectangle and height * width/2 for triangle).
//• Define class  Square  and suitable constructor so that at initialization  height  must be kept equal to  width  
//    and implement the  CalculateSurface()  method.
//• Write a program that tests the behaviour of the  CalculateSurface()  method for different shapes ( Square ,  Rectangle ,  Triangle )
//    stored in an array.


namespace Shapes
{
    class ShapesTest
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
                                {
                                    new Rectangle(4, 2),
                                    new Triangle(4, 2),
                                    new Square(2),
                                    new Rectangle(1.5, 2.5)
                                };

            foreach (var item in shapes)
            {
                Console.WriteLine(item);
                Console.WriteLine("Surface: {0}", item.CalculateSurface());
            }
        }
    }
}
