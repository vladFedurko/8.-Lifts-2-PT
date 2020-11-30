using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Windows.Forms;

namespace Presenters
{
    class MainPresenter
    {
        private IMainView _view;
        private IMainService _service;

        public MainPresenter(IMainView view, IMainService service)
        {
            _view = view;
            _service = service;
            InitEvents();
        }

        private void InitEvents()
        {
            _view.StartFireAlarm += this.StartFireAlarm;
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
        }

        public void StartFireAlarm()
        {

        }

        public void StopSimulation()
        {

        }

        public void StartSimulation()
        {

        }

        public void PauseSimulation()
        {

        }

        public void SetSimulationSpeed(decimal speed)
        {

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
