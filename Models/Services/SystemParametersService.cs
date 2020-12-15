using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public class SystemParametersService : ISystemParametersService
    {
        private ISimulation simulation;

        public SystemParametersService(ISimulation sim)
        {
            simulation = sim;
        }

        public void SaveSystemParameters(ISimulationParameters par)
        {
            simulation.GetData().SetSimulationParameters(par);
        }

        public ISimulationParameters GetSystemParameters()
        {
            return simulation.GetData().GetParameters();
        }
    }
}
