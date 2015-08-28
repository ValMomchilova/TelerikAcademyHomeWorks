namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;
    using System.Linq;    

    public class AssertionsHomework
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            Sorter collectionSorter = new Sorter();
            collectionSorter.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            collectionSorter.SelectionSort(new int[0]); // Test sorting empty array
            collectionSorter.SelectionSort(new int[1]); // Test sorting single element array

            Searcher collectionSearcher = new Searcher();

            Console.WriteLine(collectionSearcher.BinarySearch(arr, -1000));
            Console.WriteLine(collectionSearcher.BinarySearch(arr, 0));
            Console.WriteLine(collectionSearcher.BinarySearch(arr, 17));
            Console.WriteLine(collectionSearcher.BinarySearch(arr, 10));
            Console.WriteLine(collectionSearcher.BinarySearch(arr, 1000));

            int testEmptArraySearch = collectionSearcher.BinarySearch(new int[0], 5); // Test searching empty array
            int testSingleElementExistingSearch = collectionSearcher.BinarySearch(new int[1], 0); // Test searching single element array (Existing value)
            int testSingleelementNoExistingsearch = collectionSearcher.BinarySearch(new int[1], 5); // Test searching single element array (Non existing value)
        }
    }
}