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
        const int TIME_OF_TICK = 100;
        private decimal timeAcceleration;

        public Observer(ISimulation simulation)
        {
            timeAcceleration = 1;
            this.simulation = simulation;
            timer = new Timer(TIME_OF_TICK)
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
            if (timeAcc > 4m && timeAcc < 0.1m)
                return;
            this.timeAcceleration = timeAcc;
            timer.Interval = (int)(TIME_OF_TICK / timeAcceleration);
        }

        public void ResetTime()
        {
            timer.Stop();
            currentTick = 0;
        }

        public int GetCurrentSecond()
        {
            return currentTick / TIME_OF_TICK;
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

        internal int getCurrentTime() => currentTick / TIME_OF_TICK;
    }
}
