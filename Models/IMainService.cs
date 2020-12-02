using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IMainService : IService
    {

        void ShowState();

        void SetParameters(int floors, int lifts);

        event Action StartFireAlarm;
        event Action StopFireAlarm;
        event Action StopSimulation;
        event Action StartSimulation;
        event Action PauseSimulation;
        event Action<decimal> SetSimulationSpeed;
        event Action ShowCreateHumanForm;
        event Action ShowStatistics;
        event Action ShowHumanGenerationStrategy;
        event Action ShowPlanFireAlarmForm;
        event Action ShowParametres;
        event Action ShowHelp;
        event Action ShowHumanStatus;
        event Action LoadHumanGenerationStrategy;
        event Action LoadLiftConfigurationStrategy;
        event Action SaveHumanGenerationStrategy;
        event Action SaveLiftConfigurationStrategy;
    }
}
