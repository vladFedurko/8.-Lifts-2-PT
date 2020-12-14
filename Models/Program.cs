using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Models.Entities;
using Models.LiftManager;

namespace Models
{
    class Program
    {
        static void Main()
        {
            SystemData data = new SystemData(2, 1);
            data.CreateHuman(0, 1, 0);
            
            Thread th = Thread.CurrentThread;
            System.Threading.Timer timer = new System.Threading.Timer(new TimerCallback(tick), data, 0, 100);
            th.Join(5100);
            timer.Dispose();
            data.GetLifts().ToList().Find(l => l.Floor == 0).OpenDoor();
            data.GetLifts().ToList().Find(l => l.Floor == 0).SetTargetFloor(1);
            Console.WriteLine("hello world");
            HumansMover.MoveHumans(data);
        }
        private static void tick(object a)
        {
            ((SystemData)a).DoTick();
        }
    }
}