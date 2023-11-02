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
    public partial class OpcionesEmpleado : Form
    {
        public OpcionesEmpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void returnButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            var w1 = new PantallaIngreso();
            w1.Show();
        }

        private void terminarButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void breakButton_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
