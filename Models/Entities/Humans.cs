using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace Models.Entities
{
    public class Humans : AMovable
    { 
        internal HumanState state { get; private set; }

        public void setStateToOnfloors() { state = HumanState.OnFloor; }//do not use this method in project
        //only for testing

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

        public int HumanNumber;
        public int FiniteFloor { get; set; }

        internal Humans(int humanNumber, int finiteFloor) : base()
        {
            this.HumanNumber = humanNumber;
            this.FiniteFloor = finiteFloor;
            state = HumanState.Created;
            ticksToNotify = TICKS_TO_BREATHE;
        }

        internal void ChangeState() 
        {
            if (state == HumanState.InLift)
            { 
                state = HumanState.Disposing;
                CountPermission = true;
                ticksToNotify = TICKS_TO_DISPOSE;
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
    }
}