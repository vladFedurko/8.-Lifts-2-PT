using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LiftManager
{
    [Serializable]
    public class MinWaitingTimeLiftManager : ILiftManager
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
                    else if(data.GetParameters().LiftsCapacity > lift.getHumanNumber())
                    {
                        context.ChangeTargetFloor(data, lift);
                    }
                }
                else if (lift.liftState == Lift.LiftState.WaitClosed)
                {
                    if (lift.getHumanNumber() != 0)
                        lift.StartMoving();
                    else
                    {
                        lift.SetTargetFloor(this.GetTargetFloorForMinWaitingTime(data, lift));
                        Floor fl = data.GetFloorByNumber(lift.TargetFloor);
                        if (lift.TargetFloor == lift.getKeeperFloor() && fl.getHumanNumberUp() + fl.getHumanNumberDown() != 0)
                        {
                            lift.SetTargetFloor(context.GetNearestFloor(lift, data.GetFloorByNumber(lift.getKeeperFloor())));
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
            decimal maxEff = 0;
            int numFloor = -1;
            decimal curEff = 0;
            foreach (var fl in data.GetFloors())
            {
                int humsUp;
                int humsDown;
                new LiftManagerContext().GetEffectiveHumanCountOnFloor(fl, lift, data, out humsUp, out humsDown);
                if (this.CheckOtherLiftsEfficientcy(data, fl, lift))
                    continue;
                int distance = Math.Abs(lift.getKeeperFloor() - fl.getKeeperFloor());
                if (distance != 0)
                {
                    if (humsUp > humsDown)
                        curEff = (decimal)humsUp / distance;
                    else
                        curEff = (decimal)humsDown / distance;
                }
                else if (humsUp > 0 || humsDown > 0)
                {
                    numFloor = fl.getKeeperFloor();
                    break;
                }
                if (curEff > maxEff)
                {
                    maxEff = curEff;
                    numFloor = fl.getKeeperFloor();
                }
            }
            if (numFloor == -1)
                return lift.getKeeperFloor();
            return numFloor;
        }

        private bool CheckOtherLiftsEfficientcy(SystemData data, Floor floor, Lift lift)
        {
            int distance = Math.Abs(lift.getKeeperFloor() - floor.getKeeperFloor());
            foreach (var l in data.GetLifts())
            {
                if (l != lift && l.liftState == Lift.LiftState.WaitClosed && l.getHumanNumber() == 0)
                {
                    if (Math.Abs(l.getKeeperFloor() - floor.getKeeperFloor()) < distance)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
