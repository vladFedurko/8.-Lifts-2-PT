using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Floor : IKeepHuman , ITickable
    {
        HashSet<Human> Humans = new HashSet<Human>();
        int FloorNumber;
        internal int HumanNumberUp;
        internal int HumanNumberDown;
        internal Floor(int FloorNumber)
        {
            this.FloorNumber = FloorNumber;
        }
        public IEnumerable<Human> getHumans()
        {
            return Humans;
        }

        public void AddHumans(Human humans)
        {
            if (humans != null)
            {
                this.Humans.Add(humans);
                humans.ChangeState();
                if (humans.FiniteFloor > FloorNumber)
                    HumanNumberUp += 1;
                else if (humans.FiniteFloor < FloorNumber)
                    HumanNumberDown += 1;
            }
        }

        public void RemoveHumans(Human humans)
        {
            if (humans != null)
            {
                Humans.Remove(humans);
                if (humans.FiniteFloor > FloorNumber)
                    HumanNumberUp -= 1;
                else if (humans.FiniteFloor < FloorNumber)
                    HumanNumberDown -= 1;
            }
        }

        public void RemoveSomeHumans(Predicate<Human> pred)
        {
            if (pred != null)
            {
                this.Humans.RemoveWhere(pred);
                HumanNumberUp = 0;
                HumanNumberDown = 0;
                foreach (Human i in Humans)
                    if (i.FiniteFloor > FloorNumber)
                        HumanNumberUp += 1;
                    else if (i.FiniteFloor < FloorNumber)
                        HumanNumberDown += 1;
            }
        }
        internal void RemoveAllHumans()
        {
            if (Humans != null)
                Humans.Clear();
            HumanNumberDown = 0;
            HumanNumberUp = 0;
        }

        public int getKeeperNumber()
        {
            return FloorNumber;
        }
        public int getKeeperFloor()
        {
            return FloorNumber;
        }
        public void AddRangeHumans(IEnumerable<Human> a)
        {
            if (a != null)
                foreach (var humans in a)
                {
                    this.AddHumans(humans);
                }
        }

        public void DoTick()
        {
            if (Humans != null)
                foreach (var hum in Humans)
                    hum.DoTick();
                RemoveSomeHumans(hum => hum.state == Human.HumanState.DisposeNow);
        }

        public int getHumanNumberUp() => HumanNumberUp;
        public int getHumanNumberDown() => HumanNumberDown;
        public int getHumanNumber() => HumanNumberUp + HumanNumberDown;
        public int getFullHumanNumber() => Humans.Count;
        public bool IsNotEmpty()
        {
            return Humans.Count > 0;
        }
    }
}
