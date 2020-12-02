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
        internal int Time { get; private set; }

        IKeepHuman _keeper;
        internal Humans(int humanNumber, int finiteFloor, Floor keeper)
        {
            _keeper = keeper;
            _keeper.AddHumans(this);
            this.HumanNumber = humanNumber;
            this.FiniteFloor = finiteFloor;
            Time = 0;
            state = (int)State.Created;
            if (_keeper.getKeeperNumber() == finiteFloor)
                state = State.Disposing;
        }

        internal void changeKeeper(IKeepHuman _newKeeper) 
        {
            if (state == State.InLift)
                state = State.Disposing;
            if (state == State.Created)
               state = State.InLift;
            if (_newKeeper == null)
                return; 
            _keeper = _newKeeper;
            //_stat.addWaitTime(Time);
            Time = 0;
            
            _keeper.AddHumans(this);
        }
        public void Move()
        {
            Tick();
        }

        protected void Tick()
        {
            switch(state)
            {
                case State.Disposing:
            {
                Time++;
                if (Time == 3)
                {
                    Console.WriteLine("Hello  World,i am human!!!");
                }
            }
            if (state == State.Created)
                Time++;
        }
            
        }
    }
}