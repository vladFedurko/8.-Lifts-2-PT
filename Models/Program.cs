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
            Humans b = new Humans(1, 0, 2);
            string aaa = Console.ReadLine();
            a.MoveTo(5);
            Console.WriteLine(a.Floor);
            Console.WriteLine(b.Floor);
            b.MoveTo(6);
            Console.WriteLine(b.Floor);
            Console.WriteLine(a.Floor);
            aaa = Console.ReadLine();
            Console.WriteLine($"you wrote {aaa}");
            aaa = Console.ReadLine();
        }
    }
}
