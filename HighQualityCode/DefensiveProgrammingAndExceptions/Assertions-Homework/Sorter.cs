namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;
    using System.Linq;  

    public class Sorter
    {
        public void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array can not be null");

            Debug.Assert(arr.Length > 0, "Array lenght must be greater than zero");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = this.FindMinElementIndex(arr, index, arr.Length - 1);
                this.Swap(ref arr[index], ref arr[minElementIndex]);
            }

            if (arr != null && arr.Length > 0)
            {
                Debug.Assert(arr.Min().CompareTo(arr[0]) == 0, "The first element is not the minimal element");
                Debug.Assert(arr.Max().CompareTo(arr[arr.Length - 1]) == 0, "The first element is not the minimal element");
            }
        }

        private int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(startIndex >= 0, "Start index must be eaqual or greater than zero");

            Debug.Assert(startIndex < arr.Length, "Start index must be less than array length");

            Debug.Assert(endIndex < arr.Length, "End index must be less than array length");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(arr[minElementIndex].CompareTo(arr[startIndex]) <= 0, "Found element is greater than first");
            return minElementIndex;
        }

        private void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
