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
    public partial class SimulationStatisticsForm : Form
    {
        public SimulationStatisticsForm()
        {
            InitializeComponent();
        }

        private void CancelStatisticsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
