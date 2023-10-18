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
    public partial class SelectLine : Form
    {
        public SelectLine()
        {
            InitializeComponent();
        }

        private void SelectLine_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            var r1 = new RegistradoEmp();
            this.Visible = false;
            r1.Show();

            // var r1 = new RegistradoEmp();
            // this.Close();
            // r1.Show();
        }
    }
}