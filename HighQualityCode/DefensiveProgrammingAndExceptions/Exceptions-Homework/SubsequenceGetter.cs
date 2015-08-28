using System;
using System.Collections.Generic;

public class SubsequenceGetter
{
    public T[] GetSubsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("Arr can not be null");
        }

        if (arr.Length == 0)
        {
            throw new ArgumentException("Arr length must be grater than 0");
        }

        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException("The start index can not be less than zero");
        }

        if (startIndex >= arr.Length)
        {
            throw new ArgumentOutOfRangeException("The start index can not be greater than last array index");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("The count can not be less than zero");
        }

        List<T> result = new List<T>();
        int lastIndex = startIndex + count - 1;
        for (int i = startIndex; i <= lastIndex; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }
}
