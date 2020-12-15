using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Models
{
    public class TickTimer
    {
        protected Timer timer;
        protected ISimulation simulation;
        private int currentTick;
        const int TIME_OF_TICK = 100;
        public const int TICKS_PER_SECOND = 10;
        private decimal timeAcceleration;

        public TickTimer(ISimulation simulation)
        {
            timeAcceleration = 1;
            this.simulation = simulation;
            timer = new Timer(TIME_OF_TICK)
            {
                AutoReset = true
            };
            timer.Elapsed += DoTick;
            timer.Stop();
        }

        public decimal GetTimeAcceleration()
        {
            return timeAcceleration;
        }

        public void SetTimeAcceleration(decimal timeAcc)
        {
            if (timeAcc > 10m && timeAcc < 0.25m)
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
            return currentTick / TICKS_PER_SECOND;
        }

        protected void DoTick(object source, ElapsedEventArgs e)
        {
            currentTick++;
            simulation?.DoTick();
        }

        public void Stop()
        {
            timer.Stop();
        }
        public void Start()
        {
            timer.Start();
        }

        public bool isStoped()
        {
            return timer.Enabled;
        }

        internal int getCurrentTime() => currentTick / TICKS_PER_SECOND;
    }
}
