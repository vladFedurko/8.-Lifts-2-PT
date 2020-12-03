﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Models.Entities;

namespace Models
{
    class Program
    {
        
        static void Main() 
        {
            Lift a = new Lift(0,2);
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
            Thread th = Thread.CurrentThread;
            th.Join(5000);
            /*c1.setStateToOnfloors();
            c2.setStateToOnfloors();
            c3.setStateToOnfloors();*/
            Console.WriteLine("we are here");
            a.directionUp = false;
            a.liftState = Lift.LiftState.Moving;
            a.Move();
            a.liftState = Lift.LiftState.WaitOpened;
            a.directionUp = true;
            HumansMover.EnterLift(b1, a);
            a.liftState = Lift.LiftState.Moving;
            IEnumerable<Humans> g = a.getHumans();
            foreach (Humans t in g)
                Console.WriteLine(t.HumanNumber + " " + t.FiniteFloor);
            Console.WriteLine();
            a.Move();
            a.liftState = Lift.LiftState.WaitOpened;
            HumansMover.ExitLift(b2, a);
            foreach (Humans t in b2.getHumans())
                Console.WriteLine(t.HumanNumber + " " + t.FiniteFloor);
            Console.ReadLine();
        }

        private static void tick(object a)
        {
            ((Floor)a).DoTick();
        }
    }
}
/*
            Predicate<Floor> isPositive = delegate (Floor x) { return x.getKeeperFloor() == number; };
            Floors.Find(isPositive);
            */