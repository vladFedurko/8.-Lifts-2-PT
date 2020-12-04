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
        internal int TargetFloor { get; private set; }

        internal LiftState liftState;
        internal enum LiftState
        {
            WaitClosed,
            WaitOpened,
            Moving
        }

        HashSet<Human> data = new HashSet<Human>();

        internal int humanNumber;
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
            TargetFloor = floor;
            liftState = LiftState.WaitClosed;
            CountPermission = false;
        }
        internal void StartMoving()
        {
            CountPermission = true;
            liftState = LiftState.Moving;
        }
        internal void SetTargetFloor(int floor) => TargetFloor = floor;
        private void Move()
        {
            if (liftState == LiftState.Moving)
            {
                if (TargetFloor - Floor > 0)
                    Floor += 2;
                if (Floor > 0)
                    Floor--;
            }
        }

        public void AddHumans(Human a)
        {
            if ((Human)a != null)
            {
                data.Add(a);
                a.ChangeState();
                humanNumber += 1;
            }
        }

        public void AddRangeHumans(IEnumerable<Human> a)
        {
            foreach (var humans in a)
            {
                AddHumans(humans);
            }
        }
        public void RemoveSomeHumans(Predicate<Human> pred)
        {
            if (pred != null)
                data.RemoveWhere(pred);
        }
        public void RemoveHumans(Human humans)
        {
            if (humans != null)
                data.Remove(humans);
        }

        public IEnumerable<Human> getHumans()
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

        protected override void Notify()
        {
            Move();
            CountPermission = false;
            liftState = LiftState.WaitClosed;
        }

        public int getHumanNumber() => humanNumber;
    }
}
