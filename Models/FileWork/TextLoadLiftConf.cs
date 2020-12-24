using Models.LiftManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    class TextLoadLiftConf : ATextLoad
    {
        StreamReader Reader;
        FileStream fileStream;
        public override object Load(string path)
        {
            SimulationParameters dataTable = new SimulationParameters();
            using (fileStream = new FileStream(path, FileMode.Open))
            {
                using (Reader = new StreamReader(fileStream))
                {
                    string o = Reader.ReadLine();
                    string[] a = o.Split(' ');
                    dataTable.FloorsCount = Int32.Parse(a[0]);
                    MinWaitingTimeLiftManager choose1 = new MinWaitingTimeLiftManager();
                    MinIdlingTimeLiftManager choose2 = new MinIdlingTimeLiftManager();
                    //стоило бы попробовать использовать рефлексию на наследование от ILiftManager с его созданием
                    if (a[1].Equals(choose1.GetType().FullName))
                        dataTable.LiftManager = new MinWaitingTimeLiftManager();
                    else if (a[1].Equals(choose2.GetType().FullName))
                        dataTable.LiftManager = new MinIdlingTimeLiftManager();
                    /*else 
                        throw new ClassNotMatchedException*/
                    dataTable.LiftsCapacity = Int32.Parse(a[2]);
                    dataTable.LiftsCount = Int32.Parse(a[3]);
                    dataTable.SecondsToMove = Int32.Parse(a[4]);
                    dataTable.SecondsToWait = Int32.Parse(a[5]);
                    Console.WriteLine("Load completed " +
                        dataTable.FloorsCount + " "
                        + dataTable.LiftManager + " "
                        + dataTable.LiftsCapacity + " "
                        + dataTable.LiftsCount + " "
                        + dataTable.SecondsToMove + " "
                        + dataTable.SecondsToWait + " ");
                }
            }
            return dataTable;
        }
    }
}
