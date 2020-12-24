using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    class TextSaveLiftConf :ATextSave
    {
        StreamWriter Writer;
        FileStream fileStream;

        public override void Save(string path, object o)
        {
            using (fileStream = new FileStream(path, FileMode.Create))
            {
                using (Writer = new StreamWriter(fileStream))
                {
                    SimulationParameters dataTable = (SimulationParameters)o;
                    Writer.WriteLine(
                        dataTable.FloorsCount + " "
                        + dataTable.LiftManager + " " 
                        + dataTable.LiftsCapacity + " " 
                        + dataTable.LiftsCount+" "
                        +dataTable.SecondsToMove+" "
                        +dataTable.SecondsToWait+" "
                        );
                    Console.WriteLine("Save added "+ 
                        dataTable.FloorsCount+" "
                        + dataTable.LiftManager + " "
                        + dataTable.LiftsCapacity + " "
                        + dataTable.LiftsCount + " "
                        + dataTable.SecondsToMove + " "
                        + dataTable.SecondsToWait + " ");
                }
            }
        }
    }
}
