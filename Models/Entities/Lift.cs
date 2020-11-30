using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Models.Entities
{
    class Lift :AMovable,IKeepHuman
    {
        Timer timer;
        //private bool speedChanged=false;
        //internal event setSpeed SpeedChanged
        List<Humans> data = new List<Humans>();

        public Lift(int floor = 0)
        {
            this.Floor = floor;
            timer = new Timer(TickTime)
            {
                AutoReset = true
            };
            timer.Elapsed += tick;
            timer.Start();
        }

        private void tick(object source, ElapsedEventArgs e)
        {
            if (tickTimeChanged)
            {
                timer.Interval = TickTime;
                tickTimeChanged = false;
            }
            Console.WriteLine("Hello  World,i am lift!!!");
        }

        public IEnumerable<Humans> getHumans()
        {
            return new List<Humans>(data);
        }

        internal override void MoveTo(int floor)
        {
            this.Floor = floor;
        }
    }
}
