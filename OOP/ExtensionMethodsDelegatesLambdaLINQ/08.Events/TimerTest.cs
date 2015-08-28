using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class TimerTest
    {
        static void Main()
        { 
            Timer timer = new Timer(4, 1000);

            timer.Elapsed += timer_Elapsed;

            timer.Start();            
        }

        static void timer_Elapsed(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
