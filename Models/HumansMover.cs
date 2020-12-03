using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class HumansMover
    {
        public void EnterLift(Humans humans, ref Floor floor, ref Lift lift)
        {
            floor.RemoveHumans(humans);
            lift.AddHumans(humans);
        }

        public void ExitLift(Humans humans, ref Floor floor, ref Lift lift)
        {
            floor.AddHumans(humans);
            lift.RemoveHumans(humans);
        }
    }
}
