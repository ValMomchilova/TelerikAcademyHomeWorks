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
    class RangeExceptionsTest
    {
        static void Main()
        {
            DayControler dayControler = new DayControler(new Period(new DateTime(2015, 3, 31), new DateTime(2015, 4, 6))
                                                        , 3);

            // test with date
            bool canGoOut = false;
            string message = "OK";
            DateTime dateTime = new DateTime(2015, 04, 01);

            Console.WriteLine("Can I go out at {0}?", dateTime);

            try
            {
                canGoOut = dayControler.PermitGoOut(dateTime);
            }
            catch(InvalidRangeException<DateTime> ex)
            {
                message = String.Format("{0} \nIt is exam preparation period between {1} and {2}"
                    , ex.Message, ex.RangeStart, ex.RangeEnd); 
            }

            Console.WriteLine(message);
            Console.WriteLine();

            canGoOut = false;
            message = "OK";
            dateTime = new DateTime(2015, 04, 08);

            Console.WriteLine("Can I go out at {0}?", dateTime);

            try
            {
                canGoOut = dayControler.PermitGoOut(dateTime);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                message = String.Format("{0} \nIt is exam preparation period between {1} and {2}"
                    , ex.Message, ex.RangeStart, ex.RangeEnd);
            }

            Console.WriteLine(message);
            Console.WriteLine();
            
            //test wiht int
            bool canDrinkBeer = false;
            message = "OK";
            int beersCount = 4;

            Console.WriteLine("Can I drink {0} beers?", beersCount);

            try
            {
                canDrinkBeer = dayControler.PermitDrinkBeers(beersCount);
            }
            catch (InvalidRangeException<int> ex)
            {
                message = String.Format("{0} \nBeer range is between {1} and {2}"
                    , ex.Message, ex.RangeStart, ex.RangeEnd);
            }

            Console.WriteLine(message);
            Console.WriteLine();

            canDrinkBeer = false;
            message = "OK";
            beersCount = 1;

            Console.WriteLine("Can I drink {0} beers?", beersCount);

            try
            {
                canDrinkBeer = dayControler.PermitDrinkBeers(beersCount);
            }
            catch (InvalidRangeException<int> ex)
            {
                message = String.Format("{0} \nBeer range is between {1} and {2}"
                    , ex.Message, ex.RangeStart, ex.RangeEnd);
            }

            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
