using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace Models.Entities
{
    public class Human : AMovable
    { 
        internal HumanState state { get; private set; }

        public void setStateToOnfloors() { state = HumanState.OnFloor; }//do not use this method in project
        //only for testing without timer

        const int TICKS_TO_BREATHE = 30;
        const int TICKS_TO_DISPOSE = 30;
        internal enum HumanState 
        {
            Created,
            OnFloor,
            InLift,
            Disposing,
            DisposeNow
        }
        //ISimulationStatistics _stat;

        internal int FiniteFloor { get;private set; }

        internal Human(int finiteFloor) : base()
        {
            this.FiniteFloor = finiteFloor;
            state = HumanState.Created;
            ticksToNotify = TICKS_TO_BREATHE;
        }

        public void Dispose()
        {
            if (state != HumanState.DisposeNow)
            {
                state = HumanState.Disposing;
                CountPermission = true;
                ticksToNotify = TICKS_TO_DISPOSE;
            }
        }

        internal void ChangeState() 
        {
            if (state == HumanState.InLift)
            {
                this.Dispose();
            }
            if (state == HumanState.OnFloor)
               state = HumanState.InLift;
        }

        protected override void Notify()
        {
            if (state == HumanState.Disposing)
                state = HumanState.DisposeNow;
            if (state == HumanState.Created)
            {
                state = HumanState.OnFloor;
                CountPermission = false;
            }
        }

        public String GetStatus()
        {
            String status;
            switch (this.state)
            {
                case HumanState.Created:
                    {
                        status = "Entering target floor";
                        break;
                    }
                case HumanState.OnFloor:
                    {
                        status = "Waiting for lift " + getCurrentTick() / Observer.TICKS_PER_SECOND + " seconds";
                        break;
                    }
                case HumanState.InLift:
                    {
                        status = "take the Elevator to the " + this.FiniteFloor + "th floor";
                        break;
                    }
                case HumanState.Disposing:
                    {
                        status = "Delivered to the target floor";
                        break;
                    }
                case HumanState.DisposeNow:
                    {
                        status = "Delivered to the target floor";
                        break;
                    }
                default:
                    {
                        throw new Exception("No such state: " + this.state);
                    }
            }
            return status;
        }
    }
}