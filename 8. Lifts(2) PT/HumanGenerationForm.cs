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
            //this.humanGenerationTable.RowCount++;
            this.humanGenerationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.humanGenerationTable.Size= new Size(this.humanGenerationTable.Size.Width, this.humanGenerationTable.Size.Height+24);
            for (int i = 0; i < this.humanGenerationTable.ColumnCount; i++)
            {
                System.Windows.Forms.NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
                numericUpDown.Name = "numericUpDown";
                //numericUpDown.Size = new System.Drawing.Size(146, 20);
                if (i == 1 || i == 2)
                {
                    numericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
                    numericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
                    numericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
                }
                if(i==4)
                numericUpDown.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
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

    }
}
