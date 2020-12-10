using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Strategies
{
    public class MinWaitingTimeStrategy : IStrategy
    {
        public void ManageLifts(SystemData data)
        {
            this.MoveHumans(data);
            foreach (Lift lift in data.GetLifts())
            {
                if (lift.liftState == Lift.LiftState.Moving)
                {
                    if (lift.TargetFloor == lift.getKeeperFloor())
                    {
                        lift.SetTargetFloor(this.GetNearestFloor(lift, data.GetFloorByNumber(lift.getKeeperFloor())));
                        lift.OpenDoor();
                    }
                    else
                    {
                        this.ChangeTargetFloor(data, lift);
                    }
                }
                else if (lift.liftState == Lift.LiftState.WaitClosed)
                {
                    if (lift.humanNumber != 0)
                        lift.StartMoving();
                    else
                    {
                        lift.SetTargetFloor(this.GetTargetFloorForMinWaitingTime(data, lift));
                        if (lift.TargetFloor == lift.getKeeperFloor() && data.GetFloorByNumber(lift.TargetFloor).getHumanNumber() != 0)
                        {
                            lift.OpenDoor();
                        }
                        else if (lift.TargetFloor != lift.getKeeperFloor())
                        {
                            lift.StartMoving();
                        }
                    }
                }
            }
        }

        private int GetTargetFloorForMinWaitingTime(SystemData data, Lift lift)
        {
            decimal minTime = int.MaxValue;
            int numFloor = 0;
            decimal curEffTime = 0;
            foreach (var fl in data.GetFloors())
            {
                int distance = Math.Abs(lift.getKeeperFloor() - fl.getKeeperFloor());
                if (distance != 0)
                {
                    if (fl.getHumanNumberUp() > fl.getHumanNumberDown())
                        curEffTime = fl.getHumanNumberUp() / (lift.GetTickToMove() * (Math.Abs(lift.getKeeperFloor() - fl.getKeeperFloor())));
                    else
                        curEffTime = fl.getHumanNumberDown() / (lift.GetTickToMove() * (Math.Abs(lift.getKeeperFloor() - fl.getKeeperFloor())));
                }
                else
                {
                    numFloor = fl.getKeeperFloor();
                    break;
                }
                if (curEffTime < minTime)
                {
                    minTime = curEffTime;
                    numFloor = fl.getKeeperFloor();
                }
            }
            return numFloor;
        }

        private void ChangeTargetFloor(SystemData data, Lift lift)
        {
            bool isDirUp = lift.getKeeperFloor() < lift.TargetFloor;
            int i = lift.getKeeperFloor() + (isDirUp ? 1 : -1);
            while (i != lift.TargetFloor)
            {
                Floor fl = data.GetFloorByNumber(i);
                if (isDirUp && fl.getHumanNumberUp() > 0 || !isDirUp && fl.getHumanNumberDown() > 0)
                {
                    lift.SetTargetFloor(i);
                    break;
                }
                else
                    i += (isDirUp ? 1 : -1);
            }
            Floor TargetFloor = data.GetFloorByNumber(lift.TargetFloor);
            if (isDirUp && TargetFloor.getHumanNumberUp() > 0 || !isDirUp && TargetFloor.getHumanNumberDown() > 0)
            {
                lift.SetTargetFloor(this.GetNearestFloorForHumansInLift(lift));
                while (i != lift.TargetFloor)
                {
                    Floor fl = data.GetFloorByNumber(i);
                    if (isDirUp && fl.getHumanNumberUp() > 0 || !isDirUp && fl.getHumanNumberDown() > 0)
                        lift.SetTargetFloor(i);
                    else
                        i += (isDirUp ? 1 : -1);
                }
            }
        }

        private void MoveHumans(SystemData data)
        {
            foreach (Lift lift in data.GetLifts())
            {
                if (lift.liftState == Lift.LiftState.WaitOpened)
                {
                    Floor floor = data.GetFloorByNumber(lift.getKeeperFloor());
                    HumansMover.ExitLift(floor, lift);
                    HumansMover.EnterLift(floor, lift);
                    lift.StartMoving(); //пока без задержки
                }
            }
        }

        private int GetNearestFloor(Lift lift, Floor floor)
        {
            if (lift.humanNumber == 0)
            {
                int nearestFloorUp = int.MaxValue;
                int nearestFloorDown = int.MinValue;
                int countHumansUp = 0;
                int countHumansDown = 0;
                foreach (var h in floor.getHumans())
                {
                    if (floor.getKeeperFloor() - h.FiniteFloor < 0)
                    {
                        countHumansUp++;
                        if (nearestFloorUp > h.FiniteFloor)
                            nearestFloorUp = h.FiniteFloor;
                    }
                    else
                    {
                        countHumansDown++;
                        if (nearestFloorDown > h.FiniteFloor)
                            nearestFloorDown = h.FiniteFloor;
                    }
                }
                if (countHumansUp > countHumansDown)
                    return nearestFloorUp;
                else
                    return nearestFloorDown;
            }
            else
            {
                return this.GetNearestFloorForHumansInLift(lift);
            }
        }

        private int GetNearestFloorForHumansInLift(Lift lift)
        {
            if (lift.getHumanNumber() != 0)
            {
                int nearestFloor = int.MaxValue;
                bool dir = lift.getHumans().ElementAt(0).FiniteFloor > lift.getKeeperFloor();
                foreach (var h in lift.getHumans())
                {
                    if (Math.Abs(lift.getKeeperFloor() - h.FiniteFloor) < Math.Abs(lift.getKeeperFloor() - nearestFloor))
                        nearestFloor = h.FiniteFloor;
#if DEBUG
                    if (dir != (h.FiniteFloor > lift.getKeeperFloor()))
                        throw new Exception("MODEL: MinWaitingTimeStrategy: IsChoosenDirectionUp: Not all humans go in same direction!");
#endif
                }
                return nearestFloor;
            }
            return lift.getKeeperFloor();
        }
    }
}
