using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.LiftManager
{
    class LiftManagerContext
    {
        internal int GetNearestFloor(Lift lift, Floor floor)
        {
            if (lift.getHumanNumber() == 0)
            {
                if (floor.getHumanNumber() == 0)
                    return lift.getKeeperFloor();
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
                        if (nearestFloorDown < h.FiniteFloor)
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

        internal int GetNearestFloorForHumansInLift(Lift lift)
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
                    {
                        throw new Exception("MODEL: MinWaitingTimeStrategy: IsChoosenDirectionUp: Not all humans go in same direction!");
                    }
#endif
                }
                return nearestFloor;
            }
            return lift.getKeeperFloor();
        }

        internal void ChangeTargetFloor(SystemData data, Lift lift)
        {
            bool isDirUp = lift.getKeeperFloor() < lift.TargetFloor;
            int i = lift.getKeeperFloor() + (isDirUp ? 1 : -1);
            int humsUp;
            int humsDown;
            while (i != lift.TargetFloor)
            {
                Floor fl = data.GetFloorByNumber(i);
                this.GetEffectiveHumanCountOnFloor(fl, lift, data, out humsUp, out humsDown);
                if (isDirUp && humsUp > 0 || !isDirUp && humsDown > 0)
                {
                    lift.SetTargetFloor(i);
                    break;
                }
                else
                    i += (isDirUp ? 1 : -1);
            }
            this.GetEffectiveHumanCountOnFloor(data.GetFloorByNumber(lift.TargetFloor), lift, data, out humsUp, out humsDown);
            if (lift.getHumanNumber() != 0 && (isDirUp && humsUp <= 0 || !isDirUp && humsDown <= 0))
            {
                lift.SetTargetFloor(this.GetNearestFloorForHumansInLift(lift));
                while (i != lift.TargetFloor)
                {
                    Floor fl = data.GetFloorByNumber(i);
                    this.GetEffectiveHumanCountOnFloor(fl, lift, data, out humsUp, out humsDown);
                    if (isDirUp && humsUp > 0 || !isDirUp && humsDown > 0)
                        lift.SetTargetFloor(i);
                    else
                        i += (isDirUp ? 1 : -1);
                }
            }
        }

        internal void GetEffectiveHumanCountOnFloor(Floor fl, Lift lift, SystemData data, out int humsUp, out int humsDown)
        {
            humsUp = fl.getHumanNumberUp();
            humsDown = fl.getHumanNumberDown();
            foreach (var l in data.GetLifts())
            {
                if (l == lift)
                    continue;
                if (l.TargetFloor == fl.getKeeperFloor())
                {
                    if (l.getHumanNumber() != 0)
                    {
                        if (l.getKeeperFloor() - l.TargetFloor > 0)
                            humsDown -= data.GetParameters().LiftsCapacity - l.getHumanNumber();
                        else
                            humsUp -= data.GetParameters().LiftsCapacity - l.getHumanNumber();
                    }
                    else if (humsUp > humsDown)
                        humsUp -= data.GetParameters().LiftsCapacity - l.getHumanNumber();
                    else
                        humsDown -= data.GetParameters().LiftsCapacity - l.getHumanNumber();
                }
                else if (l.getKeeperFloor() == fl.getKeeperFloor() && l.liftState == Lift.LiftState.WaitOpened)
                {
                    if (l.getKeeperFloor() - l.TargetFloor > 0)
                        humsDown -= data.GetParameters().LiftsCapacity - l.getHumanNumber();
                    else
                        humsUp -= data.GetParameters().LiftsCapacity - l.getHumanNumber();
                }
            }
        }
    }
}
