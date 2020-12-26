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
        IEnumerable<Human> getHumans();
        void AddHumans(Human humans);
        int getKeeperNumber();
        int getKeeperFloor();
        int getHumanNumber();
        bool IsNotEmpty();
    }
}
