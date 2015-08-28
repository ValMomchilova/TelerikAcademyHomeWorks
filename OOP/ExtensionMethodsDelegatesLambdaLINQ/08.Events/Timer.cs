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

        public Timer(int count, int interval)
        {
            this.count = count;
            this.interval = interval;
        }

        public event EventHandler Elapsed;

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

        public void Start()
        {          
            this.Excute();
        }        

        private void Excute()
        {
            for (int i = 0; i < this.count; i++)           
            {
                Thread.Sleep(this.Interval); 
                this.OnElapsed();
                this.ticks++;
            }
        }

        private void OnElapsed()
        {
            if (this.Elapsed != null)
            {
                Elapsed(this, new EventArgs());
            }
        }        
    }
}
