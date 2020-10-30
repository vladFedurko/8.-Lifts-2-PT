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
    public partial class PlanFireAlarmForm : Form
    {
        public int Row { get; set; }
        public PlanFireAlarmForm()
        {
            InitializeComponent();
            Row = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Row++;
            //TO DO
            //this.humanGenerationTable.SuspendLayout();
            // this.humanGenerationTable.RowCount++;
            //this.humanGenerationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            //this.humanGenerationTable.Padding = new Padding(0,0,0, this.humanGenerationTable.Padding.Bottom-24);
            //this.humanGenerationTable.Size= new Size(this.humanGenerationTable.Size.Width, this.humanGenerationTable.Size.Height+30);
            for (int i = 0; i < this.planFireAlarmTable.ColumnCount; i++)
            {
                System.Windows.Forms.NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
                // numericUpDown.Name = "numericUpDown";
                numericUpDown.Size = new System.Drawing.Size(146, 20);
                numericUpDown.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
                this.planFireAlarmTable.Controls.Add(numericUpDown);
                //((System.ComponentModel.ISupportInitialize)(numericUpDown)).BeginInit();
            }
            //this.humanGenerationTable.ResumeLayout(false);
            // this.humanGenerationTable.PerformLayout();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //TO DO
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
            if (Row == 0) return;
            for (int i = this.planFireAlarmTable.ColumnCount - 1; i >= 0; i--)
                this.planFireAlarmTable.Controls.Remove(this.planFireAlarmTable.GetControlFromPosition(i, Row));
            Row--;
        }
    }
}
