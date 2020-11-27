using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Humans : IMovable
    {
        Timer timer;
        private void Initialize(int humanNumber, int initFloor, int finiteFloor)
        {
            this.HumanNumber = humanNumber;
            this.InitFloor = initFloor;
            this.FiniteFloor = finiteFloor;
            timer = new Timer(new TimerCallback(tick), (object)(this.InitFloor == this.FiniteFloor), 0, 3000);
        }
        public Humans(int humanNumber,int initFloor,int finiteFloor) {
            Initialize(humanNumber, initFloor, finiteFloor);
        }
        public int HumanNumber;
        public int InitFloor { get; set; }
        public int FiniteFloor { get; set; }
        public void Move() { 
            this.InitFloor = this.FiniteFloor;
            timer.Dispose();
        }

        private void tick(object state) {
            if ((bool)state)
                timer.Dispose();
            Console.WriteLine("Hello  World!!!");
            return; 
        }
        
    }
}