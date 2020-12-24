using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Services;
using System.Windows.Forms;

namespace Presenters
{
    public class MainPresenter
    {
        private IMainView _view;
        private IMainService _mainService;

        public MainPresenter(IMainView view, IMainService service)
        {
            _view = view;
            _mainService = service;
            InitEvents();
        }

        private void InitEvents()
        {
            _view.StartFireAlarm += this.StartFireAlarm;
            _view.StopFireAlarm += this.StopFireAlarm;
            _view.StopSimulation += this.StopSimulation;
            _view.StartSimulation += this.StartSimulation;
            _view.PauseSimulation += this.PauseSimulation;
            _view.SetSimulationSpeed += this.SetSimulationSpeed;
            _mainService.UpdateSystemData += this.ShowData;
            _mainService.UpdateTime += this.ShowTime;
            _mainService.UpdateAlarm += this.updateAlarm;
        }

        public void ShowTime(int time)
        {
            _view.setTime(time);
        }
        public void updateAlarm()
        {
            _view.updateAlarm();
        }

        public void ShowData(SystemData data)
        {
            _view.ShowState(data);
        }

        public void StartFireAlarm()
        {
            _mainService.StartFireAlarm();
        }

        public void StopFireAlarm()
        {
            _mainService.StopFireAlarm();
        }

        public bool StopSimulation()
        {
            return _mainService.StopSimulation();
        }

        public void StartSimulation()
        {
            _mainService.StartSimulation();
        }

        public void PauseSimulation()
        {
            _mainService.PauseSimulation();
        }

        public void SetSimulationSpeed(decimal speed)
        {
            _mainService.SetSimulationSpeed(speed);
        }
    }
}
