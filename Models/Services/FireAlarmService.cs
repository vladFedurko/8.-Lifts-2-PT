using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public class FireAlarmService : IPlanFireAlarm
    {
        private ISimulation sim;
        private DataTable dataTable1;
        Type type;

        public FireAlarmService(ISimulation sim)
        {
            this.sim = sim;
            InitTable(out dataTable1);
            type = new AlarmCaller(null, int.MaxValue, int.MaxValue).GetType();
        }
        public void InitTable(out DataTable dTable)
        {
            dTable = new DataTable();
            DataColumn startColumn = new DataColumn("Start at(seconds)", Type.GetType("System.Int32"));
            DataColumn finiteColumn = new DataColumn("Finite at(seconds)", Type.GetType("System.Int32"));
            dTable.Columns.Add(startColumn);
            dTable.Columns.Add(finiteColumn);
        }
        public void StartAlarm()
        {
            sim.TurnOnFireAlarm();
        }
        public void StopAlarm()
        {
            sim.TurnOffFireAlarm();
        }

        public void CreateAlarmRule(DataTable dataTable)
        {
            ParseDataTable(dataTable);
        }

        internal void ParseDataTable(DataTable dataTable)
        {
            DataRowCollection rows = dataTable?.Rows;
            SystemData data = sim.GetData();
            int ExcCount = 0;
            string Exceptions = "";
            data.RemoveFactoriesOfType(type);
            if (rows != null)
                foreach (DataRow row in rows)
                {
                    object[] a = row.ItemArray;
                    if (a.Length != 2)
                        return;
                    if (a[0].GetType() == DBNull.Value.GetType() ||
                        a[1].GetType() == DBNull.Value.GetType())
                    {
                        ExcCount++;
                        Exceptions += "Person is already on the destination floor!\n";
                        continue;
                    }
                    int a0 = Int32.Parse(a[0].ToString());
                    int a1 = Int32.Parse(a[1].ToString());
                    AlarmCaller caller = new AlarmCaller(sim, a0 * TickTimer.TICKS_PER_SECOND,
                        a1 * TickTimer.TICKS_PER_SECOND);
                    data.AddFactory(caller);
                    Console.WriteLine($"Caller added {a[0]} {a[1]}");
                }
            if(!(ExcCount==0 && Exceptions.Equals("")))
                throw new Exception($"{ExcCount} rows deleted according to reasons:\n"+ Exceptions);
        }

        public DataTable GetFireAlarmTable()
        {
            IEnumerable<AlarmCaller> facts = sim.GetData().GetFactoriesOfType(type).Cast<AlarmCaller>();
            foreach (var fact in facts)
            {
                DataRow row = dataTable1.NewRow();
                if (fact.started == false)
                    row.ItemArray = new object[]
                        { fact.getTicksToNotify()/ TickTimer.TICKS_PER_SECOND,
                    fact.ticksToContinue / TickTimer.TICKS_PER_SECOND};
                else
                    row.ItemArray = new object[]
                        { fact.ticksToContinue / TickTimer.TICKS_PER_SECOND,
                    fact.getTicksToNotify()/ TickTimer.TICKS_PER_SECOND };
                dataTable1.Rows.Add(row);
            }
            return dataTable1;
        }
    }
}

