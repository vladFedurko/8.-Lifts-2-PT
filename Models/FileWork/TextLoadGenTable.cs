using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    class TextLoadGenTable : ATextLoad
    {
        StreamReader Reader;
        FileStream fileStream;
        private void InitTable(out DataTable dTable)
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
        public override object Load(string path)
        {
            DataTable dataTable;
            InitTable(out dataTable);
            using (fileStream = new FileStream(path, FileMode.Open))
            {
                using (Reader = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = Reader.ReadLine()) != null)
                    {
                        DataRow row = dataTable.NewRow();
                        row.ItemArray = line.Split(' ');
                        if (row.ItemArray.Length != 4)
                            return null;
                        dataTable.Rows.Add(row);
                    }
                }
            }
            return dataTable;
        }
    }
}
