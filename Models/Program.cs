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
            Console.WriteLine("Hello world");
            Lift a = new Lift(0);
            Lift b = Copy(a);
            Floor c = new Floor(0);
            Floor e = new Floor(1);
            Humans d = new Humans(1, 0, c);
            Console.ReadLine();
            d.changeKeeper(a);
            Console.ReadLine();
            d.changeKeeper(e);
            Console.WriteLine(a.Equals(b));
            Console.ReadLine();
        }
        static Lift Copy(Lift a) {
            return a;
        }
    }
}
