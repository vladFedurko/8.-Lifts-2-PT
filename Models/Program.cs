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
            /*Lift a = new Lift(0,2);
            Floor b1 = new Floor(1);
            Floor b0 = new Floor(0);
            Floor b2 = new Floor(2);
            Humans c1 = new Humans(1, 2);
            Humans c2 = new Humans(2, 0);
            Humans c3 = new Humans(3, 2);
            b1.AddHumans(c1);
            b1.AddHumans(c3);
            b1.AddHumans(c2);
            System.Threading.Timer timer = new System.Threading.Timer(new TimerCallback(tick), b1, 0, 100);
            System.Threading.Timer timera = new System.Threading.Timer(new TimerCallback(tickb), a, 0, 100);
            Thread th = Thread.CurrentThread;
            th.Join(3100);
            /*c1.setStateToOnfloors();
            c2.setStateToOnfloors();
            c3.setStateToOnfloors();*/
            /*Console.WriteLine("we are here");
            a.StartMoving();
            a.SetTargetFloor(1);
            th.Join(1100);
            a.liftState = Lift.LiftState.WaitOpened;
            a.SetTargetFloor(2);
            HumansMover.EnterLift(b1, a);
            IEnumerable<Humans> g = a.getHumans();
            foreach (Humans t in g)
                Console.WriteLine(t. + " " + t.FiniteFloor);
            Console.WriteLine();
            a.StartMoving();
            th.Join(1100);
            a.liftState = Lift.LiftState.WaitOpened;
            HumansMover.ExitLift(b2, a);
            foreach (Humans t in b2.getHumans())
                Console.WriteLine(t. + " " + t.FiniteFloor);
            Console.ReadLine();*/
            Thread th = Thread.CurrentThread;
            th.Join(31000);
        }
        /*private static void tickb(object a)
        {
            ((Lift)a).DoTick();
        }

        private static void tick(object a)
        {
            ((Floor)a).DoTick();
        }*/
    }
}