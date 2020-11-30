using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Models
{
    abstract class AMovable
    {
        protected Timer timer;
        protected internal static int TickTime
        {
            get;
            protected set;
        } = 1000;
        internal abstract void SetTickTime(int newTickTime);
        public int Floor { get; protected set; }
        internal abstract void MoveTo(int floor);
        protected abstract void Tick(object source, ElapsedEventArgs e);
    }
}
