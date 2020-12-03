using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Simulation : ISimulation
    {
        protected SystemData systemData;
        protected IStrategy strategy;
        protected Observer observer;

        internal Simulation(int initialFloorsNumber, int initialLiftNumber, IStrategy _strategy)
        {
            systemData = new SystemData(initialFloorsNumber, initialLiftNumber);
            strategy = _strategy;
            observer = new Observer();
        }

        public void ChangeStrategy(IStrategy st)
        {
            strategy = st;
        }

        public void StopSimulation()
        {
            if(systemData.IsEverythingEmpty())
                observer.Stop();
        }

        public SystemData GetData() => systemData;

        public void doTick()
        {

        }
    }
}
