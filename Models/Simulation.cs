using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Services;
using Models.LiftManager;

namespace Models
{
    public class Simulation : ISimulation
    {
        protected SystemData systemData;
        protected ILiftManager strategy;
        protected ISimulationState simulationState; 
        protected Observer observer;
        protected IMainService mainService; //TODO class Service controller

        public Simulation(int initialFloorsNumber, int initialLiftNumber, ILiftManager _strategy)
        {
            systemData = new SystemData(initialFloorsNumber, initialLiftNumber);
            strategy = _strategy;
            observer = new Observer(this);
            simulationState = null;
        }

        public void SetService(IMainService ser)
        {
            this.mainService = ser;
        }

        public void ChangeStrategy(ILiftManager st)
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
            if (simulationState != null && simulationState is ILiftManager)
                ((ILiftManager)simulationState).ManageLifts(systemData);
            else
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

        public void TurnOnFireAlarm()
        {
            simulationState = new FireAlarm(systemData);
        }

        public void TurnOffFireAlarm()
        {
            simulationState.ResetState(systemData);
            simulationState = null;
        }
    }
}
