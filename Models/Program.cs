using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Models.Entities;
using Models.Strategies;

namespace Models
{
    class Program
    {
        static void Main()
        {
            Simulation sim = new Simulation(3, 2, new MinWaitingTimeStrategy());
            SystemData data = sim.GetData();
            DataTable dataTable = new DataTable();
            DataColumn a1 = new DataColumn();
            DataColumn a2 = new DataColumn();
            DataColumn a3 = new DataColumn();
            DataColumn a4 = new DataColumn();
            dataTable.Columns.AddRange(new DataColumn[] { a1, a2, a3, a4 });
            DataRow row = dataTable.NewRow();
            row.ItemArray = new object[] { 1, 0, 1, 3 };
            dataTable.Rows.Add(row);
            data.ParseDataTable(dataTable);
            System.Threading.Timer timer = new System.Threading.Timer(new TimerCallback(tick), data, 0, 100);
            Thread th = Thread.CurrentThread;
            th.Join(3100);
            Console.WriteLine("We are here v1");
            th.Join(10000);
            Console.WriteLine("we are here");
            th.Join(11000);
        }
        private static void tick(object a)
        {
            ((SystemData)a).DoTick();
        }
    }
}