using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.LiftManager
{
    public class FireAlarm : ILiftManager, ISimulationState
    {
        public FireAlarm(SystemData data)
        {
            HumansMover.MoveHumans(data);
            foreach (var lift in data.GetLifts())
            {
                lift.SetTargetFloor(0);
            }
        }

        public void ManageLifts(SystemData data)
        {
            this.DisposeHumanOnFloors(data);
            HumansMover.MoveHumans(data);
            foreach (var lift in data.GetLifts())
            {
                if (lift.liftState == Lift.LiftState.WaitClosed)
                {
                    lift.StartMoving();
                }
                if (lift.liftState == Lift.LiftState.Moving && lift.TargetFloor == lift.getKeeperFloor())
                {
                    lift.WaitWithOpenedDoor();
                    lift.RemoveFireHumans();
                }
            }
        }

        public void ResetState(SystemData data)
        {
            foreach (var lift in data.GetLifts())
            {
                lift.WaitClosed(); //turns on timer
            }
        }

        private void DisposeHumanOnFloors(SystemData data)
        {
            //data.RemoveFactoriesOfType(new HumanFactory(0, 0, 1, null).GetType());
            foreach (var floor in data.GetFloors())
            {
                floor.RemoveFireHumans();
            }
        }
    }
}
