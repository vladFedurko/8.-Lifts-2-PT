using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    class HumanFactory : AMovable
    {
        public int HumanNumber;
        public int FiniteFloor;

        internal bool NewHumansReady = false;

        public HumanFactory(int humanNumber, int finiteFloor ,int ticksToNotify) 
        {
            this.HumanNumber = humanNumber;
            this.FiniteFloor = finiteFloor;
            this.ticksToNotify = ticksToNotify;
        }

        protected override void Notify()
        {
            NewHumansReady = true;
        }

        public new Humans DoTick() 
        {
            base.DoTick();
            if (NewHumansReady)
            {
                NewHumansReady = false;
                return new Humans(HumanNumber, FiniteFloor);
            }
            return null;
        }
        public static bool operator==(HumanFactory fact,HumanFactory fact2) 
        {
            if (fact?.HumanNumber == fact2?.HumanNumber
                &&
                fact?.ticksToNotify == fact2?.ticksToNotify
                &&
                fact?.FiniteFloor == fact2?.FiniteFloor
                &&
                fact?.CurrentTick == fact2?.CurrentTick
                )
                return true;
            return false;
        }
        public static bool operator !=(HumanFactory fact, HumanFactory fact2)
        {
            if (fact?.HumanNumber == fact2?.HumanNumber
                &&
                fact?.ticksToNotify == fact2?.ticksToNotify
                &&
                fact?.FiniteFloor == fact2?.FiniteFloor
                &&
                fact?.CurrentTick == fact2?.CurrentTick
                )
                return false;
            return true;
        }
    }
}
