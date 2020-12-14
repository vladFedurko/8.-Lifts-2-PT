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
        public HumanStatusForm(int numberOfLifts, int numberOfFloors)
        {
            InitializeComponent();
            maxFloors = numberOfFloors;
            maxLifts = numberOfLifts;
            this.NumberOfKeeperSelecter.Maximum = maxFloors;
        }

        private int maxLifts;
        private int maxFloors;

        public decimal NumberOfFloorOrLift => NumberOfKeeperSelecter.Value;

        public bool isLiftChecked => LiftRadioButton.Checked;

        public event Action UpdateTable;

        public void CloseForm()
        {
            this.Close();
        }

        public void LoadTableInForm(IDictionary<String, int> status)
        {
            this.statusTable.SuspendLayout();
            this.statusTable.RowCount = status.Count() + 1;
            int row = 1;
            foreach (var stat in status.Keys)
            {
                AddControlsIntoRow(row, stat, status[stat]);
                row++;
            }
            this.statusTable.ResumeLayout(false);
            this.statusTable.PerformLayout();
        }

        private void AddControlsIntoRow(int row, String status, int numberOfHumans)
        {
            Control control = this.statusTable.GetControlFromPosition(0, row);
            if (control == null)
            {
                control = this.GetLabelForTable(numberOfHumans.ToString());
                this.statusTable.Size = new Size(this.statusTable.Size.Width, this.statusTable.Size.Height + 30);
                this.statusTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                this.statusTable.Controls.Add(control, 0, row);
            } else
                control.Text = numberOfHumans.ToString();
            control = this.statusTable.GetControlFromPosition(row, 1);
            if (control == null)
            {
                control = this.GetLabelForTable(status);
                this.statusTable.Controls.Add(control, 1, row);
            } else
                control.Text = status;
        }

        private Label GetLabelForTable(String text)
        {
            Label label = new Label
            {
                Text = text
            };
            label.Anchor = AnchorStyles.Top;
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            return label;
        }

        private delegate void UpdateTableDel(IDictionary<String, int> status);

        public void LoadTable(IDictionary<String, int> status)
        {
            if (this.statusTable.InvokeRequired)
            {
                statusTable.Invoke(new UpdateTableDel(LoadTableInForm), status);
            } else
                LoadTableInForm(status);
        }

        public void ShowForm()
        {
            this.Show();
        }

        private void TypeChanged(object sender, EventArgs e)
        {
            if (isLiftChecked)
                this.NumberOfKeeperSelecter.Maximum = maxLifts;
            else
                this.NumberOfKeeperSelecter.Maximum = maxFloors;
            this.UpdateTable?.Invoke();
        }

        private void NumberOfKeeperChanged(object sender, EventArgs e)
        {
            this.UpdateTable?.Invoke();
        }
    }
}
