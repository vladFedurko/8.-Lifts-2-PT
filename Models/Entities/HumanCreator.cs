using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class HumanCreator : HumanFactory
    {
        public bool Disposing = false;

        public HumanCreator(int humanNumber, int FiniteFloor, int ticksToNotify, Floor floor) 
            : base(humanNumber, FiniteFloor, ticksToNotify, floor) { }

        protected override void Notify()
        {
            base.Notify();
            CountPermission = false;
            Disposing = true;
        }
    }
}
