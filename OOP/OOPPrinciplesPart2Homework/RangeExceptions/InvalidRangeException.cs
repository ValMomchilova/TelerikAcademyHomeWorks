using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class  InvalidRangeException<T>  that holds information about an error condition related to invalid range.
//It should hold error message and a range definition [ start … end ].
//• Write a sample application that demonstrates the  InvalidRangeException<int>  
//and  InvalidRangeException<DateTime>  by entering numbers in the range [ 1..100 ] and dates in the range [ 1.1.1980 … 31.12.2013 ].

namespace RangeExceptions
{
    class InvalidRangeException<T> : Exception 
        where T : IComparable<T>
    {
        public InvalidRangeException(string message, T rangeStart, T rangeEnd)
            :base(message)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        public InvalidRangeException(string message, Exception innerException, T rangeStart, T rangeEnd)
            : base(message, innerException)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        public T RangeStart { get; set; }
        public T RangeEnd { get; set; }
    }
}
