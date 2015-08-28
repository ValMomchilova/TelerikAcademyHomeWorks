using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMDevices.Tests;

namespace GSMDevices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEST GSM:");
            Console.WriteLine();
            GSMTest.TestGSM();

            Console.WriteLine(new string('_', 40));

            Console.WriteLine("TEST CALL HISTORY:");
            Console.WriteLine();
            GSMCallHistoryTest.TestCallHistory();
        }
    }
}
