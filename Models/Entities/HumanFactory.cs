using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    internal class HumanFactory : AMovable
    {
        public int humanNumber;
        public int FiniteFloor;

        internal bool NewHumansReady = false;

        public HumanFactory(int humanNumber, int finiteFloor ,int ticksToNotify) 
        {
            this.humanNumber = humanNumber;
            this.FiniteFloor = finiteFloor;
            this.ticksToNotify = ticksToNotify;
        }

        protected override void Notify()
        {
            NewHumansReady = true;
        }

        public new List<Human> DoTick() 
        {
            base.DoTick();
            if (NewHumansReady)
            {
                NewHumansReady = false;
                Console.WriteLine($"Humans created by fabric {humanNumber} {FiniteFloor} {ticksToNotify}");
                List<Human> humans = new List<Human>(humanNumber);
                for (int i = 0; i < humanNumber; i++)
                    humans.Add(new Human(FiniteFloor));
                return humans;
            }
            return null;
        }
        public static bool operator==(HumanFactory fact,HumanFactory fact2) 
        {
            if (
                fact?.ticksToNotify == fact2?.ticksToNotify
                &&
                fact?.FiniteFloor == fact2?.FiniteFloor
                &&
                fact?.getCurrentTick() == fact2?.getCurrentTick()
                )
                return true;
            return false;
        }
        public static bool operator !=(HumanFactory fact, HumanFactory fact2)
        {
            if (
                fact?.ticksToNotify == fact2?.ticksToNotify
                &&
                fact?.FiniteFloor == fact2?.FiniteFloor
                &&
                fact?.getCurrentTick() == fact2?.getCurrentTick()
                )
                return false;
            return true;
        }
    }
}
