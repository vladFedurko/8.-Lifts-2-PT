﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace Models.Entities
{
    internal class Humans : IMovable
    {
        
        
        private bool free;
        private bool stop = false;
        private bool dispose = false;


        public int HumanNumber;
        public int FiniteFloor { get; set; }
        internal int Time { get; private set; }


        IKeepHuman _keeper;

        
        internal void Stop() { stop = true; }
        internal void Dispose() { 
            if (_keeper.getKeeperFloor() == FiniteFloor) 
                dispose = true; 
            Time = 0;
        }
        internal void Start() { stop = false; timer.Start(); }
        internal Humans(int humanNumber, int finiteFloor, Floor keeper)
        {
            _keeper = keeper;
            _keeper.AddHumans(this);
            this.HumanNumber = humanNumber;
            this.FiniteFloor = finiteFloor;
            if (_keeper.getKeeperNumber() == finiteFloor)
                dispose = true;
            
            Time = 0;
            free = true;
        }

        internal void changeKeeper(IKeepHuman _newKeeper) 
        {
            if (_newKeeper == null)
                Dispose();
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