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
            return simulation.GetCurrentTime();
        }

        public void StartSimulation()
        {
            simulation.Start();
        }

        public void StopSimulation()
        {
            simulation.Stop();
        }

        public void ShowDataInView(SystemData data)
        {
            this.UpdateSystemData.Invoke(data);
        }

        public void UpdateClock(int time)
        {
            this.UpdateTime.Invoke(time);
        }

        public void StartFireAlarm()
        {
            FireAlarmService.GetInstance(simulation).StartAlarm();
        }

        public void StopFireAlarm()
        {
            FireAlarmService.GetInstance(simulation).StopAlarm();
        }

        public event Action<SystemData> UpdateSystemData;
        public event Action<int> UpdateTime;
    }
}
