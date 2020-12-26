using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    class TextSaveGenTable : ATextSave
    {
        StreamWriter Writer;
        FileStream fileStream;
        public override void Save(string path, object o)
        {
            using (fileStream = new FileStream(path, FileMode.Create))
            {
                using (Writer = new StreamWriter(fileStream))
                {
                    DataTable dataTable = (DataTable)o;
                    foreach (DataRow row in dataTable.Rows)
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
                            continue;
                        }
                        int a0 = Int32.Parse(a[0].ToString());
                        int a1 = Int32.Parse(a[1].ToString());
                        int a2 = Int32.Parse(a[2].ToString());
                        int a3 = Int32.Parse(a[3].ToString());
                        if (a1 == a2)
                        {
                            continue;
                        }
                        Writer.WriteLine(a0 + " " + a1 + " " + a2 + " " + a3);
                        //Console.WriteLine($"Save added {a[0]} {a[1]} {a[2]} {a[3]}");
                    }
                }
            }
        }
    }
}

