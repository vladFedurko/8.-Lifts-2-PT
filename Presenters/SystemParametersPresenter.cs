using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Services;
using Models;

namespace Presenters
{
    public class SystemParametersPresenter
    {
        private ISystemParametersView _view;
        private ISystemParametersService _parametersService;

        public SystemParametersPresenter(ISystemParametersView view, ISystemParametersService parametersService)
        {
            _view = view;
            _parametersService = parametersService;
            _view.SaveSystemParameters += this.SaveSystemParameters;
        }

        public void SaveSystemParameters(ISimulationParameters par)
        {
            _parametersService.SaveSystemParameters(par);
        }

        public void GetParameters()
        {
            _view.LoadCurrentParameters(_parametersService.GetSystemParameters());
        }
    }
}
