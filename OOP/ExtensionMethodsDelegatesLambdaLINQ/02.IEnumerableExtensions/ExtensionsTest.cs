using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableExtensions
{
    class ExtensionsTest
    {
        static void Main()
        {
            List<int> intTest = new List<int>() { 1, 2, 3, 4, 5, 6};
            Console.WriteLine("List<int> :");
            Console.WriteLine(intTest.ToString<int>());

            int sum = intTest.Sum();
            Console.WriteLine("Sum: {0}", sum);

            int product = intTest.Product();
            Console.WriteLine("Product: {0}", product);

            double average = intTest.Average();
            Console.WriteLine("Average: {0}", average);

            int min = intTest.Min();
            Console.WriteLine("Min: {0}", min);

            int max = intTest.Max();
            Console.WriteLine("Max: {0}", max);
        }
    }
}
