using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    public class Timer
    {       
        private readonly int interval;
        private readonly int count;
        private int ticks;       

        public Timer(int count, int interval, Action action)
        {
            this.count = count;
            this.interval = interval;
            this.Action = action;
        }

        public int Count
        {
            get { return count; }
        }

        public int Interval
        {
            get { return interval; }
        }

        public int Ticks
        {
            get { return ticks; }
        }
       
        public Action Action { get; set; }

        public void Start()
        {          
            this.Excute();
        }        

        private void Excute()
        {
            for (int i = 0; i < this.count; i++)           
            {
                Thread.Sleep(this.Interval);  			    
                Action();
                this.ticks++;
            }
        }        
    }
}
