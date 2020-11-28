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
            Humans a = new Humans(1, 0, 2);
            string aaa = Console.ReadLine();

            aaa = Console.ReadLine();
            a.Move();
            Console.WriteLine($"you wrote {aaa}");
            aaa = Console.ReadLine();
        }
    }
}
