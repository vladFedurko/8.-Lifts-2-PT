using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.LiftManager
{
    [Serializable]
    public class MinIdlingTimeLiftManager : ILiftManager
    {
        public void ManageLifts(SystemData data)
        {
            HumansMover.MoveHumans(data);
            LiftManagerContext context = new LiftManagerContext();
            foreach (Lift lift in data.GetLifts())
            {
                if (lift.liftState == Lift.LiftState.Moving)
                {
                    if (lift.TargetFloor == lift.getKeeperFloor())
                    {
                        lift.SetTargetFloor(context.GetNearestFloor(lift, data.GetFloorByNumber(lift.getKeeperFloor())));
                        lift.OpenDoor();
                    }
                    else if (data.GetParameters().LiftsCapacity > lift.getHumanNumber())
                    {
                        context.ChangeTargetFloor(data, lift);
                    }
                }
                else if (lift.liftState == Lift.LiftState.WaitClosed)
                {
                    if (lift.getHumanNumber() != 0)
                        lift.StartMoving();
                }
            }
            foreach (Floor fl in data.GetFloors())
            {
                if (fl.getHumanNumberUp() != 0 || fl.getHumanNumberDown() != 0)
                {
                    Lift waitingLift = GetNearestWaitingLift(data, fl);
                    if (waitingLift == null)
                        break;
                    if (fl.getKeeperFloor() == waitingLift.getKeeperFloor() && waitingLift.liftState != Lift.LiftState.WaitOpened)
                    {
                        waitingLift.SetTargetFloor(context.GetNearestFloor(waitingLift, data.GetFloorByNumber(waitingLift.getKeeperFloor())));
                        waitingLift.OpenDoor();
                    }
                    else
                    {
                        Lift movingLift = GetMostEffectiveMovingLift(data, fl);
                        if (movingLift == null || movingLift.TargetFloor != fl.getKeeperFloor())
                        {
                            waitingLift.SetTargetFloor(fl.getKeeperFloor());
                            waitingLift.StartMoving();
                        }
                    }
                }
            }
        }

        private Lift GetNearestWaitingLift(SystemData data, Floor floor)
        {
            int distance = int.MaxValue;
            int curDist = 0;
            Lift nearestLift = null;
            foreach (var l in data.GetLifts())
            {
                curDist = Math.Abs(l.getKeeperFloor() - floor.getKeeperFloor());
                if (l.liftState == Lift.LiftState.WaitClosed && curDist < distance)
                {
                    distance = curDist;
                    nearestLift = l;
                }
            }
            return nearestLift;
        }

        private Lift GetMostEffectiveMovingLift(SystemData data, Floor floor)
        {
            int distance = int.MaxValue;
            int curDist = 0;
            Lift nearestLift = null;
            foreach (var l in data.GetLifts())
            {
                curDist = Math.Abs(l.TargetFloor - floor.getKeeperFloor());
                if (l.liftState != Lift.LiftState.WaitClosed && curDist < distance)
                {
                    distance = curDist;
                    nearestLift = l;
                }
            }
            return nearestLift;
        }
        /*
        private Floor GetNearestFullFloor(SystemData data, int posOfLift)
        {
            int distance = int.MaxValue;
            int curDist = 0;
            Floor nearestFloor = null;
            foreach (var fl in data.GetFloors())
            {
                curDist = Math.Abs(posOfLift - fl.getKeeperFloor());
                if (curDist < distance && (fl.getHumanNumberUp() != 0 || fl.getHumanNumberDown() != 0))
                {
                    distance = curDist;
                    nearestFloor = fl;
                }
            }
            return nearestFloor;
        }*/
    }
}
