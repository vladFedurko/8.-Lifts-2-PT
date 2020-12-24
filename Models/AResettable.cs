using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Models
{
    public abstract class AResettable : ITickable
    {
        protected int ticksToNotify;
        private int CurrentTick;
        protected bool CountPermission { get; set; }
        public AResettable()
        {
            CurrentTick = 0;
            CountPermission = true;
        }
        protected abstract void Notify();

        protected int getCurrentTick() => CurrentTick;
        internal int getTicksToNotify() => ticksToNotify;
        public void DoTick()
        {
            if (CountPermission)
                CurrentTick++;
            if (CurrentTick >= ticksToNotify)
            {
                this.Notify();
                CurrentTick = 0;
            }
        }
    }
}
