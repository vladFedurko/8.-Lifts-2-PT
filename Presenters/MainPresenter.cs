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
            _view.ShowCreateHumanForm += this.ShowCreateHumanForm;
            _view.ShowStatistics += this.ShowStatistics;
            _view.ShowHumanGenerationStrategy += this.ShowHumanGenerationStrategy;
            _view.ShowPlanFireAlarmForm += this.ShowPlanFireAlarmForm;
            _view.ShowParametres += this.ShowParametres;
            _view.ShowHelp += this.ShowHelp;
            _view.ShowHumanStatus += this.ShowHumanStatus;
            _view.LoadHumanGenerationStrategy += this.LoadHumanGenerationStrategy;
            _view.LoadLiftConfigurationStrategy += this.LoadLiftConfigurationStrategy;
            _view.SaveHumanGenerationStrategy += this.SaveHumanGenerationStrategy;
            _view.SaveLiftConfigurationStrategy += this.SaveLiftConfigurationStrategy;
            _mainService.UpdateSystemData += this.ShowData;
            _mainService.UpdateTime += this.ShowTime;
        }

        public void ShowTime(int time)
        {
            _view.setTime(time);
        }

        public void ShowData(SystemData data)
        {
            
        }

        public void StartFireAlarm()
        {
            _mainService.StartFireAlarm();
        }

        public void StopFireAlarm()
        {
            _mainService.StopFireAlarm();
        }

        public void StopSimulation()
        {
            _mainService.StopSimulation();
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

        public void ShowCreateHumanForm()
        {

        }

        public void ShowStatistics()
        {

        }

        public void ShowHumanGenerationStrategy()
        {

        }

        public void ShowPlanFireAlarmForm()
        {

        }

        public void ShowParametres()
        {

        }

        public void ShowHelp()
        {

        }

        public void ShowHumanStatus()
        {

        }

        public void LoadHumanGenerationStrategy()
        {

        }

        public void LoadLiftConfigurationStrategy()
        {

        }

        public void SaveHumanGenerationStrategy()
        {

        }

        public void SaveLiftConfigurationStrategy()
        {

        }
    }
}
