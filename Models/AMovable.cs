using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    abstract class AMovable
    {
        protected internal static int TickTime
        {
            get;
            protected set;
        } = 1000;

        public int Floor { get; protected set; }
        protected static bool tickTimeChanged = false;
        internal static void SetTickTime(int newSpeed) { TickTime = newSpeed; tickTimeChanged = true; }
        //internal delegate void setSpeed(int newSpeed);
        //internal protected event setSpeed SpeedChanged;
        internal abstract void MoveTo(int floor);
    }
}
