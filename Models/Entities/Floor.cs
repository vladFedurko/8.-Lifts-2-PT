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
        int FloorNumber;
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
        }
        public void RemoveHumans(Humans humans)
        {
            Humans.Remove(humans);
        }

        public void RemoveAllHumans(Predicate<Humans> pred)
        {
            Humans.RemoveWhere(pred);
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

        public void DoTick()
        {
            foreach (var hum in Humans)
            {
                hum.DoTick();
                if (hum.state == Entities.Humans.HumanState.DisposeNow)
                    this.Humans.Remove(hum);
            }
        }
    }
}
