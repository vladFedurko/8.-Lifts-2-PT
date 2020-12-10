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

        public HumanCreationService(SystemData data)
        {
            this.data = data;
        }

        public void CreateHuman(int initialFloor, int finiteFloor, int inSeconds)
        {
            data.CreateHuman(initialFloor, finiteFloor, inSeconds);
        }

        public void CreateHumanGenerationTable(DataTable dataTable)
        {
            ParseDataTable(dataTable);
        }

        internal void ParseDataTable(DataTable dataTable)
        {
            DataRowCollection rows = dataTable?.Rows;
            data.RemoveAllFactories();
            if (rows != null)
                foreach (DataRow row in rows)
                {
                    object[] a = row.ItemArray;
                    if (a.Length != 4)
                        return;
                    Floor floor = data.GetFloorByNumber(Int32.Parse(a[1].ToString()));
                    HumanFactory humanFactory = new HumanFactory(Int32.Parse(a[0].ToString()),
                        Int32.Parse(a[2].ToString()), Int32.Parse(a[3].ToString() + "0"), floor);
                    data.AddHumanFactory(humanFactory);
                    Console.WriteLine($"Factory added {a[0]} {a[1]} {a[2]} {a[3]}");
                }
        }
    }
}
