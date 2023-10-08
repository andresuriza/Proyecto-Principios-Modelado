using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_proyecto
{
    public partial class PantallaIngreso : Form
    {
        public PantallaIngreso()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            var w1 = new SelectLine();
            w1.Show();
        }
    }
}
