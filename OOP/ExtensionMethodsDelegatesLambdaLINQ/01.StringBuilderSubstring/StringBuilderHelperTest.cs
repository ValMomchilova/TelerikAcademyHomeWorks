using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderHelper
{
    class StringBuilderHelperTest
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder test0 = sb.Substring(0, 0);

            sb.Append("It's a spring out there!");
            Console.WriteLine("Source string builder: {0}", sb);
            Console.WriteLine();

            StringBuilder sbPart = sb.Substring(7, 6);
            Console.WriteLine("sb.Substring(7, 6) is processed.");
            Console.WriteLine("Result string builder: {0}", sbPart);
            Console.WriteLine();

            sbPart = sb.Substring(0, 1);
            Console.WriteLine("sb.Substring(0, 1) is processed.");
            Console.WriteLine("Result string builder: {0}", sbPart);
            Console.WriteLine();

            sbPart = sb.Substring(0, sb.Length);
            Console.WriteLine("sb.Substring(0, sb.Length) is processed.");
            Console.WriteLine("Result string builder: {0}", sbPart);
            Console.WriteLine();

            sbPart = sb.Substring(1, sb.Length - 1);
            Console.WriteLine("sb.Substring(1, sb.Length - 1) is processed.");
            Console.WriteLine("Result string builder: {0}", sbPart);
            Console.WriteLine();

        }
    }
}
