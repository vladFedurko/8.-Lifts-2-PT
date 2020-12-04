using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Floor : IKeepHuman
    {
        readonly HashSet<Humans> Humans = new HashSet<Humans>();
        HashSet<HumanFactory> genTable = new HashSet<HumanFactory>();
        int FloorNumber;
        internal int HumanNumberUp;
        internal int HumanNumberDown;
        internal Floor(int FloorNumber)
        {
            this.FloorNumber = FloorNumber;
        }
        public IEnumerable<Humans> getHumans()
        {
            return Humans;
        }

        public void AddHumans(Humans humans)
        {
            if (humans != null)
                this.Humans.Add(humans);
            humans.ChangeState();
            if(humans.FiniteFloor >FloorNumber)
                HumanNumberUp += humans.HumanNumber;
            else
                HumanNumberDown += humans.HumanNumber;
        }
        internal void AddHumanFactory(HumanFactory fact)
        {
            if (fact != null)
                if (!genTable.Contains(fact))
                    this.genTable.Add(fact);
                else
                    genTable.First(f => f == fact).HumanNumber *= 2;
        }
        public void RemoveHumans(Humans humans)
        {
            if (humans != null)
            {
                Humans.Remove(humans);
                if (humans.FiniteFloor > FloorNumber)
                    HumanNumberUp -= humans.HumanNumber;
                else
                    HumanNumberDown -= humans.HumanNumber;
            }
        }
        internal void RemoveHumanFactory(HumanFactory fact)
        {
            if (fact != null)
                genTable.Remove(fact);
        }

        public void RemoveSomeHumans(Predicate<Humans> pred)
        {
            Humans.RemoveWhere(pred);
            foreach(Humans i in Humans)
                if (i.FiniteFloor > FloorNumber)
                    HumanNumberUp += i.HumanNumber;
                else
                    HumanNumberDown += i.HumanNumber;
        }

        internal void RemoveSomeFactories(Predicate<HumanFactory> pred)
        {
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
        public void AddRangeHumans(IEnumerable<Humans> a)
        {
            foreach (var humans in a)
            {
                this.AddHumans(humans);
            }
        }
        internal void AddRangeFactoriess(IEnumerable<HumanFactory> a)
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
                this.AddHumans(fact.DoTick());
            }
            foreach (var hum in Humans)
            {
                hum.DoTick();
                if (hum.state == Entities.Humans.HumanState.DisposeNow)
                    this.Humans.Remove(hum);
            }
        }

        public int getHumanNumberUp() => HumanNumberUp;
        public int getHumanNumberDown() => HumanNumberDown;

        int IKeepHuman.getHumanNumber()=> HumanNumberUp + HumanNumberDown;
    }
}
