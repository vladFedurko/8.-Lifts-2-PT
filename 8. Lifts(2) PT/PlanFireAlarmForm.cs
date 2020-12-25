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
    public partial class PlanFireAlarmForm : Form, IPlanFireView
    { 
        DataTable dataTable;

        public event Action<DataTable> PlanFireAlarm;

        public PlanFireAlarmForm()
        {
            InitializeComponent();
            firePlanDataGridView.AllowUserToAddRows = false;
            firePlanDataGridView.AllowUserToResizeRows = false;
            firePlanDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            firePlanDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            firePlanDataGridView.DataSource = dataTable;
            firePlanDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            firePlanDataGridView.EditingControlShowing += FirePlanDataGridView_EditingControlShowing;
        }

        public void LoadTable(DataTable dTable)
        {
            dataTable = dTable;
            firePlanDataGridView.DataSource = dataTable;
        }

        private void FirePlanDataGridView_EditingControlShowing(Object  sender, DataGridViewEditingControlShowingEventArgs  e)
        {
            TextBox  tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(this.tb_KeyPress);
        }

        void tb_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            DataRow row = dataTable.NewRow();
            dataTable.Rows.Add(row);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.PlanFireAlarm?.Invoke(dataTable);
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message);
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in firePlanDataGridView.SelectedRows)
            {
                firePlanDataGridView.Rows.Remove(row);
            }
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
