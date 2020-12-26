using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Presenters;
using Models.LiftManager;

namespace _8.Lifts_2__PT
{
    public partial class SystemParametersForm : Form, ISystemParametersView
    {
        public SystemParametersForm()
        {
            InitializeComponent();
        }

        public event Action<ISimulationParameters> SaveSystemParameters;

        private void saveButton_Click(object sender, EventArgs e)
        {
            SimulationParameters par = new SimulationParameters();
            par.FloorsCount = (int)floorsCountSelecter.Value;
            par.LiftsCount = (int)liftsCountSelecter.Value;
            par.SecondsToMove = (int)liftSpeedSelecter.Value;
            par.SecondsToWait = (int)liftWaitingTimeSelecter.Value;
            par.LiftsCapacity = (int)liftCapacitySelecter.Value;
            if(StrategySelecter.SelectedIndex == 0)
            {
                par.LiftManager = new MinWaitingTimeLiftManager();
            }
            else
            {
                par.LiftManager = new MinIdlingTimeLiftManager(); ;
            }
            SaveSystemParameters.Invoke(par);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void LoadCurrentParameters(ISimulationParameters par)
        {
            floorsCountSelecter.Value = par.FloorsCount;
            liftsCountSelecter.Value = par.LiftsCount;
            liftSpeedSelecter.Value = par.SecondsToMove;
            liftWaitingTimeSelecter.Value = par.SecondsToWait;
            liftCapacitySelecter.Value = par.LiftsCapacity;
            if(par.LiftManager is MinWaitingTimeLiftManager)
            {
                StrategySelecter.SelectedIndex = 0;
            } else
            {
                StrategySelecter.SelectedIndex = 1;
            }
        }
    }
}
