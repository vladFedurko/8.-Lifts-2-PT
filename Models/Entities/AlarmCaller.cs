using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    class AlarmCaller : AResettable
    {
        ISimulation sim;
        int ticksToContinue;
        bool started = false;
        public AlarmCaller(ISimulation sim, int ticksToStart, int ticksToContinue) 
        {
            if (sim == null)
                return;
            this.sim = sim;
            this.ticksToNotify = ticksToStart;
            this.ticksToContinue = ticksToContinue;
        }
        protected override void Notify()
        {
            if (!started)
            {
                ticksToNotify = ticksToContinue;
                if(sim.TurnOnFireAlarm())
                    sim.GetMainService().UpdateFireAlarm();
                started = true;
            }
            else
            {
                if(sim.TurnOffFireAlarm())
                    sim.GetMainService().UpdateFireAlarm();
                CountPermission = false;
            }
        }
    }
}
