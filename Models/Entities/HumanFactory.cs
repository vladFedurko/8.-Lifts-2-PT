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
    }
}
