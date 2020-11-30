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
    public partial class SimulationStatisticsForm : Form, IView
    {
        public SimulationStatisticsForm(IEnumerable<int> stat)
        {
            InitializeComponent();
            //TODO
        }

        public void CloseForm()
        {
            this.Show();
        }

        public void ShowForm()
        {
            this.Close();
        }

        private void CancelStatistics(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportStatistics(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
