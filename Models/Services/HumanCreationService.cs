using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Services
{
    public class HumanCreationService : IHumanCreationService
    {
        private SystemData data;
        private DataTable dataTable1;
        Type type;

        public HumanCreationService(SystemData data)
        {
            this.data = data;
            InitTable(out dataTable1);
            type = new HumanFactory(0, 1, int.MaxValue, null).GetType();
        }

        public void CreateHuman(int initialFloor, int finiteFloor, int inSeconds)
        {
            if (initialFloor == finiteFloor)
                throw new Exception("Person is already on the destination floor!");
            data.CreateHuman(initialFloor, finiteFloor, inSeconds);
        }
        public void InitTable(out DataTable dTable)
        {
            dTable = new DataTable();
            DataColumn numberOfGeneratedPeopleColumn = new DataColumn("Number of generated humans", Type.GetType("System.Int32"));
            DataColumn initialFloorColumn = new DataColumn("Initial floor", Type.GetType("System.Int32"));
            DataColumn finiteFloorColumn = new DataColumn("Finite floor", Type.GetType("System.Int32"));
            DataColumn inSecondsColumn = new DataColumn("In (seconds)", Type.GetType("System.Int32"));
            dTable.Columns.AddRange(new DataColumn[] {numberOfGeneratedPeopleColumn,
                initialFloorColumn,
                finiteFloorColumn,
                inSecondsColumn});
        }


        public void CreateHumanGenerationTable(DataTable dataTable)
        {
            ParseDataTable(dataTable);
        }

        internal void ParseDataTable(DataTable dataTable)
        {
            DataRowCollection rows = dataTable?.Rows;
            int ExcCount = 0;
            string Exceptions = "";
            data.RemoveFactoriesOfType(type);
            if (rows != null)
                foreach (DataRow row in rows)
                {
                    object[] a = row.ItemArray;
                    if (a.Length != 4)
                        return;
                    if (a[0].GetType() == DBNull.Value.GetType() ||
                        a[1].GetType() == DBNull.Value.GetType() ||
                        a[2].GetType() == DBNull.Value.GetType() ||
                        a[3].GetType() == DBNull.Value.GetType()
                        )
                    {
                        ExcCount++;
                        Exceptions += "Some data is missed!\n";
                        continue;
                    }
                    int a0 = Int32.Parse(a[0].ToString());
                    int a1 = Int32.Parse(a[1].ToString());
                    int a2 = Int32.Parse(a[2].ToString());
                    int a3 = Int32.Parse(a[3].ToString());
                    if (a1 == a2)
                    {
                        ExcCount++;
                        Exceptions +="Person is already on the destination floor!\n";
                        continue;
                    }
                    try
                    {
                        Floor floor = data.GetFloorByNumber(a1 - 1);
                        Floor Finitefloor = data.GetFloorByNumber(a2 - 1);
                        HumanFactory humanFactory = new HumanFactory(a0,
                            a2 - 1, a3 * TickTimer.TICKS_PER_SECOND, floor);
                        data.AddHumanFactory(humanFactory);
                        Console.WriteLine($"Factory added {a[0]} {a[1]} {a[2]} {a[3]}");
                    }
                    catch (Exception e) {
                        Exceptions += e.Message;
                        Exceptions += "\n";
                    }
                }
            if(!(Exceptions.Equals("") && ExcCount==0))
                throw new Exception($"{ExcCount} rows deleted according to rules:\n"+ Exceptions);
        }

        public Floor GetFloorByNumber(int num)
        {
            return data.GetFloorByNumber(num);
        }

        public Lift GetLiftByNumber(int num)
        {
            return data.GetLifts().FirstOrDefault(l => l.getKeeperNumber() == num);
        }

        public DataTable GetHumanGenerationTable()
        {
            IEnumerable<HumanFactory> facts = data.GetFactoriesOfType(type).Cast<HumanFactory>();
            dataTable1.Clear();
            foreach (var fact in facts)
            {
                DataRow row = dataTable1.NewRow();
                row.ItemArray = new object[] { fact.humanNumber,
                    fact.floor.getKeeperFloor() + 1,
                    fact.FiniteFloor + 1,
                    fact.getTicksToNotify()/TickTimer.TICKS_PER_SECOND };
                dataTable1.Rows.Add(row);
            }
            return dataTable1;
        }
    }
}
