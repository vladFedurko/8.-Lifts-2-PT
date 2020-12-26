using Models.LiftManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ISimulationParameters
    {
        int LiftsCount { get; set; }

        int LiftsCapacity { get; set; }

        int FloorsCount { get; set; }

        ILiftManager LiftManager { get; set; }

        int SecondsToMove { get; set; }

        int SecondsToWait { get; set; }
    }
}
