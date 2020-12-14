﻿using Models;
using Models.Entities;
using Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Models.Services;
using System.Threading;
using Models.LiftManager;

namespace _8.Lifts_2__PT
{
    public partial class SimulationForm : Form, IMainView
    {
        private bool isSimulationLoaded = false;

        private ISimulation simulation;

        public SimulationForm()
        {
            InitializeComponent();
            InitSimulationTable();
            InitSimulation();
        }

        public void InitSimulation()
        {
            if (!isSimulationLoaded)
            {
                simulation = new Simulation(5, 2, new MinWaitingTimeLiftManager());
                MainPresenter pres = new MainPresenter(this, new MainService(simulation));
                isSimulationLoaded = true;
            }
        }

        private delegate void UpdateState(SystemData systemData);

        public void ShowState(SystemData systemData)
        {
            if (simulationTable.InvokeRequired)
                simulationTable.Invoke(new UpdateState(ShowStateInForm), systemData);
            else
                ShowStateInForm(systemData);
        }

        public void ShowStateInForm(SystemData systemData) //часть кода будет перенесена в presenter
        {
            this.simulationTable.SuspendLayout();
            int[] a = new int[systemData.GetFloors().Count()];
            int[] b = new int[systemData.GetLifts().Count()];
            int[] c = new int[systemData.GetLifts().Count()];
            int i = 0;//перенести foreach в презентеры и обьявления массивов
            foreach (Floor floor in systemData.GetFloors())
            {
                a[i] = floor.getHumanNumber();
                i++;
            }
            i = 0;
            foreach (Lift lift in systemData.GetLifts())
            {
                c[i] = lift.getKeeperFloor();
                b[i] = lift.getHumanNumber();
            }
            for (int j = this.simulationTable.RowCount - 1; j > 0; j--)
            {
                Control control = this.simulationTable.GetControlFromPosition(1, j);
                control.Text = a[this.simulationTable.RowCount - j - 1].ToString();
            }
            for (int j = 2; j < this.simulationTable.ColumnCount; j++)
            {
                Control control = this.simulationTable.GetControlFromPosition(j,this.simulationTable.RowCount - c[j - 2] - 1);
                control.Text = b[j - 2].ToString();
            }
            this.simulationTable.PerformLayout();
        }

        private delegate void UpdateTime(int Time);

        public void setTime(int Time)
        {
            if (statusStrip1.InvokeRequired)
                statusStrip1.Invoke(new UpdateTime((int Time) => { TimeStatusLabel.Text = "Time:" + Time.ToString(); }), Time);
            else
                TimeStatusLabel.Text = "Time:" + Time.ToString();
        }

        public event Action StartFireAlarm;
        public event Action StopFireAlarm;
        public event Action StopSimulation;
        public event Action StartSimulation;
        public event Action PauseSimulation;
        public event Action<decimal> SetSimulationSpeed;
        public event Action ShowStatistics;
        public event Action ShowHumanGenerationStrategy;
        public event Action ShowPlanFireAlarmForm;
        public event Action ShowParametres;
        public event Action SaveHumanGenerationStrategy;
        public event Action SaveLiftConfigurationStrategy;
        public event Action LoadHumanGenerationStrategy;
        public event Action LoadLiftConfigurationStrategy;

        private Label CreateTableLabel(string str)
        {
            Label label = new Label
            {
                Text = str,
                TextAlign = ContentAlignment.MiddleCenter,
                //label.Dock = DockStyle.Fill;
                Anchor = AnchorStyles.Right | AnchorStyles.Left
            };
            return label;
        }

        private void InitSimulationTable()
        {
            for (int j = 1; j < this.simulationTable.RowCount; j++)
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
                this.SystemParametersMenuItem.Enabled = false;
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
            SystemParametersMenuItem.Enabled = true;
            PauseMenuItem.Enabled = false;
            StartMenuItem.Enabled = true;
            StatisticMenuItem.Enabled = true;
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
            CreateHumanForm form = new CreateHumanForm();
            new CreateHumanPresenter(form, new HumanCreationService(simulation.GetData()));
            form.Show();
        }

        private void HumanGenerationClick(object sender, EventArgs e)
        {
            this.ShowHumanGenerationStrategy?.Invoke();
        }

        private void HelpClick(object sender, EventArgs e)
        {
            Form form = new HelpForm();
            form.Show();
        }

        private void PlanFireAlarmClick(object sender, EventArgs e)
        {
            this.ShowPlanFireAlarmForm?.Invoke();
        }

        private void SystemParametersClick(object sender, EventArgs e)
        {
            SystemParametersForm form = new SystemParametersForm();
            SystemParametersPresenter pres = new SystemParametersPresenter(form, new SystemParametersService(simulation));
            pres.GetParameters();
            form.Show();
        }

        private void StatisticsClick(object sender, EventArgs e)
        {
            this.ShowStatistics?.Invoke();
        }

        private void HumanStatusClick(object sender, EventArgs e)
        {
            HumanStatusForm form = new HumanStatusForm(simulation.GetData().GetLifts().Count(), simulation.GetData().GetFloors().Count());
            new HumanStatusPresenter(form, new HumanCreationService(simulation.GetData()));
            form.Show();
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
    }
}