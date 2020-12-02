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
        public SystemData(List<Floor> floors,List<Lift> lifts)
        {
            Floors = floors;
            Lifts = lifts;
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

        public bool IsEverythingEmpty()
        {
            if (Floors.Count == 0 && Lifts.Count == 0)
                return true;
            return false;
        }
    }
}
