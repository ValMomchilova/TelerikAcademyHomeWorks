using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace DivisibleBy7And3
{
    class DivisibleBy7And3
    {
        static void Main()
        {
            Console.WriteLine("Array of integers:");
            int[] numbers = new int[] { 1, 63, 2, 3, 7, 21 };
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            Console.WriteLine("All numbers that are divisible by 7 and 3:");
            var divisibleNumbers = numbers.Where(number => number % 3 == 0 && number % 7 == 0);
            Console.WriteLine(string.Join(", ", divisibleNumbers.ToArray()));
            Console.WriteLine();

            Console.WriteLine("All numbers that are divisible by 7 and 3 (LINQ):");
            var divisibleNumbersLINQ = from number in numbers
                                       where number % 3 == 0 && number % 7 == 0
                                       select number;
            Console.WriteLine(string.Join(", ", divisibleNumbersLINQ.ToArray()));


        }
    }
}
