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
using System.Data;

namespace _8.Lifts_2__PT
{
    public partial class SimulationForm : Form, IMainView, IFileWorkView
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
                _ = new MainPresenter(this, new MainService(simulation));
                _ = new FileWorkPresenter(this,simulation.GetData());
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
        //public delegate bool State();
        public void ShowStateInForm(SystemData systemData) //часть кода будет перенесена в presenter
        {
            //this.simulationTable.SuspendLayout();
            int[] a = new int[systemData.GetParameters().FloorsCount];
            int[] b = new int[systemData.GetParameters().LiftsCount];
            int[] c = new int[systemData.GetParameters().LiftsCount];
            Color[] d = new Color[b.Length];
            if (this.simulationTable.RowCount != a.Length + 1 || this.simulationTable.ColumnCount != b.Length + 2)
            {
                this.simulationTable.SuspendLayout();
                this.ResizeTable(a.Length + 1, b.Length + 2);
                this.simulationTable.ResumeLayout(false);
                this.simulationTable.PerformLayout();
            }
            int i = 0;    //перенести foreach в презентеры и обьявления массивов
            foreach (Floor floor in systemData.GetFloors())
            {
                a[i] = floor.getFullHumanNumber();
                i++;
            }
            i = 0;
            foreach (Lift lift in systemData.GetLifts())
            {
                c[i] = lift.getKeeperFloor();
                b[i] = lift.getHumanNumber();
                d[i] = lift.liftState == Lift.LiftState.WaitOpened ? Color.Yellow : Color.Red;
                i++;
            }
            for (int j = this.simulationTable.RowCount - 1; j > 0; j--)
            {
                Control control = this.simulationTable.GetControlFromPosition(1, j);
                if (control != null)
                    control.Text = a[this.simulationTable.RowCount - j - 1].ToString();
                else MessageBox.Show("I'm too bad for degugging this...Try again");
                for (i = 2; i < this.simulationTable.ColumnCount; i++)
                {
                    Control controli = this.simulationTable.GetControlFromPosition(i,j);
                    controli.Text =(this.simulationTable.RowCount - j - 1 == c[i-2]) ? b[i - 2].ToString() : null;
                    controli.Dock = DockStyle.Fill;
                    controli.BackColor = (this.simulationTable.RowCount - j - 1 == c[i - 2]) ? d[i-2] : Color.Transparent;
                }
            }
            
            //this.simulationTable.PerformLayout();
        }

        private delegate void UpdateTime(int Time);

        public void setTime(int Time)
        {
            if (statusStrip.InvokeRequired)
                statusStrip.Invoke(new UpdateTime((int Time) => { TimeStatusLabel.Text = "Time:" + Time.ToString(); }), Time);
            else
                TimeStatusLabel.Text = "Time:" + Time.ToString();
        }
        private delegate void UpdateStatusNumberHumans(int number);
        
        public void UpdateCarriedHumans(int number)
        {
            if (statusStrip.InvokeRequired)
                statusStrip.Invoke(new UpdateStatusNumberHumans((int number) => { HumanStatusLabel.Text = "Humans:" + number.ToString(); }), number);
            else
                HumanStatusLabel.Text = "Humans:" + number.ToString();
        }

        private delegate void UpdateAlarm();

        public void updateAlarm()
        {
            if (statusStrip.InvokeRequired)
                statusStrip.Invoke(new UpdateAlarm(() => {
                    if (fireAlarmButton.Text.Equals("Fire alarm"))
                    {
                        fireAlarmButton.Text = "Stop alarm";
                        fireAlarmButton.BackColor = Color.DarkOrange;
                    }
                    else if (fireAlarmButton.Text.Equals("Stop alarm"))
                    {
                        fireAlarmButton.Text = "Fire alarm";
                        fireAlarmButton.BackColor = Color.IndianRed;
                    }
                }));
            else
                if (fireAlarmButton.Text.Equals("Fire alarm"))
            {
                fireAlarmButton.Text = "Stop alarm";
                fireAlarmButton.BackColor = Color.DarkOrange;
            }
            else if (fireAlarmButton.Text.Equals("Stop alarm"))
            {
                fireAlarmButton.Text = "Fire alarm";
                fireAlarmButton.BackColor = Color.IndianRed;
            }
        }

