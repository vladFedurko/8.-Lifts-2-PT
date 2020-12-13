using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models
{
    public class SystemData
    {
        List<Floor> Floors = new List<Floor>();
        List<Lift> Lifts = new List<Lift>();
        List<HumanFactory> factories = new List<HumanFactory>();
        List<HumanCreator> creators = new List<HumanCreator>();
        public SystemData(int floors, int lifts)
        {
            for (int i = 0; i < floors; i++)
                Floors.Add(new Floor(i));
            for (int i = 0; i < lifts; i++)
                Lifts.Add(new Lift(i));
        }

        internal void ParseDataTable(DataTable dataTable)
        {
            DataRowCollection rows = dataTable?.Rows;
            factories.Clear();
            if (rows != null)
                foreach (DataRow row in rows)
                {
                    object[] a = row.ItemArray;
                    if (a.Length != 4)
                        return;
                    Floor floor = GetFloorByNumber(Int32.Parse(a[1].ToString()));
                    HumanFactory humanFactory = new HumanFactory(Int32.Parse(a[0].ToString()),
                        Int32.Parse(a[2].ToString()), Int32.Parse(a[3].ToString() + "0"), floor);
                    AddHumanFactory(humanFactory);
                    Console.WriteLine($"Factory added {a[0]} {a[1]} {a[2]} {a[3]}");
                }
        }

        /*internal void ParseDataTablev2(DataTable dataTable)
        {
            DataRowCollection rows = dataTable?.Rows;
            List<HumanFactory> newFactories = new List<HumanFactory>();
            if (rows != null)
                foreach (DataRow row in rows)
                {
                    object[] a = row.ItemArray;
                    if (a.Length != 4)
                        return;
                    Floor floor = GetFloorByNumber(Int32.Parse(a[1].ToString()));
                    HumanFactory humanFactory = new HumanFactory(Int32.Parse(a[0].ToString()),
                        Int32.Parse(a[2].ToString()), Int32.Parse(a[3].ToString() + "0"), floor);
                    Console.WriteLine($"Factory added {a[0]} {a[1]} {a[2]} {a[3]}");
                    if (!newFactories.Contains(humanFactory))
                        newFactories.Add(humanFactory);
                    else
                        newFactories.First(f => f.equals(humanFactory)).humanNumber += humanFactory.humanNumber;
                }
            factories.Union(newFactories);
        }*/
        public void CreateHuman(int initialFloor, int finitefloor, int inSec) {
            HumanCreator creator = new HumanCreator(finitefloor, inSec * 10, GetFloorByNumber(initialFloor));
            creators.Add(creator);
        }

        public void DoTick()
        {
            foreach (var lift in Lifts)
                lift.DoTick();
            foreach (var floor in Floors)
                floor.DoTick();
            foreach (var fact in factories)
                fact.DoTick();
            foreach (var creator in creators)
                creator.DoTick();
            creators.RemoveAll(cr => cr.Disposing);
        }

        public void AddFloor(Floor floor)
        {
            if (floor != null)
                Floors.Add(floor);
        }
        public void AddLift(Lift lift)
        {
            if (lift != null)
                Lifts.Add(lift);
        }
        internal void AddHumanFactory(HumanFactory fact)
        {
            if (fact != null)
                if (!factories.Contains(fact))
                    this.factories.Add(fact);
                else
                    factories.First(f => f.Equals(fact)).humanNumber += fact.humanNumber;
        }
        public void AddRangeFloors(List<Floor> floors)
        {
            if (floors != null)
                Floors.AddRange(floors);
        }
        public void AddRangeLifts(List<Lift> lifts)
        {
            if (lifts != null)
                Lifts.AddRange(lifts);
        }
        internal void AddRangeFactories(IEnumerable<HumanFactory> a)
        {
            if (a != null)
                foreach (var fact in a)
                {
                    this.AddHumanFactory(fact);
                }
        }
        public IEnumerable<Lift> GetLifts() => Lifts;
        public IEnumerable<Floor> GetFloors() => Floors;

        public void DeleteFloor(Floor floor)
        {
            if (floor != null)
                if (Floors.Contains(floor))
                    Floors.Remove(floor);
        }
        public void RemoveLift(Lift lift)
        {
            if (lift != null)
                if (Lifts.Contains(lift))
                    Lifts.Remove(lift);
        }
        internal void RemoveHumanFactory(HumanFactory fact)
        {
            if (fact != null)
                factories.Remove(fact);
        }
        internal void RemoveAllFactories()
        {
            if (factories != null)
                factories.Clear();
        }

        public Floor GetFloorByNumber(int number)
        {
            return Floors.FirstOrDefault(f => f.getKeeperNumber() == number);
        }
        public bool IsEverythingEmpty()
        {
            foreach (var floor in Floors)
                if (floor.HumanNumberDown != 0 || floor.HumanNumberUp != 0)
                    return false;
            foreach (var lift in Lifts)
                if (lift.humanNumber != 0)
                    return false;
            return true;
        }
    }
}