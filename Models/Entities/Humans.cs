using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace Models.Entities
{
    internal class Humans : AMovable
    {
        internal int Time { get; private set; }
        private bool stop = false;
        private bool dispose = false;
        public int HumanNumber;
        private bool free;

        public int InitFloor { get; set; }
        public int FiniteFloor { get; set; }
        private void Initialize(int humanNumber, int initFloor, int finiteFloor)
        {
            this.HumanNumber = humanNumber;
            this.InitFloor = initFloor;
            this.FiniteFloor = finiteFloor;
            if (initFloor == finiteFloor)
                dispose = true;
            timer = new Timer(TickTime)
            {
                AutoReset = true
            };
            timer.Elapsed += Tick;
            timer.Start();
            Time = 0;
            free = true;
        }
        internal override void SetTickTime(int newTickTime)
        {
            timer.Interval = newTickTime;
        }
        internal void Stop() { stop = true; }
        internal void Dispose() { dispose = true; }
        internal void Start() { stop = false; timer.Start(); }
        public Humans(int humanNumber, int initFloor, int finiteFloor)
        {
            Initialize(humanNumber, initFloor, finiteFloor);
        }
        internal override void MoveTo(int floor)
        {
            this.Floor = floor;
            if(free)
            free = false;
        }

        protected override void Tick(object source, ElapsedEventArgs e)
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