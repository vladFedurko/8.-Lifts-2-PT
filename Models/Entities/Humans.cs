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
        private bool free;

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
            free = true;
            if (_keeper.getKeeperNumber() == finiteFloor)
                free = true;
        }

        internal void changeKeeper(IKeepHuman _newKeeper) 
        {
            if (_newKeeper == null)
                free = true;
            _keeper = _newKeeper;
            if(free)
            free = false;
        }
        public void Move()
        {
            Tick();
        }

        protected void Tick()
        {
            if (Time % 3 == 0)
            {
                Console.WriteLine("Hello  World,i am human!!!");
            }
            if (free)
                Time++;
        }
    }
}