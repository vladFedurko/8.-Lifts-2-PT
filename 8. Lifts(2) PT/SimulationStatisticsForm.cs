using Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.Lifts_2__PT
{
    public partial class SimulationStatisticsForm : Form, ISimulationStatisticsView
    {
        public SimulationStatisticsForm()
        {
            InitializeComponent();
        }

        public event Action<string> ExportToFile;

        public void LoadStatistics(IEnumerable<string> stats)
        {
            this.statisticsTabel.SuspendLayout();
            for (int i = 1; i < this.statisticsTabel.RowCount; ++i)
            {
                Control c = this.statisticsTabel.GetControlFromPosition(1, i);
                c.Text = stats.ElementAt(i - 1);
            }
            this.statisticsTabel.ResumeLayout(false);
            this.statisticsTabel.PerformLayout();
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void ShowForm()
        {
            this.Show();
        }

        private void CancelStatistics(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportStatistics(object sender, EventArgs e)
        {
            //this.ExportToFile.Invoke();
        }
    }
}
