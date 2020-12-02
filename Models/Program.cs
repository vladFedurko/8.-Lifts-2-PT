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
            Floor a = new Floor(0);
            List<Humans> list= new List<Humans>();
            
            Humans b1 = new Humans(1, 2, a);
            Humans b2 = new Humans(2, 2, a);
            Humans b3 = new Humans(3, 2, a);
            Lift b = new Lift(0);
            list.Add(b1);
            list.Add(b3);
            string aaa = Console.ReadLine();
            a.AddHumans(b1);
            a.AddHumans(b2);
            a.AddHumans(b3);
        }
    }
}
