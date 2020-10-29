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
    public partial class HumanGenerationForm : Form
    {
        public HumanGenerationForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //TO DO
            this.humanGenerationTable.RowCount++;

            for (int i = 0; i < this.humanGenerationTable.ColumnCount; i++)
            {
                System.Windows.Forms.NumericUpDown numericUpDown = new NumericUpDown();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
                this.humanGenerationTable.Controls.Add(numericUpDown, i, this.humanGenerationTable.RowCount);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //TO DO
            this.Close();

        }

        private void DenyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HumanGenerationForm_Load(object sender, EventArgs e)
        {

        }

        private void HumanGenerationForm_Deactivate(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
