﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    internal class Floor : IKeepHuman
    {
        HashSet<Humans> Humans = new HashSet<Humans>();
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
        }
        public void RemoveHumans(Humans humans)
        {
            Humans.Remove(humans);
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
