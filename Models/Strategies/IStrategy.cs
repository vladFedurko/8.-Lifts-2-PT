using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Strategies
{
    interface IStrategy
    {
        public int ChooseNextFloor(SystemData data, int numOfLift);
    }
}
