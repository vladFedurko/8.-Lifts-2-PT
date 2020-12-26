using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Models.Entities.Statistics;

namespace Models.Entities
{
    public class Lift : AResettable, IKeepHuman
    {
        internal int TargetFloor { get; private set; }

        public LiftState liftState;

        private ILiftStatistics statistics;

        public enum LiftState
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

        internal readonly int TICKS_TO_MOVE;

        internal readonly int TICKS_TO_WAIT;

        internal Lift(int liftNumber, int ticksToMove = 30, int ticksToWait = 30, int floor = 0) : base()
        {
            TICKS_TO_MOVE = ticksToMove;
            ticksToNotify = TICKS_TO_MOVE;
            this.LiftNumber = liftNumber;
            TICKS_TO_WAIT = ticksToWait;
            Floor = floor;
            TargetFloor = floor;
            liftState = LiftState.WaitClosed;
            statistics = new LiftStatistics();
            CountPermission = false;
        }

        internal void StartMoving()
        {
            CountPermission = true;
            this.ticksToNotify = TICKS_TO_MOVE;
            liftState = LiftState.Moving;
        }
        internal void Reset() { if(data.Count == 0) Floor = 0; liftState = LiftState.WaitClosed; }

        internal void SetTargetFloor(int floor)
        {
            this.TargetFloor = floor;
        }

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
            if (liftState != LiftState.WaitClosed) {
                statistics.DirectionChanged();
                if (!this.IsNotEmpty())
                    statistics.MovedWithoutHumans();
            }
            this.liftState = LiftState.WaitOpened;
            this.ticksToNotify = TICKS_TO_WAIT;
            this.CountPermission = true;
        }

        internal void WaitWithOpenedDoor()
        {
            this.liftState = LiftState.WaitOpened;
            this.CountPermission = false;
        }
        internal void WaitClosed()
        {
            this.liftState = LiftState.WaitClosed;
            this.CountPermission = false;
        }

        public void AddHumans(Human a)
        {
            if (a != null)
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
                int humansBefore = data.Count;
                data.RemoveWhere(pred);
                humanNumber = data.Count;
                statistics.HumansCarried(humansBefore - data.Count);
            }
        }

        public void RemoveHumans(Human humans)
        {
            if (humans != null && data.Contains(humans))
            {
                statistics.HumansCarried(1);
                data.Remove(humans);
                humanNumber--;
            }
        }
        internal void RemoveStatistics() { statistics = new LiftStatistics(); }
        internal void RemoveFireHumans()
        {
            if (data != null)
                foreach (Human h in data)
                    h.OnFire();
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

        public ILiftStatistics GetStatistics() => statistics;

        public int getHumanNumber() => humanNumber;

        public bool IsNotEmpty()
        {
            return data.Count > 0;
        }
    }
}
