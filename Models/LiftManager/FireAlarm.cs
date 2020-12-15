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
            foreach (var lift in data.GetLifts())
            {
                if (lift.liftState == Lift.LiftState.WaitClosed)
                {
                    lift.StartMoving();
                }
                if (lift.liftState == Lift.LiftState.Moving && lift.TargetFloor == lift.getKeeperFloor())
                {
                    lift.WaitWithOpenedDoor();
                }
            }
        }

        public void ResetState(SystemData data)
        {
            foreach (var lift in data.GetLifts())
            {
                lift.OpenDoor(); //turns on timer
            }
        }

        private void DisposeHumanOnFloors(SystemData data)
        {
            foreach (var floor in data.GetFloors())
            {
                foreach (var hum in floor.getHumans())
                {
                    hum.Dispose();
                }
            }
        }
    }
}
