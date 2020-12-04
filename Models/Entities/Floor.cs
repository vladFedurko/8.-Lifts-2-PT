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
        internal int HumanNumber;
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
            HumanNumber += humans.HumanNumber;
        }
        internal void AddHumanFactory(HumanFactory fact)
        {
            if (fact != null)
                this.genTable.Add(fact);
        }
        public void RemoveHumans(Humans humans)
        {
            Humans.Remove(humans);
            HumanNumber -= humans.HumanNumber;
        }
        internal void RemoveHumanFactory(HumanFactory fact)
        {
            genTable.Remove(fact);
        }

        public void RemoveSomeHumans(Predicate<Humans> pred)
        {
            Humans.RemoveWhere(pred);
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

        public int getHumanNumber() => HumanNumber;
    }
}
