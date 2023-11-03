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
        int codigo;
        string estado = "funcional";
        public ReporteMaquinaria(int codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            var w1 = new OpcionesTecnico(codigo);
            w1.Show();
        }

        private void estadoButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (estado == "funcional")
            {
                estado = "fallo";
                estadoLabel.Text = "con fallos";
                estadoButton.Text = "Marcar funcional";
            }
            else
            {
                estado = "funcional";
                estadoLabel.Text = "funcional";
                estadoButton.Text = "Marcar fallo";
            }
        }
    }
}
