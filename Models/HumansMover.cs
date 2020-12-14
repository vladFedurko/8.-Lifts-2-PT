using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    static class HumansMover    //donot static
    {
        public static void MoveHumans(SystemData data)
        {
            foreach (Lift lift in data.GetLifts())
            {
                if (lift.liftState == Lift.LiftState.WaitOpened)
                {
                    Floor floor = data.GetFloorByNumber(lift.getKeeperFloor());
                    HumansMover.ExitLift(floor, lift);
                    HumansMover.EnterLift(floor, lift);
                    //lift.StartMoving();
                }
            }
        }

        public static void EnterLift(Floor floor, Lift lift)
        {
            IEnumerable<Human> Floor_humans = floor?.getHumans();
            //int rem = 0;
            Console.WriteLine($"try to enter lift {lift?.LiftNumber} " +
                $"on floor {lift?.Floor} " +
                $"with humanNumberUp {floor?.getHumanNumberUp()} " +
                $"and with humanNumberDown {floor?.getHumanNumberDown()}");
            lift?.AddRangeHumans
                (
                    Floor_humans.Where<Human>(
                        h =>
                            h.state == Human.HumanState.OnFloor
                        &&
                            lift.liftState == Lift.LiftState.WaitOpened
                        &&
                            (
                                lift.humanNumber == 0
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
                        )
                );
            //Console.WriteLine(rem);
            //rem = 0;
            Console.WriteLine($"added to lift {lift?.LiftNumber} " +
                $"with numberofhum in lift {lift?.humanNumber} " +
                $"with humanNumberUp {floor?.getHumanNumberUp()} " +
                $"and with humanNumberDown {floor?.getHumanNumberDown()}");
            floor?.RemoveSomeHumans(
                h =>
                h.state == Human.HumanState.InLift
                &&
                (
                    (
                        (floor.getKeeperFloor() - h.FiniteFloor) < 0
                        &&
                        lift.getHumans().ElementAt(0).FiniteFloor - lift.Floor > 0
                    )
                ||
                    (
                        (floor.getKeeperFloor() - h.FiniteFloor) > 0
                        &&
                        lift.getHumans().ElementAt(0).FiniteFloor - lift.Floor < 0
                    )
                )
            //&& ((rem+=h.) <Parameter_Max_Floor_count - lift.
            );
            Console.WriteLine($"Humans entered lift {lift?.LiftNumber} " +
                $"on Floor {floor?.getKeeperFloor()}, " +
                $"remain numofHumans in lift {lift?.humanNumber} " +
                $"remain numofHumans on floor up {floor?.getHumanNumberUp()} " +
                $"remain numofHumans on floor down {floor?.getHumanNumberDown()} ");
        }

        public static void ExitLift(Floor floor, Lift lift)
        {
            Console.WriteLine($"try to exit lift {lift?.LiftNumber} " +
                $"on floor {lift?.Floor} " +
                $"with humanNumber {lift?.humanNumber}");
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
            Console.WriteLine($"Humans exit lift {lift?.LiftNumber} " +
                $"on Floor {floor?.getKeeperFloor()}, " +
                $"remain numofHumans {lift?.humanNumber}");
        }
    }
}
