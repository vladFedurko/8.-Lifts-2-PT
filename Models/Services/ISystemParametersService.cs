﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface ISystemParametersService : IService
    {
        public void SaveSystemParameters(ISimulationParameters par);

        public ISimulationParameters GetSystemParameters();
    }
}
