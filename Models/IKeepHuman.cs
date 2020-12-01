using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models
{
    interface IKeepHuman
    {
        IEnumerable<Humans> getHumans();
        void AddRangeHumans(List<Humans> humans);
        void AddHumans(Humans humans);
    }
}
