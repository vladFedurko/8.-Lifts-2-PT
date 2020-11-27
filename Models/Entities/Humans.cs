using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Models.Entities
{
    class Humans : IMovable
    {
        Timer timer;
        public Humans(int humanNumber,int initFloor,int finiteFloor) {
            this.HumanNumber = humanNumber;
            this.InitFloor = initFloor;
            this.FiniteFloor = finiteFloor;
            timer = new Timer(new TimerCallback(tick), (object)(this.InitFloor==this.FiniteFloor), 0, 3000);
        }
        public int HumanNumber;
        public int InitFloor { get; }
        public int FiniteFloor { get; }
        public void Move() { return; }

        private void tick(object state) {
            if ((bool)state)
                timer = null;
            Console.WriteLine("Hello  World!!!");
            return; 
        }
        
    }
}