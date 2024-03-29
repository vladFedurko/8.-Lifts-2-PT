﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface ISystemParametersView : IView
    {
        event Action<ISimulationParameters> SaveSystemParameters;

        public void LoadCurrentParameters(ISimulationParameters par);
    }
}
