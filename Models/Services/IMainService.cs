using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IMainService : IService
    {
        void ShowCurrentState(SystemData data);

        void ShowCurrentTime(int seconds);

        void StartSimulation();

        void PauseSimulation();

        void StopSimulation();

        void SetSimulationSpeed(decimal speed);

    }
}
