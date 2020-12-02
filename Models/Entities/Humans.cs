using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace Models.Entities
{
    internal class Humans : IMovable
    { 
        private int state;

        enum State 
        {
            Created,
            InLift,
            Disposing,
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
            state = State.Created;
            if (_keeper.getKeeperNumber() == finiteFloor)
                free = false;
        }

        internal void changeKeeper(IKeepHuman _newKeeper) 
        {
            if (free)
                free = false;
            if (_newKeeper == null)
                return; 
            _keeper = _newKeeper;
            //_stat.addWaitTime(Time);
            Time = 0;
            if (_newKeeper.GetType().Name.Equals("Floor"))
                free = true;
            _keeper.AddHumans(this);
        }
        public void Move()
        {
            Tick();
        }

        protected void Tick()
        {
            if (free)
            {
                Time++;
                if (Time == 3)
                {
                    Console.WriteLine("Hello  World,i am human!!!");
                }
            }
            if (free)
                Time++;
        }
    }
}