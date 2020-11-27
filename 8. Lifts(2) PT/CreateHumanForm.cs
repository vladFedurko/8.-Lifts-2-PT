using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Entities;

namespace _8.Lifts_2__PT
{
    public partial class CreateHumanForm : Form
    {
        Humans a;
        public CreateHumanForm()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            //TO DO
            Console.WriteLine("hello world");
            if (a == null)
                a = new Humans(1, 0, 2);
            //this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (a != null)
                a.Move();
            this.Close();
        }

        private void CreateHumanForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateHumanForm_Deactivate(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
