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
        protected ISimulationState simulationState; 
        protected TickTimer observer;
        protected IMainService mainService; //TODO class Service controller

        public Simulation(int initialFloorsNumber, int initialLiftNumber, ILiftManager _strategy)
        {
            ISimulationParameters par = new SimulationParameters();
            par.LiftsCount = initialLiftNumber;
            par.FloorsCount = initialFloorsNumber;
            par.SecondsToMove = 3;
            par.SevondsToWait = 3;
            par.LiftManager = _strategy;
            par.LiftsCapacity = 10;
            systemData = new SystemData(par);
            observer = new TickTimer(this);
            simulationState = null;
        }

        public void SetService(IMainService ser)
        {
            this.mainService = ser;
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

        public void DoTick()
        {
            if (simulationState != null && simulationState is ILiftManager)
                ((ILiftManager)simulationState).ManageLifts(systemData);
            else
                systemData.GetParameters().LiftManager.ManageLifts(systemData);
            systemData.DoTick();
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
            simulationState?.ResetState(systemData);
            simulationState = null;
        }

        public IMainService GetMainService()
        {
            return mainService;
        }

        public bool IsStoped()
        {
            return observer.isStoped() && observer.getCurrentTime() == 0;
        }
    }
}
