﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LiftManager
{
    public interface ISimulationState
    {
        void ResetState(SystemData data);
    }
}
