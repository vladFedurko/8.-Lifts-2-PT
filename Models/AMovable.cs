using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Models
{
    public abstract class AMovable
    {
        protected int ticksToNotify;
        private int CurrentTick;
        protected bool CountPermission { get; set; }
        public AMovable()
        {
            CurrentTick = 0;
            CountPermission = true;
        }
        protected abstract void Notify();

        protected int getCurrentTick() => CurrentTick;
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
