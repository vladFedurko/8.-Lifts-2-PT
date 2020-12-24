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

namespace Models
{
    class Program
    {
        static void Main()
        {
            DataTable dat;
            InitTable(out dat);
            DataRow row = dat.NewRow();
            row.ItemArray = new object[] { 12, 23, 34, 45 };
            dat.Rows.Add(row);
            TextSaveGenTable b = new TextSaveGenTable();
            b.Save("Ass.txt", dat);
            TextLoadGenTable d = new TextLoadGenTable();
            DataTable c = (DataTable)d.Load("Ass.txt");
            foreach (DataRow row1 in c.Rows)
                foreach (object a in row.ItemArray)
                    Console.WriteLine(a);
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