using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Models.Entities.Statistics;
using Models.LiftManager;

namespace Models
{
    public class SystemData
    {
        HashSet<ITickable> factories = new HashSet<ITickable>();
        List<Floor> Floors = new List<Floor>();
        List<Lift> Lifts = new List<Lift>();
        private ISimulationParameters parameters;
        private IHumanFullStatistics humanStatistics;
        private IFireAlarmStatistics fireAlarmStatistics;

        public SystemData(ISimulationParameters parameters)
        {
            this.parameters = parameters;
            this.CreateKeepers();
            this.humanStatistics = new HumanFullStatistics();
            this.fireAlarmStatistics = new FireAlarmStatistics();
        }

        public void SetSimulationParameters(ISimulationParameters parameters)
        {
            Floors.Clear();
            Lifts.Clear();
            this.parameters = parameters;
            Floors = new List<Floor>(parameters.FloorsCount);
            Lifts = new List<Lift>(parameters.LiftsCount);
            this.CreateKeepers();
        }
        public int getCarriedHumansNumber() 
        { 
            int i = 0;
            foreach (Lift lift in Lifts) 
            {
                i += lift.GetStatistics().GetCountOfCarriedHumans();
            }
            return i;
        }

        public ISimulationParameters GetParameters()
        {
            return parameters;
        }

        public void CreateKeepers()
        {
            for (int i = 0; i < parameters.FloorsCount; i++)
                Floors.Add(new Floor(i));
            for (int i = 0; i < parameters.LiftsCount; i++)
                Lifts.Add(new Lift(i,
                    parameters.SecondsToMove*TickTimer.TICKS_PER_SECOND,
                    parameters.SecondsToWait*TickTimer.TICKS_PER_SECOND)
                    );
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

        public void CreateHuman(int humanNumber,int initialFloor, int finitefloor, int inSec) {
            HumanCreator creator = new HumanCreator(humanNumber,finitefloor, inSec * TickTimer.TICKS_PER_SECOND, GetFloorByNumber(initialFloor));
            factories.Add(creator);
        }

        public IHumanFullStatistics GetHumanStatistics() => humanStatistics;

        public IFireAlarmStatistics GetFireAlarmStatistics() => fireAlarmStatistics;

        public void DoTick()
        {
            foreach (var fl in Floors)
                fl.DoTick();
            foreach (var lift in Lifts)
                lift.DoTick();
            foreach (var fact in factories)
                    fact.DoTick();
            factories.RemoveWhere(cr => cr is HumanCreator hcreator && hcreator.Disposing);
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

        internal void AddFactory(ITickable fact)
        {
            if (fact != null)
                factories.Add(fact);
        }

        internal void AddHumanFactory(HumanFactory fact)
        {
            if (fact != null)
                if (!factories.Contains(fact))
                    this.factories.Add(fact);
                else
                    ((HumanFactory)factories.First(f => ((HumanFactory)f).Equals(fact))).humanNumber += fact.humanNumber;
        }

        public void AddRangeFloors(IEnumerable<Floor> floors)
        {
            if (floors != null)
                foreach(var fl in floors)
                    AddFloor(fl);
        }

        public void AddRangeLifts(IEnumerable<Lift> lifts)
        {
            if (lifts != null)
                foreach (var lift in lifts)
                    AddLift(lift);
        }

        internal void AddRangeFactories(IEnumerable<ITickable> a)
        {
            if (a != null)
                foreach (var fact in a)
                {
                    if (fact is HumanFactory hfactory)
                        this.AddHumanFactory(hfactory);
                    else
                        this.AddFactory(fact);
                }
        }

        public IEnumerable<Lift> GetLifts() => Lifts;
        public IEnumerable<Floor> GetFloors() => Floors;
        public IEnumerable<ITickable> GetFactoriesOfType(Type type)
        {
            return factories.Where<ITickable>(fact => fact.GetType() == type);
        }

        public void RemoveFloor(Floor floor)
        {
            if (floor != null)
                if (Floors.Contains(floor))
                    this.Floors.Remove(floor);
        }

        public void RemoveLift(Lift lift)
        {
            if (lift != null)
                if (Lifts.Contains(lift))
                    this.Lifts.Remove(lift);
        }

        internal void RemoveFactory(ITickable fact)
        {
            if (fact != null)
                factories.Remove(fact);
        }

        internal void RemoveFactoriesOfType(Type type)
        {
            factories.RemoveWhere(fact1=> fact1.GetType() == type);
        }

        internal void RemoveAllFactories()
        {
            if (factories != null)
                factories.Clear();
        }

        internal void RemoveAllStatistics() {
            this.humanStatistics = new HumanFullStatistics();
            this.fireAlarmStatistics = new FireAlarmStatistics();
            foreach (Lift lift in Lifts)
                lift.RemoveStatistics();
        }

        public Floor GetFloorByNumber(int number)
        {
            if (number >= 0 && number < GetFloors().Count())
                return GetFloors().FirstOrDefault(f => f.getKeeperNumber() == number);
            else
            {
                throw new Exception($"There is no such a floor:{number+1}");
            }
        }

        public bool IsEverythingEmpty()
        {
            foreach (var floor in Floors)
                if (floor.IsNotEmpty())
                    return false;
            foreach (var lift in Lifts)
                if (lift.IsNotEmpty())
                    return false;
            return true;
        }
    }
}