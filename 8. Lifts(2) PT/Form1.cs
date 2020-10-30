using System;
using System.Drawing;
using System.Windows.Forms;

namespace _8.Lifts_2__PT
{
    public partial class SimulationForm : Form
    {
        public SimulationForm()
        {
            InitializeComponent();
            InitSimulationTable();
        }

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

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text.Equals("Start"))
            {
                // TO DO
                startButton.Text = "Pause";
                pauseToolStripMenuItem.Enabled = true;
                startToolStripMenuItem.Enabled = false;
            }
            else if (startButton.Text.Equals("Pause"))
            {
                // TO DO
                startButton.Text = "Start";
                pauseToolStripMenuItem.Enabled = false;
                startToolStripMenuItem.Enabled = true;
            }

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text.Equals("Pause"))
            {
                // TO DO
                startButton.Text = "Start";
                pauseToolStripMenuItem.Enabled = false;
                startToolStripMenuItem.Enabled = true;
            }
        }

        private void CreateHumanButton_Click(object sender, EventArgs e)
        {
            CreateHumanForm createHumanForm = new CreateHumanForm();
            createHumanForm.Show();
        }


        private void FireAlarmButton_Click(object sender, EventArgs e)
        {
            if (fireAlarmButton.Text.Equals("Fire alarm"))
            {
                // TO DO
                fireAlarmButton.Text = "Stop alarm";
                fireAlarmButton.BackColor = Color.DarkOrange;
            }
            else if (fireAlarmButton.Text.Equals("Stop alarm"))
            {
                // TO DO
                fireAlarmButton.Text = "Fire alarm";
                fireAlarmButton.BackColor = Color.IndianRed;
            }
        }

        private void SpeedSelecter_ValueChanged(object sender, EventArgs e)
        {

        }
        private void HumanGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HumanGenerationForm form = new HumanGenerationForm();
            form.Show();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.Show();
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
