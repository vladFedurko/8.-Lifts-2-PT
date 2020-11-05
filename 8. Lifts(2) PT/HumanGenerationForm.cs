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
        public int Row { get; set; }
        public HumanGenerationForm()
        {
            InitializeComponent();
            Row = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            

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
            
        }
    }
}
