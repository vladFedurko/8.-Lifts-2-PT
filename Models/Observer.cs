using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Models
{
    class Observer
    {
        protected Timer timer;
        public Observer()
        {
            timer = new Timer(1000)//1000 milliseconds
            {
                AutoReset = true
            };
            timer.Elapsed += Tick;
            timer.Start();
        }
        internal void SetInterval(int newInterval) => timer.Interval = newInterval;
        protected void Tick(object source, ElapsedEventArgs e)
        {
            
        }
    }
}
