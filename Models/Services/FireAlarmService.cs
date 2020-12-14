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
        private static FireAlarmService instance;

        private FireAlarmService(ISimulation sim)
        {
            this.sim = sim;
        }
        public static FireAlarmService GetInstance(ISimulation sim)
        {
            if (instance == null)
                instance = new FireAlarmService(sim);
            return instance;
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
            data.RemoveFactoriesOfType(new AlarmCaller(null,int.MaxValue,int.MaxValue).GetType());
            if (rows != null)
                foreach (DataRow row in rows)
                {
                    object[] a = row.ItemArray;
                    if (a.Length != 2)
                        return;
                    AlarmCaller caller = new AlarmCaller(sim,Int32.Parse(a[0].ToString())*TickTimer.TICKS_PER_SECOND,
                        Int32.Parse(a[1].ToString()) * TickTimer.TICKS_PER_SECOND);
                    data.AddFactory(caller);
                    Console.WriteLine($"Caller added {a[0]} {a[1]}");
                }
        }
    }
}

