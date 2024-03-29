﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    class AlarmCaller : AResettable
    {
        ISimulation sim;
        internal int ticksToContinue { get; private set; }
        internal bool started = false;
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
                int a;
                a = ticksToNotify;
                ticksToNotify = ticksToContinue;
                ticksToContinue = a;
                sim.TurnOnFireAlarm();
                started = true;
            }
            else
            {
                sim.TurnOffFireAlarm();
                CountPermission = false;
            }
        }
    }
}
