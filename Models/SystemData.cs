using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models
{
    public class SystemData
    {
        List<Floor> Floors;
        List<Lift> Lifts;
        public SystemData(int floors,int lifts)
        {
            Floors = new List<Floor>(floors);
            for (int i=0;i<floors;i++)
                Floors[i] = new Floor(i);
            Lifts = new List<Lift>(lifts);
            for (int i = 0; i < lifts; i++)
                Lifts[i] = new Lift(i);
        }

        public void AddFloor(Floor floor) {
            Floors.Add(floor);
        }
        public void AddLift(Lift lift)
        {
            Lifts.Add(lift);
        }
        public void AddRangeFloors(List<Floor> floors)
        {
            Floors.AddRange(floors);
        }
        public void AddRangeLifts(List<Lift> lifts)
        {
            Lifts.AddRange(lifts);
        }

        public IEnumerable<Lift> GetLifts() => Lifts;
        public IEnumerable<Floor> GetFloors() => Floors;

        public void DeleteFloor(Floor floor)
        {
            Floors.Remove(floor);
        }
        public void RemoveLift(Lift lift)
        {
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