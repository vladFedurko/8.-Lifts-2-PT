using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public class SystemParametersService : ISystemParametersService
    {
        private SystemData data;

        public SystemParametersService(SystemData data)
        {
            this.data = data;
        }

        public void SaveSystemParameters(ISimulationParameters par)
        {
            data.SetSimulationParameters(par);
        }

        public ISimulationParameters GetSystemParameters()
        {
            return data.GetParameters();
        }
    }
}
