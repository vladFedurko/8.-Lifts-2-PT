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
            par.SecondsToWait = 3;
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

        public bool Stop()
        {
            if(systemData.IsEverythingEmpty())
            {
                observer.Stop();
                observer.ResetTime();
                TurnOffFireAlarm();
                return true;
            }
            return false;
        }

        public void Start()
        {
            observer.Start();
        }

        public SystemData GetData() => systemData;

        public void DoTick()
        {
            systemData.DoTick();
            if (simulationState != null && simulationState is ILiftManager)
                ((ILiftManager)simulationState).ManageLifts(systemData);
            else
                systemData.GetParameters().LiftManager.ManageLifts(systemData);
            mainService.ShowDataInView(systemData);
            mainService.UpdateClock(observer.getCurrentTime());
        }

        public decimal GetCurrentTime()
        {
            return observer.getCurrentTime();
        }

        public bool TurnOnFireAlarm()
        {
            if (simulationState == null)
            {
                simulationState = new FireAlarm(systemData);
                this.GetData().GetFireAlarmStatistics().SetStartTime(this.GetCurrentTime());
                return true;
            }
            return false;
        }

        public bool TurnOffFireAlarm()
        {
            if (simulationState != null)
            {
                simulationState.ResetState(systemData);
                this.GetData().GetFireAlarmStatistics().SetEndTime(this.GetCurrentTime());
                simulationState = null;
                return true;
            }
            return false;
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
