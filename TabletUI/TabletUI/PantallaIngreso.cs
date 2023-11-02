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
    public partial class PantallaIngreso : Form
    {
        public PantallaIngreso()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string codigo = richTextBox1.Text;
            var w1 = new SelectLine(codigo);
            w1.Show();
            this.Visible = false;
        }
    }
}
