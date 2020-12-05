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

        void StopSimulation();

        void SetSimulationSpeed(decimal speed);

    }
}
