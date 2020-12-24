using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities.Statistics;

namespace Models
{
    static class HumansMover    //do non static
    {
        public static void MoveHumans(SystemData data)
        {
            foreach (Lift lift in data.GetLifts())
            {
                if (lift.liftState == Lift.LiftState.WaitOpened)
                {
                    Floor floor = data.GetFloorByNumber(lift.getKeeperFloor());
                    HumansMover.ExitLift(floor, lift);
                    HumansMover.EnterLift(floor, lift, data.GetHumanFullStatistics());
                }
            }
        }

        public static void EnterLift(Floor floor, Lift lift, IHumanFullStatistics stats)
        {
            IEnumerable<Human> HumansToMove = floor?.getHumans().Where<Human>(h =>
                           h.state == Human.HumanState.OnFloor
                       &&
                           lift.liftState == Lift.LiftState.WaitOpened
                       &&
                           (
                               lift.getHumanNumber() == 0
                           ||
                               (
                                  lift.getHumans().ElementAt(0).FiniteFloor - lift.Floor > 0
                                  &&
                                  (floor.getKeeperFloor() - h.FiniteFloor) < 0
                               )
                           ||
                               (
                                    lift.getHumans().ElementAt(0).FiniteFloor - lift.Floor < 0
                                   &&
                                    (floor.getKeeperFloor() - h.FiniteFloor) > 0
                               )
                           )
            //&& ((rem+=h.) <Parameter_Max_Floor_count - lift.
                        );
            foreach (var h in HumansToMove)
                stats.AddWaitingTime(h.GetWaitingTime());
            lift?.AddRangeHumans(HumansToMove);
            floor?.RemoveSomeHumans(
                h =>
                h.state == Human.HumanState.InLift
                &&
                (
                    (
                        (floor.getKeeperFloor() - h.FiniteFloor) < 0
                        &&
                        lift.getHumans().ElementAt(0).FiniteFloor - lift.getKeeperFloor() > 0
                    )
                ||
                    (
                        (floor.getKeeperFloor() - h.FiniteFloor) > 0
                        &&
                        lift.getHumans().ElementAt(0).FiniteFloor - lift.getKeeperFloor() < 0
                    )
                )
            //&& ((rem+=h.) <Parameter_Max_Floor_count - lift.
            );
        }

        public static void ExitLift(Floor floor, Lift lift)
        {
            IEnumerable<Human> Lift_humans = lift?.getHumans();
            floor?.AddRangeHumans
                (
                Lift_humans.Where
                    (
                        h =>
                            h.state == Entities.Human.HumanState.InLift
                        &&
                            (floor.getKeeperFloor() - h.FiniteFloor) == 0
                    )
                );
            lift?.RemoveSomeHumans(
                h =>
                    h.state == Entities.Human.HumanState.Disposing
                &&
                    (floor.getKeeperFloor() == h.FiniteFloor)
            );
        }
    }
}
