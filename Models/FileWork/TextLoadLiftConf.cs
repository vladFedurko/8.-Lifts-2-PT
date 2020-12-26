using Models.LiftManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            SimulationParameters simParam = new SimulationParameters();
            using (fileStream = new FileStream(path, FileMode.Open))
            {
                using (Reader = new StreamReader(fileStream))
                {
                    string o = Reader.ReadLine();
                    string[] a = o.Split(' ');
                    simParam.FloorsCount = Int32.Parse(a[0]);
                    //Assembly assembly = Assembly.GetExecutingAssembly();
                    Assembly assembly = Assembly.GetAssembly(typeof(ILiftManager));
                    //Assembly.LoadFrom("LiftManager.dll");
                    foreach (Type type in assembly.GetTypes().Where<Type>(t => t.GetInterface(typeof(ILiftManager).Name) != null))
                    {
                        if (a[1].Equals(type.FullName))
                            simParam.LiftManager = (ILiftManager)assembly.CreateInstance(type.FullName);
                    }
                    simParam.LiftsCapacity = Int32.Parse(a[2]);
                    simParam.LiftsCount = Int32.Parse(a[3]);
                    simParam.SecondsToMove = Int32.Parse(a[4]);
                    simParam.SecondsToWait = Int32.Parse(a[5]);
                    /*Console.WriteLine("Load completed " +
                        simParam.FloorsCount + " "
                        + simParam.LiftManager + " "
                        + simParam.LiftsCapacity + " "
                        + simParam.LiftsCount + " "
                        + simParam.SecondsToMove + " "
                        + simParam.SecondsToWait);*/
                }
            }
            return simParam;
        }
    }
}
