﻿using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    static class HumansMover
    {
        public static void EnterLift(Floor floor, Lift lift)
        {
            IEnumerable<Human> Floor_humans = floor.getHumans();
            //int rem = 0;
            lift.AddRangeHumans
                (
                Floor_humans.Where(
                    h =>
                    h.state == Entities.Human.HumanState.OnFloor
                    &&
                    lift.liftState == Lift.LiftState.WaitOpened
                    &&
                    (
                    (
                       lift.TargetFloor -lift .Floor > 0
                       && 
                       (floor.getKeeperFloor() - h.FiniteFloor) < 0
                    )
            ||
            (
                 lift.TargetFloor - lift.Floor < 0
                &&
                 (floor.getKeeperFloor() - h.FiniteFloor) > 0
            )
            )
            //&& ((rem+=h.) <Parameter_Max_Floor_count - lift.
            )
                );
            //Console.WriteLine(rem);
            //rem = 0;
            floor.RemoveSomeHumans(
                h =>
                h.state == Entities.Human.HumanState.InLift
                &&
                (
                    (floor.getKeeperFloor() - h.FiniteFloor) < 0 
                    && 
                    lift.TargetFloor - lift.Floor > 0
                )
            || 
            (
                (floor.getKeeperFloor() - h.FiniteFloor) > 0 
                &&
                lift.TargetFloor - lift.Floor < 0
            )
            //&& ((rem+=h.) <Parameter_Max_Floor_count - lift.
            );
        }

        public static void ExitLift(Floor floor,Lift lift)
        {
            IEnumerable<Human> Lift_humans = lift.getHumans();
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
                &&
                (floor.getKeeperFloor() == h.FiniteFloor)  
            );
        }
    }
}
