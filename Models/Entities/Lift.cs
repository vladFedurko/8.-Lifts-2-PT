using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Models.Entities
{
    internal class Lift : AMovable, IKeepHuman
    {
        private bool directionUp = false;
        private bool directionDown = false;
        private bool IsMoving = false;
        List<Humans> data = new List<Humans>();
        private int HumanNumber;

        internal Lift(int floor = 0)
        {
            this.Floor = floor;
            timer = new Timer(TickTime)
            {
                AutoReset = true
            };
            timer.Elapsed += Tick;
            timer.Start();
        }

        internal void ChangeDirection()
        {
            directionUp = !directionUp;
            directionDown = !directionDown;
        }
        internal void Wait()
        {
            IsMoving = false;
            directionDown = false;
            directionUp = false;
        }
        internal void MoveUp()
        {
            Floor++;
            if (IsMoving)
            {
                if (directionDown)
                    ChangeDirection();
            }
            else
            {
                IsMoving = true;
                directionUp = true;
            }
        }

        internal void MoveDown()
        {

            Floor--;
            if (IsMoving)
            {
                if (directionUp)
                    ChangeDirection();
            }
            else
            {
                IsMoving = true;
                directionDown = true;
            }
        }

        internal int EndTrip(List<Humans> a)
        {
            int g = HumanNumber;
            foreach (var b in a)
            {
                data.Remove(b);
                HumanNumber -= b.HumanNumber;
                b.Stop();
                //b.Dispose();
            }
            return g;
        }

        internal void AddHumans(Humans a)
        {
            if ((Humans)a != null)
                data.Add(a);
            HumanNumber += a.HumanNumber;
        }
        internal void AddRangeHumans(List<Humans> a)
        {
            if (a != null)
                data.AddRange(a);
            foreach (var humans in a)
                HumanNumber += humans.HumanNumber;
        }
        internal override void SetTickTime(int newTickTime)
        {
            timer.Interval = newTickTime;
        }
        protected override void Tick(object source, ElapsedEventArgs e)
        {
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
