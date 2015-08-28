using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//• Write a class  GSMCallHistoryTest  to test the call history functionality of the  GSM  class.
//◦ Create an instance of the  GSM  class.
//◦ Add few calls.
//◦ Display the information about the calls.
//◦ Assuming that the price per minute is  0.37  calculate and print the total price of the calls in the history.
//◦ Remove the longest call from the history and calculate the total price again.
//◦ Finally clear the call history and print it.


namespace GSMDevices.Tests
{
    public static class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            GSM gsm = new GSM("Samsung Galaxy S Duos S7582", "Samsung", 100M,
                new Battery(BatteryTypes.LiIon, 310, 8), new Display(4, 16 * 1024));

            Call call = new Call("0899798546", 100);
            gsm.AddCall(call);
            call = new Call("+35902364972", 50);
            gsm.AddCall(call);
            call = new Call("+35905235678", 1000);
            gsm.AddCall(call);

            Console.WriteLine("Information about the calls:");
            Console.WriteLine(gsm.CallHistoryToString());
            Console.WriteLine();

            decimal price = gsm.CalculateCallHistoryPrice(0.37M);
            Console.WriteLine("Calls total price");
            Console.WriteLine("{0:F2}", price);
            Console.WriteLine();

            Call longestCall = gsm.CallHistory.OrderByDescending(x => x.Duration).FirstOrDefault();

            if (longestCall != null)
            {
                gsm.DeleteCall(longestCall);
                Console.WriteLine("Longest call is removed.");
            }
            else
            {
                Console.WriteLine("Longest call is not found.");
            }

            price = gsm.CalculateCallHistoryPrice(0.37M);
            Console.WriteLine("Calls total price");
            Console.WriteLine("{0:F2}", price);
            Console.WriteLine();

            gsm.ClearCallHistory();
            Console.WriteLine("Call history is cleared");
            Console.WriteLine("Information about the calls:");
            Console.WriteLine(gsm.CallHistoryToString());
        }
    }
}
