using Presenters;
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
    public partial class HelpForm : Form, IView
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void ShowForm()
        {
            this.Show();
        }
    }
}
