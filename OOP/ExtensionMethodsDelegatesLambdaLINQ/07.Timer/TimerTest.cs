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
            Action action = () => Console.WriteLine(DateTime.Now);

            Timer timer = new Timer(5, 1000, action);

            timer.Start();            
        }
    }
}
