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
            Lift a = new Lift();
            string aaa = Console.ReadLine();
            AMovable.SetTickTime(10000);
            aaa = Console.ReadLine();
            Console.WriteLine($"you wrote {aaa}");
            aaa = Console.ReadLine();
        }
    }
}
