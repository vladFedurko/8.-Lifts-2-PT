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
        public HumanCreator(int FiniteFloor,int ticksToNotify,Floor floor):base(1,FiniteFloor,ticksToNotify,floor)
        {}

        protected override void Notify()
        {
            base.Notify();
            CountPermission = false;
            Disposing = true;
        }
    }
}
