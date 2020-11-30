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
            List<Humans> list= new List<Humans>();
            
            Humans b1 = new Humans(1, 0, 2);
            Humans b2 = new Humans(2, 0, 2);
            Humans b3 = new Humans(3, 0, 2);
            list.Add(b1);
            list.Add(b3);
            string aaa = Console.ReadLine();
            a.AddHumans(b1);
            a.AddHumans(b2);
            a.AddHumans(b3);
            Console.WriteLine(a.EndTrip(list));
            aaa = Console.ReadLine();
            Console.WriteLine($"you wrote {aaa}");
            aaa = Console.ReadLine();
        }
    }
}
