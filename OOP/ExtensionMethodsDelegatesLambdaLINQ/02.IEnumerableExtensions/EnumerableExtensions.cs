using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//Implement a set of extension methods for  IEnumerable<T>  
//that implement the following group functions: sum, product, min, max, average.

namespace EnumerableExtensions
{
    public static class EnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)           
        {
            T result = (dynamic)0;           

            foreach (var item in collection)
            {
                result = result + (dynamic)item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            T result = (dynamic)1;

            foreach (var item in collection)
            {
                result = result * (dynamic)item;
            }

            return result;
        }

        public static double Average<T>(this IEnumerable<T> collection)
        {
            double sum = 0;

            long count = 0;

            foreach (var item in collection)
            {
                sum = sum + (dynamic)item;
                count++;
            }

            double result = sum / count;

            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection)
           where T : IComparable, IComparable<T>
        {
            
            var enumerator = collection.GetEnumerator();
            enumerator.MoveNext();
            T minItem = enumerator.Current;

            foreach (var item in collection)
            {
                if (minItem.CompareTo(item) > 0)
                {
                    minItem = item;
                }
            }

            return minItem;
        }

        public static T Max<T>(this IEnumerable<T> collection)
          where T : IComparable, IComparable<T>
        {

            var enumerator = collection.GetEnumerator();
            enumerator.MoveNext();
            T maxItem = enumerator.Current;

            foreach (var item in collection)
            {
                if (maxItem.CompareTo(item) < 0)
                {
                    maxItem = item;
                }
            }

            return maxItem;
        }

        public static string ToString<T>(this IEnumerable<T> collection)
        {
            StringBuilder sb = new StringBuilder();
            string separator =  ", ";

            foreach (var item in collection)
            {
                sb.Append(item);
                sb.Append(separator);
            }

            sb.Remove(sb.Length - separator.Length, separator.Length);

            return sb.ToString();
        }
    }
}
