using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Models.LiftManager;

namespace Models
{
    public class SystemData
    {
        HashSet<IKeepHuman> keepers = new HashSet<IKeepHuman>();
        HashSet<ITickable> factories = new HashSet<ITickable>();
        public SystemData(int floors, int lifts)
        {
            for (int i = 0; i < floors; i++)
                keepers.Add(new Floor(i));
            for (int i = 0; i < lifts; i++)
                keepers.Add(new Lift(i));
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
            factories.Add(creator);
        }

        public void DoTick()
        {
            foreach (var keeper in keepers)
                ((ITickable)keeper).DoTick();
            foreach (var fact in factories)
                fact.DoTick();
            factories.RemoveWhere(cr => cr is HumanCreator hcreator && hcreator.Disposing);
        }

        public void AddKeeper(IKeepHuman keeper)
        {
            if (keeper != null)
                keepers.Add(keeper);
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
        public void AddRangeKeepers(IEnumerable<IKeepHuman> keepers)
        {
            if (keepers != null)
                foreach(var keeper in keepers)
                    AddKeeper(keeper);
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

        public IEnumerable<Lift> GetLifts() => keepers.Where<IKeepHuman>(kep => kep is Lift).Cast<Lift>();
        public IEnumerable<Floor> GetFloors() => keepers.Where<IKeepHuman>(kep => kep is Floor).Cast<Floor>();

        public void RemoveKeeper(IKeepHuman keeper)
        {
            if (keeper != null)
                if (keepers.Contains(keeper))
                    this.keepers.Remove(keeper);
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

        public Floor GetFloorByNumber(int number)
        {
            if (number >= 0 && number < GetFloors().Count())
                return GetFloors().FirstOrDefault(f => f.getKeeperNumber() == number);
            else {
                Console.WriteLine("There is an Exception!");
                throw new Exception("There is no such a floor"); 
            }
        }
        public bool IsEverythingEmpty()
        {
            foreach (var keeper in keepers)
                if (keeper.IsNotEmpty())
                    return false;
            return true;
        }
    }
}