using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public class MainService : IMainService
    {
        private readonly ISimulation simulation;

        public MainService(ISimulation sim)
        {
            this.simulation = sim;
            simulation.SetService(this);
        }

        public SystemData GetData()
        {
            return simulation.GetData();
        }

        public void PauseSimulation()
        {
            simulation.Pause();
        }

        public void SetSimulationSpeed(decimal speed)
        {
            simulation.SetSpeed(speed);
        }

        public SystemData ShowCurrentState()
        {
            return simulation.GetData();
        }

        public int ShowCurrentTime()
        {
            return (int)simulation.GetCurrentTime();
        }

        public void StartSimulation()
        {
            simulation.Start();
        }

        public bool StopSimulation()
        {
            return simulation.Stop();
        }

        public void ShowDataInView(SystemData data)
        {
            this.UpdateSystemData.Invoke(data);
        }

        public void UpdateClock(int time)
        {
            this.UpdateTime.Invoke(time);
        }
        public void UpdateCarriedHumans(int number)
        {
            this.UpdateNumberOfCarriedHumans.Invoke(number);
        }
        public void UpdateFireAlarm()
        {
            this.UpdateAlarm.Invoke();
        }

        public void StartFireAlarm()
        {
            simulation.TurnOnFireAlarm();
        }

        public void StopFireAlarm()
        {
            simulation.TurnOffFireAlarm();
        }

        public bool isStoped()
        {
            return simulation.IsStoped();
        }

        public event Action<SystemData> UpdateSystemData;
        public event Action<int> UpdateTime;
        public event Action<int> UpdateNumberOfCarriedHumans;
        public event Action UpdateAlarm;
    }
}
