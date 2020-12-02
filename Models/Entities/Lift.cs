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
    internal class Lift : IMovable, IKeepHuman
    {
        private bool directionUp = false;
        private bool directionDown = false;
        private bool IsMoving = false;
        List<Humans> data = new List<Humans>();
        internal int HumanNumber { get; private set; }

        internal int LiftNumber
        {
            get; private set;
        }
        internal int Floor { get; private set; }

        internal Lift(int liftNumber, int floor = 0)
        {
            this.LiftNumber = liftNumber;
            Floor = floor;
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
            if (Floor > 0)
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

        public void AddHumans(Humans a)
        {
            if ((Humans)a != null)
                data.Add(a);
            a.changeKeeper(this);
            HumanNumber += a.HumanNumber;
        }
        public void AddRangeHumans(List<Humans> a)
        {
            if (a != null)
                data.AddRange(a);
            foreach (var humans in a)
            {
                humans.changeKeeper(this);
                HumanNumber += humans.HumanNumber;
            }
        }

        public IEnumerable<Humans> getHumans()
        {
            return new List<Humans>(data);
        }

        public void Move()
        {

        }

        public int getKeeperNumber()
        {
            return LiftNumber;
        }
        public int getKeeperFloor()
        {
            return Floor;
        }
    }
}
