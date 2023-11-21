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
        int codigo;
        int linea;
        public OpcionesTecnico(int codigo, int linea)
        {
            this.codigo = codigo;
            this.linea = linea;
            InitializeComponent();

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            var w1 = new ReporteMaquinaria(codigo, linea);
            w1.CheckLinea();
            w1.Show();
            this.Visible = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            var miembrosWin = new ListaMiembros(codigo, linea);
            miembrosWin.Show();
            this.Visible = false;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            var loteWin = new OpcionesLote(codigo, linea);
            loteWin.Show();
            this.Visible = false;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            var logWin = new PantallaIngreso();
            logWin.Show();
            this.Visible = false;
        }

        private void OpcionesTecnico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
}
