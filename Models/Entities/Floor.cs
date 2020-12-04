using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Floor : IKeepHuman
    {
        HashSet<Human> Humans = new HashSet<Human>();
        HashSet<HumanFactory> genTable = new HashSet<HumanFactory>();
        int FloorNumber;
        internal int HumanNumberUp;
        internal int HumanNumberDown;
        internal Floor(int FloorNumber)
        {
            this.FloorNumber = FloorNumber;
        }
        public IEnumerable<Human> getHumans()
        {
            return Humans;
        }

        public void AddHumans(Human humans)
        {
            if (humans != null)
            {
                this.Humans.Add(humans);
                humans.ChangeState();
                if (humans.FiniteFloor > FloorNumber)
                    HumanNumberUp += 1;
                else
                    HumanNumberDown += 1;
            }
        }
        internal void AddHumanFactory(HumanFactory fact)
        {
            if (fact != null)
                if (!genTable.Contains(fact))
                    this.genTable.Add(fact);
                else
                    genTable.First(f => f == fact).humanNumber += fact.humanNumber;
        }
        public void RemoveHumans(Human humans)
        {
            if (humans != null)
            {
                Humans.Remove(humans);
                if (humans.FiniteFloor > FloorNumber)
                    HumanNumberUp -= 1;
                else
                    HumanNumberDown -= 1;
            }
        }
        internal void RemoveHumanFactory(HumanFactory fact)
        {
            if (fact != null)
                genTable.Remove(fact);
        }

        public void RemoveSomeHumans(Predicate<Human> pred)
        {
            if (pred != null)
            {
                this.Humans.RemoveWhere(pred);
                HumanNumberUp = 0;
                HumanNumberDown = 0;
                foreach (Human i in Humans)
                    if (i.FiniteFloor > FloorNumber)
                        HumanNumberUp += 1;
                    else
                        HumanNumberDown += 1;
            }
        }

        internal void RemoveSomeFactories(Predicate<HumanFactory> pred)
        {
            if (pred != null)
                genTable.RemoveWhere(pred);
        }

        public int getKeeperNumber()
        {
            return FloorNumber;
        }
        public int getKeeperFloor()
        {
            return FloorNumber;
        }
        public void AddRangeHumans(IEnumerable<Human> a)
        {
            foreach (var humans in a)
            {
                this.AddHumans(humans);
            }
        }
        internal void AddRangeFactories(IEnumerable<HumanFactory> a)
        {
            foreach (var fact in a)
            {
                this.AddHumanFactory(fact);
            }
        }

        public void DoTick()
        {
            foreach (var fact in genTable) 
            {
                this.AddRangeHumans(fact.DoTick());
            }
            foreach (var hum in Humans)
            {
                hum.DoTick();
                if (hum.state == Entities.Human.HumanState.DisposeNow)
                    this.Humans.Remove(hum);
            }
        }

        public int getHumanNumberUp() => HumanNumberUp;
        public int getHumanNumberDown() => HumanNumberDown;
        public int getHumanNumber()=> HumanNumberUp + HumanNumberDown;
    }
}
