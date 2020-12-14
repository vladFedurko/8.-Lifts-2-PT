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

        internal const int TICKS_TO_MOVE = 10;

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
                    Floor++;
                else if (Floor > 0)
                    Floor--;
            }
        }

        internal int GetTickToMove()
        {
            return TICKS_TO_MOVE;
        }

        internal void OpenDoor()
        {
            this.liftState = LiftState.WaitOpened;
            this.CountPermission = true;
        }

        internal void WaitWithOpenedDoor()
        {
            this.liftState = LiftState.WaitOpened;
            this.CountPermission = false;
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
            if (a != null)
                foreach (var humans in a)
                {
                    AddHumans(humans);
                }
        }
        public void RemoveSomeHumans(Predicate<Human> pred)
        {
            if (pred != null && data.Count > 0)
            {
                data.RemoveWhere(pred);
                humanNumber = data.Count;
            }
        }
        public void RemoveHumans(Human humans)
        {
            if (humans != null && data.Contains(humans))
            {
                data.Remove(humans);
                humanNumber--;
            }
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
            if (liftState == LiftState.WaitOpened)
            {
                liftState = LiftState.WaitClosed;
                CountPermission = false;
            }
            else if (liftState == LiftState.Moving)
            {
                Move();
            }
        }

        public int getHumanNumber() => humanNumber;
    }
}
