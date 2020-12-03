using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models
{
    public interface IKeepHuman
    {
        IEnumerable<Humans> getHumans();
        void AddHumans(Humans humans);
        int getKeeperNumber();
        int getKeeperFloor();
    }
}
