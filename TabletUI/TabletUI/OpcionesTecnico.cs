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
    public partial class OpcionesTecnico : Form
    {
        public OpcionesTecnico()
        {
            InitializeComponent();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            var w1 = new ReporteMaquinaria();
            w1.Show();
        }
    }
}
