using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IMainService : IService
    {
        SystemData ShowCurrentState();

        int ShowCurrentTime();

        void StartSimulation();

        void PauseSimulation();

        bool StopSimulation();

        void SetSimulationSpeed(decimal speed);

        void ShowDataInView(SystemData data);

        void UpdateClock(int time);
        public void UpdateCarriedHumans(int number);

        void UpdateFireAlarm();

        void StartFireAlarm();

        void StopFireAlarm();

        SystemData GetData();

        bool isStoped();

        event Action<SystemData> UpdateSystemData;
        event Action<int> UpdateTime;
        public event Action UpdateAlarm;
        public event Action<int> UpdateNumberOfCarriedHumans;
    }
}
