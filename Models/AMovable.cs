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
        private int currentTick;
        public bool CountPermission { get; set; }
        public AMovable()
        {
            currentTick = 0;
            CountPermission = true;
        }
        protected abstract void Notify();
        public void DoTick()
        {
            if (CountPermission)
                currentTick++;
            if (currentTick >= ticksToNotify)
            {
                this.Notify();
                currentTick = 0;
            }
        }
    }
}
