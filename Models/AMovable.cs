using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    abstract class AMovable
    {
        protected internal static int Speed
        {
            get;
            protected set;
        } = 1000;
        protected static bool speedChanged = false;
        internal static void SetSpeed(int newSpeed) { Speed = newSpeed; speedChanged = true; }
        //internal delegate void setSpeed(int newSpeed);
        //internal protected event setSpeed SpeedChanged;
        internal abstract void Move();
    }
}
