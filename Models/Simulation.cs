﻿using Models.Entities;
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
            observer = new Observer(this);
        }

        public void ChangeStrategy(IStrategy st)
        {
            strategy = st;
        }

        public void Pause()
        {
            observer.Stop();
        }

        public void Stop()
        {
            if(systemData.IsEverythingEmpty())
                observer.Stop();
        }
        public void Start()
        {
            observer.Start();
        }

        public SystemData GetData() => systemData;

        public void doTick()
        {
            //strategy.ManageLifts(systemData);
            foreach (var floor in systemData.GetFloors())
                floor.DoTick();
        }
    }
}
