using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    internal class Floor : IKeepHuman
    {
        List<Humans> humans = new List<Humans>();
        int FloorNumber;
        internal Floor(int FloorNumber)
        {
            this.FloorNumber = FloorNumber;
        }
        public IEnumerable<Humans> getHumans()
        {
            return new List<Humans>(humans);
        }

        public void AddHumans(Humans humans)
        {
            if (humans != null)
                this.humans.Add(humans);
        }

        public int getKeeperNumber()
        {
            return FloorNumber;
        }
        public int getKeeperFloor()
        {
            return FloorNumber;
        }
    }
}
