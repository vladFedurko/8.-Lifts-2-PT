using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace Models.Entities
{
    public class Humans : IMovable
    { 
        private State state;

        enum State 
        {
            Created,
            InLift,
            Disposing
        }
        //ISimulationStatistics _stat;

        public int HumanNumber;
        public int FiniteFloor { get; set; }

        internal Humans(int humanNumber, int finiteFloor)
        {
            this.HumanNumber = humanNumber;
            this.FiniteFloor = finiteFloor;
            state = (int)State.Created;
        }

        internal void changeKeeper(IKeepHuman _newKeeper) 
        {
            if (state == State.InLift)
                state = State.Disposing;
            if (state == State.Created)
               state = State.InLift;
            if (_newKeeper == null)
                return; 
        }

        public void Dispose()
        {
            //this._keeper. to delete
        }

        public void Notify(int tag)
        {
            switch (state)
            {
                case State.Disposing:
                {
                    this.Dispose();
                    break;
                }
                case State.Created:
                {
                    this.ChooseLift();
                    break;
                }
                case State.InLift:
                    {
                        //TODO
                        break;
                    }
            }
        }
    }
}