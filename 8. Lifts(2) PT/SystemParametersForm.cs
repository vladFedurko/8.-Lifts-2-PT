using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters;

namespace _8.Lifts_2__PT
{
    public partial class SystemParametersForm : Form, ISystemParametersView
    {
        public SystemParametersForm()
        {
            InitializeComponent();
        }

        //public event Action<SystemParametres> ExportStatistics;

        private void saveButton_Click(object sender, EventArgs e)
        {
            //TO DO
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
    }
}
