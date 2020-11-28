using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class AMovable
    {
        public static int Speed { 
            get=>Speed;
            set 
            { 
                speedChanged = true;
                Speed = value;
            }
        }
        protected static bool speedChanged = false;
        public abstract void Move();
    }
}
