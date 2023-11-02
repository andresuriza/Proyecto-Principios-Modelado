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
    public partial class OpcionesSupervisor : Form
    {
        public OpcionesSupervisor()
        {
            InitializeComponent();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            var miembrosWin = new ListaMiembros();
            miembrosWin.Show();
            this.Visible = false;

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            var loteWin = new OpcionesLote();
            loteWin.Show();
            this.Visible = false;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
