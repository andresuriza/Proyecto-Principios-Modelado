using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabletUI
{
    public partial class ReporteMaquinaria : Form
    {
        public ReporteMaquinaria()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            var w1 = new OpcionesTecnico();
            w1.Show();
        }
    }
}
