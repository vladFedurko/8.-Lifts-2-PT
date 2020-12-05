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
        const int TICK_PER_SECOND = 100;
        private decimal timeAcceleration;

        public Observer(ISimulation simulation)
        {
            timeAcceleration = 1;
            this.simulation = simulation;
            timer = new Timer(TICK_PER_SECOND)
            {
                AutoReset = true
            };
            timer.Elapsed += Tick;
            timer.Start();
        }

        public decimal GetTimeAcceleration()
        {
            return timeAcceleration;
        }

        public void SetTimeAcceleration(decimal timeAcc)
        {
            this.timeAcceleration = timeAcc;
            timer.Interval = (int)(timeAcceleration * TICK_PER_SECOND);
        }

        public void ResetTime()
        {
            timer.Stop();
            currentTick = 0;
        }

        public int GetCurrentSecond()
        {
            return currentTick / TICK_PER_SECOND;
        }

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

        internal int getCurrentTime() => currentTick / TICK_PER_SECOND;
    }
}
