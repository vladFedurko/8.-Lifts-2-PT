using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class HumanFactory : AResettable
    {
        public int humanNumber;
        public int FiniteFloor;
        public readonly Floor floor;

        public HumanFactory(int humanNumber, int finiteFloor ,int ticksToNotify , Floor floor) 
        {
            this.humanNumber = humanNumber;
            this.FiniteFloor = finiteFloor;
            this.ticksToNotify = ticksToNotify;
            if (floor == null)
                return;
            this.floor = floor;
        }

        protected override void Notify()
        {
            for (int i = 0; i < humanNumber; i++)
            {
                Human Human = new Human(FiniteFloor);
                floor.AddHumans(Human);
                Console.WriteLine("Human created " + i + " on floor " + floor.getKeeperFloor());
            }
        }

        public override bool Equals(object ofact) 
        {
            HumanFactory fact = (HumanFactory)ofact;
            if (
                this?.ticksToNotify == fact?.ticksToNotify
                &&
                this?.FiniteFloor == fact?.FiniteFloor
                &&
                this?.floor.getKeeperFloor() == fact?.floor.getKeeperFloor()
                )
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return humanNumber.GetHashCode() * (1 >> 10) + FiniteFloor.GetHashCode() * (1 >> 5) + floor.getKeeperNumber() + getCurrentTick() * (1 >> 21);
        }
    }
}
