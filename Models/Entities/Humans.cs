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
        protected Timer timer;
        
        private bool free;
        private bool stop = false;
        private bool dispose = false;


        public int HumanNumber;
        public int FiniteFloor { get; set; }
        internal int Time { get; private set; }


        IKeepHuman _keeper;

        internal void SetInterval(int newInterval) => timer.Interval = newInterval;
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
            timer = new Timer(1000)//1000 milliseconds
            {
                AutoReset = true
            };
            timer.Elapsed += Tick;
            timer.Start();
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
        void IMovable.MoveTo(int floor)
        {

        }

        protected void Tick(object source, ElapsedEventArgs e)
        {
            if (stop)
                timer.Stop();
            if (Time % 3 == 0)
            {
                if (dispose)
                    timer.Dispose();
                Console.WriteLine("Hello  World,i am human!!!");
            }
            if (free)
                Time++;
        }
    }
}