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
    public partial class HumanStatusForm : Form, IHumanStatusView
    {
        public HumanStatusForm()
        {
            InitializeComponent();
        }

        public decimal NumberOfFloorOrLift => NumberOfLiftOrFloorSelecter.Value;

        public bool isLiftChecked => LiftRadioButton.Checked;

        public event Action UpdateTable;

        public void CloseForm()
        {
            this.Close();
        }

        public void LoadTable(IEnumerable<string> people)
        {
            //TODO
        }

        public void ShowForm()
        {
            this.Show();
        }

        private void NumberOfLiftOrFloorChanged(object sender, EventArgs e)
        {
            this.UpdateTable?.Invoke();
        }

        private void TypeChanged(object sender, EventArgs e)
        {
            this.UpdateTable?.Invoke();
        }
    }
}
