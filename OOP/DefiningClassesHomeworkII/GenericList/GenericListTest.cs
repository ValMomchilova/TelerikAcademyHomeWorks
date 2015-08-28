using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericListTest
    {
        static void Main(string[] args)
        {
            // test GenericList<int>
            Console.WriteLine("Test GenericList:");
            Console.WriteLine();
            Console.WriteLine("Test GenericList<int>:");
            Console.WriteLine();
            GenericList<int> listInt = new GenericList<int>(3);
            Console.WriteLine("GenericList<int> is created." );

            for (int i = 0; i < 5; i++)
            {
                listInt.Add(i);          
            }

            Console.WriteLine("GenericList<int> is filled wih test values.");
            Console.WriteLine("GenericList:");
            Console.WriteLine(listInt);
            Console.WriteLine();

            for (int i = 0; i < listInt.Count; i++)
            {
                listInt[i] = listInt[i] + 1;
            }

            Console.WriteLine("GenericList<int> values are increased with 1.");
            Console.WriteLine("GenericList:");
            Console.WriteLine(listInt);
            Console.WriteLine();

            int value = 100;
            listInt.AddAt(value, 2);
            Console.WriteLine("A new item is added at 2nd position");
            Console.WriteLine("GenericList:");
            Console.WriteLine(listInt);
            Console.WriteLine();

            //test min and max
            Console.WriteLine("Max value = {0}", listInt.Max());
            Console.WriteLine("Min value = {0}", listInt.Min());
            Console.WriteLine();

            int index = listInt.IndexOf(value);
            Console.WriteLine("Index of value {0} is {1}", value, index);
            Console.WriteLine();

            listInt.RemoveAt(2);
            Console.WriteLine("An item is removed from 2nd position");
            Console.WriteLine("GenericList:");
            Console.WriteLine(listInt);
            Console.WriteLine();

            listInt.Clear();
            Console.WriteLine("GenericList<int> is cleared");
            Console.WriteLine("GenericList:");
            Console.WriteLine(listInt);
            Console.WriteLine();

            // test GenericList<string>
            Console.WriteLine("Test GenericList<string>:");
            Console.WriteLine();
            GenericList<string> listStr = new GenericList<string>(2);
            Console.WriteLine("GenericList<string> is created.");

            listStr.Add("C#");
            listStr.Add("OOP");

            Console.WriteLine("GenericList<string> is filled wih test values.");
            Console.WriteLine("GenericList:");
            Console.WriteLine(listStr);
            Console.WriteLine();

            listStr[0] = listStr[0] + " I";
            Console.WriteLine("GenericList<string> 1st value was changed.");
            Console.WriteLine("GenericList:");
            Console.WriteLine(listStr);
            Console.WriteLine();

            string text = "C# II";
            listStr.AddAt(text, 1);
            Console.WriteLine("A new item is added at 1st position");
            Console.WriteLine("GenericList:");
            Console.WriteLine(listStr);
            Console.WriteLine();

            index = listStr.IndexOf(text);
            Console.WriteLine("Index of value \"{0}\" is {1}", text, index);
            Console.WriteLine();

            //test min and max
            Console.WriteLine("Max value = {0}", listStr.Max());
            Console.WriteLine("Min value = {0}", listStr.Min());
            Console.WriteLine();

            listStr.RemoveAt(1);
            Console.WriteLine("An item is removed from 1nd position");
            Console.WriteLine("GenericList:");
            Console.WriteLine(listStr);
            Console.WriteLine();

            listStr.Clear();
            Console.WriteLine("GenericList<string> is cleared");
            Console.WriteLine("GenericList:");
            Console.WriteLine(listStr);
            Console.WriteLine();

            //test GenericList<Tuple<int, int>>
            Console.WriteLine("Test GenericList<Tuple<int, int>>:");
            Console.WriteLine();
            GenericList<Tuple<int, int>> listTuple = new GenericList<Tuple<int, int>>(1);
            Tuple<int, int> tuple = new Tuple<int, int>(1, 2);
            listTuple.Add(tuple);           
            tuple = new Tuple<int, int>(3, 4);
            listTuple.Add(tuple);

            Console.WriteLine("GenericList:");
            Console.WriteLine(listTuple);
            Console.WriteLine();

            //test min and max
            Console.WriteLine("Max value = {0}", listTuple.Max());
            Console.WriteLine("Min value = {0}", listTuple.Min());
            Console.WriteLine();
        }
    }
}
