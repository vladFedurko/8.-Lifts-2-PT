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
        List<Floor> Floors = new List<Floor>();
        List<Lift> Lifts = new List<Lift>();
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

        public IEnumerable<Lift> GetLifts() => new List<Lift>(Lifts);
        public IEnumerable<Floor> GetFloors() => new List<Floor>(Floors);

        public void DeleteFloor(Floor floor)
        {
            Floors.Remove(floor);
        }
        public void RemoveLift(Lift lift)
        {
            Lifts.Remove(lift);
        }
    }
}
