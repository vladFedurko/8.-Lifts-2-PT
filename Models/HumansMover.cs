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
        public void EnterLift(Floor floor, Lift lift)
        {
            IEnumerable<Humans> Floor_humans = floor.getHumans();
            //int rem = 0;
            lift.AddRangeHumans
                (
                Floor_humans.Where(
                    h => 
                    (
                       lift.IsMoving 
                       && 
                       lift.directionUp
                       && 
                       (floor.getKeeperFloor() - h.FiniteFloor) < 0
                    )
            ||
            (
                lift.IsMoving
                &&
                 !lift.directionUp
                &&
                 (floor.getKeeperFloor() - h.FiniteFloor) > 0
            )
            //&& ((rem+=h.HumanNumber) <Parameter_Max_Floor_count - lift.HumanNumber
            )
                );
            //Console.WriteLine(rem);
            //rem = 0;
            floor.RemoveAllHumans(
                h => 
                (
                    (floor.getKeeperFloor() - h.FiniteFloor) < 0 && lift.directionUp
                )
            || 
            (
                (floor.getKeeperFloor() - h.FiniteFloor) > 0 
                && 
                !lift.directionUp
            )
            //&& ((rem+=h.HumanNumber) <Parameter_Max_Floor_count - lift.HumanNumber
            );
        }

        public void ExitLift(Floor floor,Lift lift)
        {
            IEnumerable<Humans> Lift_humans = lift.getHumans();
            floor.AddRangeHumans
                (
                Lift_humans.Where
                (
                    h => (floor.getKeeperFloor() - h.FiniteFloor) == 0
                )
                );
            lift.RemoveAllHumans(
                h => (floor.getKeeperFloor() == h.FiniteFloor)  
            );
        }
    }
}
