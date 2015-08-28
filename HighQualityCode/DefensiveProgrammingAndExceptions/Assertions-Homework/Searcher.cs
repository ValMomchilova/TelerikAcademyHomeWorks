namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;
    using System.Linq;  

    public class Searcher
    {
        public int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            int foundIndex = -1;

            Debug.Assert(arr != null, "Array can not be null");

            Debug.Assert(arr.Length > 0, "Array lenght must be greater than zero");

            foundIndex = this.BinarySearch(arr, value, 0, arr.Length - 1);

            if (foundIndex == -1)
            {
                Debug.Assert(!arr.Contains(value), "There is the searchead value in the array, but is returned -1.");
            }
            else
            {
                Debug.Assert(arr[foundIndex].CompareTo(value) == 0, "The value at the returned position is not eaqual to the searched value.");
            }

            return foundIndex;
        }

        private int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array can not be null");

            Debug.Assert(arr.Length > 0, "Array lenght must be greater than zero");

            Debug.Assert(startIndex >= 0, "Start index must be eaqual or greater than zero");

            Debug.Assert(startIndex < arr.Length, "Start index must be less than array length");

            Debug.Assert(endIndex < arr.Length, "End index must be less than array length");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            Debug.Assert(!arr.Contains(value), "There is the searchead value in the array, but is returned -1.");

            return -1;
        }
    }
}
