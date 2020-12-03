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
    public class Lift : AMovable, IKeepHuman
    {
        public bool directionUp { get; set; } = false;

        internal LiftState liftState;
        internal enum LiftState
        {
            WaitClosed,
            WaitOpened,
            Moving
        }

        HashSet<Humans> data = new HashSet<Humans>();
        internal int HumanNumber { get; private set; }

        Observer observer;

        internal int LiftNumber
        {
            get; private set;
        }
        internal int Floor { get; private set; }

        const int TICKS_TO_MOVE = 10;

        internal Lift(int liftNumber, int floor = 0) : base()
        {
            ticksToNotify = TICKS_TO_MOVE;
            this.LiftNumber = liftNumber;
            Floor = floor;
            liftState = LiftState.WaitClosed;
        }
        internal void Move()
        {
            if (liftState == LiftState.Moving)
            {
                if (directionUp)
                    Floor += 2;
                if (Floor > 0)
                    Floor--;
            }
        }
        internal int EndTrip(HashSet<Humans> a)
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
            a.ChangeState();
            HumanNumber += a.HumanNumber;
        }

        public void AddRangeHumans(IEnumerable<Humans> a)
        {
            foreach (var humans in a)
            {
                AddHumans(humans);
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

        protected override void Notify()
        {

        }
    }
}
