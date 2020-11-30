
﻿using Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _8.Lifts_2__PT
{

    public partial class SimulationForm : Form, IMainView
    {
        public SimulationForm()
        {
            InitializeComponent();
            InitSimulationTable();
        }

        public event Action StartFireAlarm;
        public event Action StopFireAlarm;
        public event Action StopSimulation;
        public event Action StartSimulation;
        public event Action PauseSimulation;
        public event Action<decimal> SetSimulationSpeed;
        public event Action ShowCreateHumanForm;
        public event Action ShowStatistics;
        public event Action ShowHumanGenerationStrategy;
        public event Action ShowPlanFireAlarmForm;
        public event Action ShowParametres;
        public event Action ShowHelp;
        public event Action ShowHumanStatus;
        public event Action SaveHumanGenerationStrategy;
        public event Action SaveLiftConfigurationStrategy;
        public event Action LoadHumanGenerationStrategy;
        public event Action LoadLiftConfigurationStrategy;

        private Label CreateTableLabel(string str)
        {
            Label label = new Label();
            label.Text = str;
            label.TextAlign = ContentAlignment.MiddleCenter;
            //label.Dock = DockStyle.Fill;
            label.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            return label;
        }

        private void InitSimulationTable()
        {
            for(int j = 1; j < this.simulationTable.RowCount; j++)
                this.simulationTable.Controls.Add(CreateTableLabel(j.ToString()), 0, this.simulationTable.RowCount - j);
            this.simulationTable.Controls.Add(CreateTableLabel("Floor"), 0, 0);
            this.simulationTable.Controls.Add(CreateTableLabel("People on floors"), 1, 0);
            for (int j = 2; j < this.simulationTable.ColumnCount; j++)
                this.simulationTable.Controls.Add(CreateTableLabel("Lift " + (j - 1)), j, 0);
            for (int i = 1; i < this.simulationTable.RowCount; i++)
                for (int j = 1; j < this.simulationTable.ColumnCount; j++)
                    this.simulationTable.Controls.Add(CreateTableLabel("0"), j, i);
        }

        private void StartSimulationClick(object sender, EventArgs e)
        {
            if (startButton.Text.Equals("Start"))
            {
                this.StartSimulation?.Invoke();
                startButton.Text = "Pause";
                PauseMenuItem.Enabled = true;
                StartMenuItem.Enabled = false;
            }
            else if (startButton.Text.Equals("Pause"))
            {
                this.PauseSimulation?.Invoke();
                startButton.Text = "Start";
                PauseMenuItem.Enabled = false;
                StartMenuItem.Enabled = true;
            }
            StatisticMenuItem.Enabled = false;
        }

        private void StopSimulationClick(object sender, EventArgs e)
        {
            this.StopSimulation?.Invoke();
            /*if (startButton.Text.Equals("Pause"))
            {
                startButton.Text = "Start";
                PauseMenuItem.Enabled = false;
                StartMenuItem.Enabled = true;
            }
            StatisticMenuItem.Enabled = true;*/
        }

        private void FireAlarmClick(object sender, EventArgs e)
        {
            if (fireAlarmButton.Text.Equals("Fire alarm"))
            {
                this.StartFireAlarm?.Invoke();
                fireAlarmButton.Text = "Stop alarm";
                fireAlarmButton.BackColor = Color.DarkOrange;
            }
            else if (fireAlarmButton.Text.Equals("Stop alarm"))
            {
                this.StopFireAlarm?.Invoke();
                fireAlarmButton.Text = "Fire alarm";
                fireAlarmButton.BackColor = Color.IndianRed;
            }
        }

        private void ChangeSimulationSpeed(object sender, EventArgs e)
        {
            this.SetSimulationSpeed?.Invoke(SpeedSelecter.Value);
        }

        private void CreateHumanClick(object sender, EventArgs e)
        {
            this.ShowCreateHumanForm?.Invoke();
        }

        private void HumanGenerationClick(object sender, EventArgs e)
        {
            this.ShowHumanGenerationStrategy?.Invoke();
        }

        private void HelpClick(object sender, EventArgs e)
        {
            this.ShowHelp?.Invoke();
        }
        
        private void PlanFireAlarmClick(object sender, EventArgs e)
        {
            this.ShowPlanFireAlarmForm?.Invoke();
        }

        private void SystemParametersClick(object sender, EventArgs e)
        {
            this.ShowParametres?.Invoke();
        }

        private void StatisticsClick(object sender, EventArgs e)
        {
            this.ShowStatistics?.Invoke();
        }

        private void HumanStatusClick(object sender, EventArgs e)
        {
            this.ShowHumanStatus?.Invoke();
        }

        private void SaveHumanGenerationClick(object sender, EventArgs e)
        {
            this.SaveHumanGenerationStrategy?.Invoke();
        }

        private void LoadHumanGenerationClick(object sender, EventArgs e)
        {
            this.LoadHumanGenerationStrategy?.Invoke();
        }

        private void SaveLiftConfigurationClick(object sender, EventArgs e)
        {
            this.SaveLiftConfigurationStrategy?.Invoke();
        }

        private void LoadLiftConfiguration(object sender, EventArgs e)
        {
            this.LoadLiftConfigurationStrategy?.Invoke();
        }

        public void ShowForm()
        {
            this.Show();
        }  

        public void CloseForm()
        {
            this.Close();
        }

        public void ShowState()
        {
            //TODO
        }

        public void SetParameters(int floors, int lifts)
        {
            //TODO
        }
    }
}
