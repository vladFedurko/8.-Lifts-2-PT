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
    public class Lift : IMovable, IKeepHuman
    {
        public bool directionUp { get; private set; } = false;
        public bool IsMoving { get; private set; } = false;
        public bool IsDoorOpen { get; private set; } = false;
        HashSet<Humans> data = new HashSet<Humans>();
        internal int HumanNumber { get; private set; }

        Observer observer;

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
        }
        internal void Wait()
        {
            IsMoving = false;
            directionUp = false;
        }
        internal void MoveUp()
        {
            Floor++;
            if (IsMoving)
            {
                if (!directionUp)
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
                directionUp = false;
            }
        }

        internal int EndTrip(List<Humans> a)
        {
            int g = HumanNumber;
            foreach (var b in a)
            {
                data.Remove(b);
                HumanNumber -= b.HumanNumber;
            }
            return g;
        }

        public void AddHumans(Humans a)
        {
            if ((Humans)a != null)
                data.Add(a);
            a.changeState();
            HumanNumber += a.HumanNumber;
        }

        public void AddRangeHumans(IEnumerable<Humans> a)
        {
            foreach (var humans in a)
            {
                humans.changeState();
                data.Add(humans);
                HumanNumber += humans.HumanNumber;
            }
        }
        public void RemoveAllHumans(Predicate<Humans> pred)
        {
            data.RemoveWhere(pred);
        }
        public void RemoveHumans(Humans humans)
        {
            data.Remove(humans);
        }

        public IEnumerable<Humans> getHumans()
        {
            return data;
        }

        public int getKeeperNumber()
        {
            return LiftNumber;
        }

        public int getKeeperFloor()
        {
            return Floor;
        }

        public IKeepHuman GetKeeperByNumber(int number)
        {
            return this;
        }
    }
}
