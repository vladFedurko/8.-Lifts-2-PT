using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Models.Entities;
using Models.LiftManager;
using Models.Services;

namespace Models
{
    class Program
    {
        static void Main()
        {
            DataTable dataTable =new DataTable();
            DataColumn a = new DataColumn();
            DataColumn b = new DataColumn();
            dataTable.Columns.Add(a);
            dataTable.Columns.Add(b);
            DataRow row = dataTable.NewRow();
            row.ItemArray = new object[] { 1, 2 };
            dataTable.Rows.Add(row);
            Simulation sim = new Simulation(2, 1, new MinWaitingTimeLiftManager());
            sim.GetData().AddFactory(new AlarmCaller(sim, 50, 30));
            FireAlarmService serv = FireAlarmService.GetInstance(sim);
            serv.ParseDataTable(dataTable);
            sim.Start();
        }
        private static void tick(object a)
        {
            ((SystemData)a).DoTick();
        }
    }
}