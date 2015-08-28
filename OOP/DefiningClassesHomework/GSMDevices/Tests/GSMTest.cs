using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a class  GSMTest  to test the  GSM  class: ◦ Create an array of few instances of the  GSM  class.
//◦ Display the information about the GSMs in the array.
//◦ Display the information about the static property  IPhone4S .


namespace GSMDevices.Tests
{
    public static class GSMTest
    {
        public static void TestGSM()
        {
            GSM[] gsms = new GSM[4];

            GSM gsm = new GSM("Samsung Galaxy S Duos S7582", "Samsung", 100M,
                new Battery(BatteryTypes.LiIon, 310, 8), new Display(4, 16 * 1024));

            gsms[0] = gsm;

            gsm = new GSM("Samsung E1200", "Samsung", 15M,
                new Battery(BatteryTypes.LiIon, 720, 7), new Display(1.52, 65));

            gsms[1] = gsm;

            gsm = new GSM("Samsung E2202", "Samsung", 35M);

            gsms[2] = gsm;

            gsm = new GSM("ALCATEL ONETOUCH 1046", "Alcatel");

            gsms[3] = gsm;

            for (int i = 0; i < gsms.Length; i++)
            {
                Console.WriteLine(gsms[i]);
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
