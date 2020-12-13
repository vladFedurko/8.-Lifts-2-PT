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
    public partial class CreateHumanForm : Form, ICreateHumanView
    {
        public event Action<int, int, int> CreateHuman;

        public CreateHumanForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.CreateHuman?.Invoke((int)initialFloorSelector.Value, (int)finiteFloorSelector.Value, (int)inSecondsSelector.Value);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateHumanForm_Deactivate(object sender, EventArgs e)
        {
            this.Activate();
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