        private void ResizeTable(int rows, int columns)
        {
            int tableColumns = this.simulationTable.ColumnCount;
            int tableRows = this.simulationTable.RowCount;
            if (columns < tableColumns)
            {
                for(int col = columns; col < tableColumns; ++col)
                {
                    for (int row = 0; row < tableRows; ++row)
                    {
                        Control c = simulationTable.GetControlFromPosition(col, row);
                        simulationTable.Controls.Remove(c);
                        c.Dispose();
                    }
                }
                this.simulationTable.ColumnCount = columns;
            } else if(columns > tableColumns)
            {
                this.simulationTable.ColumnCount = columns;
                for (int col = tableColumns; col < columns; ++col)
                {
                    simulationTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    simulationTable.Controls.Add(CreateTableLabel("Lift " + (col - 1).ToString()), col, 0);
                    for (int row = 1; row < tableRows; ++row)
                    {
                        simulationTable.Controls.Add(CreateTableLabel("0"), col, row);
                    }
                }
            }
            tableColumns = this.simulationTable.ColumnCount;

            if (rows < tableRows)
            {
                for (int row = rows; row < tableRows; ++row)
                {
                    for (int col = 0; col < tableColumns; ++col)
                    {
                        Control c = simulationTable.GetControlFromPosition(col, row);
                        simulationTable.Controls.Remove(c);
                        c.Dispose();
                    }
                }
                for (int row = 1; row < rows; ++row)
                {
                    Control c = simulationTable.GetControlFromPosition(0, row);
                    c.Text = (rows - row).ToString();
                }
                this.simulationTable.RowCount = rows;
            }
            else if (rows > tableRows)
            {
                this.simulationTable.RowCount = rows;
                for (int row = tableRows; row < rows; ++row)
                {
                    simulationTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
                    simulationTable.Controls.Add(CreateTableLabel("0"), 0, row);
                    for (int col = 1; col < tableColumns; ++col)
                    {
                        simulationTable.Controls.Add(CreateTableLabel("0"), col, row);
                    }
                }
                for (int row = 1; row < rows; ++row)
                {
                    Control c = simulationTable.GetControlFromPosition(0, row);
                    c.Text = (rows - row).ToString();
                }
            }
        }

        public event Action StartFireAlarm;
        public event Action StopFireAlarm;
        public event IMainView.State StopSimulation;
        public event Action StartSimulation;
        public event Action PauseSimulation;
        public event Action<decimal> SetSimulationSpeed;
        public event Action<string> SaveHumanGenerationStrategy;
        public event Action<string> SaveLiftConfigurationStrategy;
        public event Action<string> LoadHumanGenerationStrategy;
        public event Action<string> LoadLiftConfigurationStrategy;

        private Label CreateTableLabel(string str)
        {
            Label label = new Label
            {
                Text = str,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                //label.Dock = DockStyle.Fill;
                Anchor = AnchorStyles.Right | AnchorStyles.Left
            };
            label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
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
                    this.simulationTable.Controls.Add(CreateTableLabel(""), j, i);
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
            if (StopSimulation.Invoke())
            {
                startButton.Text = "Start";
                SystemParametersMenuItem.Enabled = true;
                PauseMenuItem.Enabled = false;
                StartMenuItem.Enabled = true;
                StatisticMenuItem.Enabled = true;
            }
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
            HumanGenerationForm form = new HumanGenerationForm();
            form.LoadTable(new HumanGenerationPresenter(form, new HumanCreationService(simulation.GetData())).LoadTable());
            form.Show();
        }

        private void HelpClick(object sender, EventArgs e)
        {
            Form form = new HelpForm();
            form.Show();
        }

        private void PlanFireAlarmClick(object sender, EventArgs e)
        {
            PlanFireAlarmForm form = new PlanFireAlarmForm();
            try
            {
                form.LoadTable(new PlanFirePresenter(form, new FireAlarmService(simulation))?.LoadTable());
                form.Show();
            }
            catch (Exception) { MessageBox.Show("I'm too bad for degugging this...Try again"); }
        }

        private void SystemParametersClick(object sender, EventArgs e)
        {
            SystemParametersForm form = new SystemParametersForm();
            SystemParametersPresenter pres = new SystemParametersPresenter(form,
                new SystemParametersService(simulation.GetData()), simulation.GetMainService());
            pres.GetParameters();
            form.Show();
        }

        private void StatisticsClick(object sender, EventArgs e)
        {
            SimulationStatisticsForm form = new SimulationStatisticsForm();
            new StatisticsPresenter(form, new StatisticsService(simulation.GetData()), new FileWorkService(simulation.GetData()));
            form.Show();
        }

        private void HumanStatusClick(object sender, EventArgs e)
        {
            HumanStatusForm form = new HumanStatusForm(simulation.GetData().GetLifts().Count(), simulation.GetData().GetFloors().Count());
            new HumanStatusPresenter(form, new HumanCreationService(simulation.GetData()));
            form.Show();
        }
        public void setFilter(string filter) 
        {
            saveGeneratedFileDialog.Filter += filter;
            saveLiftFileDialog.Filter += filter;
            openGenerationFileDialog.Filter += filter;
            openLiftFileDialog.Filter += filter;
        }

        private void SaveHumanGenerationClick(object sender, EventArgs e)
        {
            if (saveGeneratedFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveGeneratedFileDialog.FileName;
            // сохраняем текст в файл
            this.SaveHumanGenerationStrategy?.Invoke(filename);
        }

        private void LoadHumanGenerationClick(object sender, EventArgs e)
        {
            if (openGenerationFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openGenerationFileDialog.FileName;
            // читаем файл в строку
            this.LoadHumanGenerationStrategy?.Invoke(filename);
        }

        private void SaveLiftConfigurationClick(object sender, EventArgs e)
        {
            if (saveLiftFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveLiftFileDialog.FileName;
            // читаем файл в строку
            this.SaveLiftConfigurationStrategy?.Invoke(filename);
        }

        private void LoadLiftConfiguration(object sender, EventArgs e)
        {
            if (openLiftFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openLiftFileDialog.FileName;
            // читаем файл в строку
            this.LoadLiftConfigurationStrategy?.Invoke(filename);
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