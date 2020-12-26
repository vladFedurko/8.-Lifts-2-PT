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
                    HumansMover.EnterLift(floor, lift, data.GetHumanStatistics(), data.GetParameters().LiftsCapacity);
                }
            }
        }

        public static void EnterLift(Floor floor, Lift lift, IHumanFullStatistics stats, int liftCapacity)
        {
            IEnumerable<Human> HumansToMove = floor.getHumans().Where<Human>(h =>
                           h.state == Human.HumanState.OnFloor
                       &&
                           (
                                lift.TargetFloor - lift.Floor > 0
                                &&
                                (floor.getKeeperFloor() - h.FiniteFloor) < 0
                           ||
                                lift.TargetFloor - lift.Floor < 0
                                &&
                                (floor.getKeeperFloor() - h.FiniteFloor) > 0
                           )
                        );
            foreach (var h in HumansToMove)
            {
                if (liftCapacity > lift.getHumanNumber())
                {
                    stats.AddWaitingTime(h.GetWaitingTime());
                    lift.AddHumans(h);
                }
                else
                    break;
            }
            floor.RemoveSomeHumans(
                h =>
                h.state == Human.HumanState.InLift
            );
        }

        public static void ExitLift(Floor floor, Lift lift)
        {
            IEnumerable<Human> Lift_humans = lift?.getHumans();
            floor.AddRangeHumans
                (
                Lift_humans.Where
                    (
                        h =>
                            h.state == Entities.Human.HumanState.InLift
                        &&
                            (floor.getKeeperFloor() - h.FiniteFloor) == 0
                    )
                );
            lift.RemoveSomeHumans(
                h =>
                    h.state == Entities.Human.HumanState.Disposing
            );
        }
    }
}
