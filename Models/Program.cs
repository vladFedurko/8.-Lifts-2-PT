using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models
{
    class Program
    {
        static void Main() 
        {
            Lift a = new Lift(0,0);
            Floor b1 = new Floor(1);
            Floor b0 = new Floor(0);
            Floor b2 = new Floor(2);
            Humans c1 = new Humans(1, 2);
            Humans c2 = new Humans(2, 0);
            Humans c3 = new Humans(3, 2);
            b1.AddHumans(c1);
            b1.AddHumans(c3);
            b1.AddHumans(c2);
            a.MoveUp();
            HumansMover d = new HumansMover();
            d.EnterLift(b1, a);
            IEnumerable<Humans> g = a.getHumans();
            foreach (var t in g)
                Console.WriteLine(t.HumanNumber + " " + t.FiniteFloor);
            Console.WriteLine();
            a.MoveUp();
            d.ExitLift(b2, a);
            foreach (var t in b2.getHumans())
                Console.WriteLine(t.HumanNumber + " " + t.FiniteFloor);
            Console.ReadLine();
        }
    }
}
/*
            Predicate<Floor> isPositive = delegate (Floor x) { return x.getKeeperFloor() == number; };
            Floors.Find(isPositive);
            */