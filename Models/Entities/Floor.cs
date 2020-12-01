﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    internal class Floor : IKeepHuman
    {
        List<Humans> humans;

        public IEnumerable<Humans> getHumans()
        {
            return new List<Humans>(humans);
        }

        public void AddHumans(Humans humans)
        {
            if (humans != null)
                this.humans.Add(humans);
        }
        public void AddRangeHumans(List<Humans> humans)
        {
            if (humans!= null)
                this.humans.AddRange(humans);
        }
    }
}
