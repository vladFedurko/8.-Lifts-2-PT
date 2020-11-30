using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace Models.Entities
{
    class Humans : AMovable
    {
        Stopwatch time;
        Timer timer;
        private int count = 2;
        //private bool speedChanged=false;
        //internal event setSpeed SpeedChanged;
        public int HumanNumber;
        public int InitFloor { get; set; }
        public int FiniteFloor { get; set; }
        private void Initialize(int humanNumber, int initFloor, int finiteFloor)
        {
            this.HumanNumber = humanNumber;
            this.InitFloor = initFloor;
            this.FiniteFloor = finiteFloor;
            timer = new Timer(TickTime)
            {
                AutoReset = true
            };
            timer.Elapsed += tick;
            timer.Start();
            time.Start();
        }

        public Humans(int humanNumber, int initFloor, int finiteFloor)
        {
            Initialize(humanNumber, initFloor, finiteFloor);
        }

        public Humans(Humans hum)//происходит с запуском другого таймера,то есть технически другие люди
        {
            Initialize(hum.HumanNumber, hum.InitFloor, hum.FiniteFloor);
        }

        internal override void Move()
        {
            this.InitFloor = this.FiniteFloor;
            timer.Stop();
            time.Stop();
            timer.Dispose();
        }

        private void tick(object source, ElapsedEventArgs e)
        {
            count++;
            if (tickTimeChanged)
            {
                timer.Interval = TickTime;
                tickTimeChanged = false;
            }
            if (count == 3)
            {
                Console.WriteLine("Hello  World!!!");
                count = 0;
            }
        }

    }
}