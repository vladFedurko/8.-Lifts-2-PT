using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Models.Entities;
using Models.FileWork;
using Models.LiftManager;
using Models.Services;
using System.Reflection;

namespace Models
{
    class Program
    {
        static void Main()
        {
            Assembly a = Assembly.GetExecutingAssembly();
            Assembly b = Assembly.GetEntryAssembly();
            Assembly c = Assembly.GetCallingAssembly();
            Assembly d = Assembly.GetAssembly(typeof(MinIdlingTimeLiftManager));
            Assembly e = Assembly.Load("Models");
            foreach(Type type in a.GetTypes())
                Console.WriteLine(type.FullName);
            Console.WriteLine();
            foreach (Type type in b.GetTypes())
                Console.WriteLine(type.FullName);
            Console.WriteLine();
            foreach (Type type in c.GetTypes())
                Console.WriteLine(type.FullName);
            Console.WriteLine();
            foreach (Type type in d.GetTypes())
                Console.WriteLine(type.FullName);
            Console.WriteLine();
            foreach (Type type in e.GetTypes())
                Console.WriteLine(type.FullName);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void InitTable(out DataTable dTable)
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
    }
}