using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface IMainView : IView
    {

        void ShowState(SystemData data);

        void setTime(int Time);
        void updateAlarm();
        public void UpdateCarriedHumans(int number);

        public delegate bool State();

        event Action StartFireAlarm;
        event Action StopFireAlarm;
        event State StopSimulation;
        event Action StartSimulation;
        event Action PauseSimulation;
        event Action<decimal> SetSimulationSpeed;
    }
}
