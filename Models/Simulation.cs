using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Services;

namespace Models
{
    public class Simulation : ISimulation
    {
        protected SystemData systemData;
        protected IStrategy strategy;
        protected Observer observer;
        protected IMainService mainService; //TODO class Service controller

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

        public void SetSpeed(decimal speed)
        {
            observer.SetTimeAcceleration(speed);
        }

        public void Stop()
        {
            if(systemData.IsEverythingEmpty())
            {
                observer.Stop();
                observer.ResetTime();
            }
        }
        public void Start()
        {
            observer.Start();
        }

        public SystemData GetData() => systemData;

        public void doTick()
        {
            strategy.ManageLifts(systemData);
            foreach (var floor in systemData.GetFloors())
                floor.DoTick();
            mainService.ShowDataInView(systemData);
            mainService.UpdateClock(observer.getCurrentTime());
        }

        public int GetCurrentTime()
        {
            return observer.getCurrentTime();
        }
    }
}
