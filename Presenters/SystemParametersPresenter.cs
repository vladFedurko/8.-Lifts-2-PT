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
        private IMainService _mainService;

        public SystemParametersPresenter(ISystemParametersView view, ISystemParametersService parametersService, IMainService mainService)
        {
            _view = view;
            _parametersService = parametersService;
            _mainService = mainService;
            _view.SaveSystemParameters += this.SaveSystemParameters;
        }

        public void SaveSystemParameters(ISimulationParameters par)
        {
            _parametersService.SaveSystemParameters(par);
            _mainService.ShowDataInView(_mainService.GetData());
        }

        public void GetParameters()
        {
            _view.LoadCurrentParameters(_parametersService.GetSystemParameters());
        }
    }
}
