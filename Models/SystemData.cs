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
        public SystemData(int floors, int lifts)
        {
            for (int i = 0; i < floors; i++)
                Floors.Add(new Floor(i));
            for (int i = 0; i < lifts; i++)
                Lifts.Add(new Lift(i));
        }

        internal void ParseDataTable(DataTable dataTable)
        {
            foreach (Floor floor in Floors)
                floor.RemoveAllFactories();
            DataRowCollection rows = dataTable?.Rows;
            if (rows != null)
                foreach (DataRow row in rows)
                {
                    object[] a = row.ItemArray;
                    if (a.Length != 4)
                        return;
                    HumanFactory humanFactory = new HumanFactory(Int32.Parse(a[0].ToString()),
                        Int32.Parse(a[2].ToString()), Int32.Parse(a[3].ToString()+"0"));
                    Floor floor = GetFloorByNumber(Int32.Parse(a[1].ToString()));
                    floor.AddHumanFactory(humanFactory);
                    Console.WriteLine($"Factory added {a[0]} {a[1]} {a[2]} {a[3]}");
                }
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

        public Floor GetFloorByNumber(int number)
        {
            return Floors.FirstOrDefault(f => f.getKeeperNumber() == number);
        }
        public bool IsEverythingEmpty()
        {
            if (Floors.Count == 0 && Lifts.Count == 0)
                return true;
            return false;
        }
    }
}