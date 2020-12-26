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
    public partial class HumanGenerationForm : Form, IHumanGenerationView
    {
        DataTable _dTable;

        public event Action<DataTable> GenerateHumans;

        public HumanGenerationForm()
        {
            InitializeComponent();
            humanGenerationDataGridView.AllowUserToAddRows = false;
            humanGenerationDataGridView.AllowUserToResizeRows = false;
            humanGenerationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //humanGenerationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            humanGenerationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            humanGenerationDataGridView.DataSource = _dTable;
            humanGenerationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            humanGenerationDataGridView.EditingControlShowing += HumanGenerationDataGridView_EditingControlShowing;
        }

        private void HumanGenerationDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.MaxLength = 2;
            tb.KeyPress += new KeyPressEventHandler(this.tb_KeyPress);
        }

        void tb_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        public void InitTable(out DataTable dTable)
        {
            dTable = new DataTable();
            DataColumn numberOfGeneratedPeopleColumn = new DataColumn("Number of generated humans", Type.GetType("System.Int32"));
            DataColumn initialFloorColumn = new DataColumn("Initial floor", Type.GetType("System.Int32"));
            DataColumn finiteFloorColumn = new DataColumn("Finite floor", Type.GetType("System.Int32"));
            DataColumn inSecondsColumn = new DataColumn("In (seconds)", Type.GetType("System.Int32"));
            dTable.Columns.AddRange(new DataColumn[] {numberOfGeneratedPeopleColumn,
                initialFloorColumn,
                finiteFloorColumn,
                inSecondsColumn});
        }

        public void LoadTable(DataTable dTable)
        {
            _dTable = dTable;
           /*_dTable = dTable.Clone();
            foreach (DataRow row in dTable.Rows)
            {
                _dTable.ImportRow(row);
            }*/
            //_dTable = dTable.Copy();
            humanGenerationDataGridView.DataSource = _dTable;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataRow row = _dTable.NewRow();
            _dTable.Rows.Add(row);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.GenerateHumans?.Invoke(_dTable);
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

        private void HumanGenerationForm_Deactivate(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in humanGenerationDataGridView.SelectedRows)
            {
                humanGenerationDataGridView.Rows.Remove(row);
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
