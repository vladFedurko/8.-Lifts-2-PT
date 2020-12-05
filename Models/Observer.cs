using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Models
{
    public class Observer
    {
        protected Timer timer;
        protected ISimulation simulation;
        private int currentTick;

        public Observer()
        {
            timer = new Timer(100)//100 milliseconds
            {
                AutoReset = true
            };
            timer.Elapsed += Tick;
            timer.Start();
        }

        internal void SetInterval(int newInterval) => timer.Interval = newInterval;

        protected void Tick(object source, ElapsedEventArgs e)
        {
            currentTick++;
            simulation?.doTick();
        }

        public void Stop()
        {
            timer.Stop();
        }
        public void Start()
        {
            timer.Start();
        }

        internal int getCurrentTick() => currentTick;
    }
}
