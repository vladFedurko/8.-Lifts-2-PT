using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.LiftManager;

namespace Models
{
    public class SimulationParameters : ISimulationParameters
    {
        public int LiftsCapacity { get; set; }

        public int LiftsCount { get; set; }

        public int FloorsCount { get; set; }

        public ILiftManager LiftManager { get; set; }

        public int SecondsToMove { get; set; }

        public int SevondsToWait { get; set; }
    }
}
