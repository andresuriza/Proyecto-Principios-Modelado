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

        // Constructor que crea interfaz y guarda valores de codigo del usuario y linea
        public OpcionesTecnico(int codigo, int linea)
        {
            this.codigo = codigo;
            this.linea = linea;
            InitializeComponent();

        }
        
        // Boton que abre la ventana el reporte de maquinaria
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            var w1 = new ReporteMaquinaria(codigo, linea);
            w1.CheckLinea();
            w1.Show();
            this.Visible = false;
        }

        // Boton que abre ventana para ver lista de empleados en la linea
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            var miembrosWin = new ListaMiembros(codigo, linea);
            miembrosWin.Show();
            this.Visible = false;
        }

        // Boton que abre la ventana para ver opciones de los lotes
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            var loteWin = new OpcionesLote(codigo, linea);
            loteWin.Show();
            this.Visible = false;
        }

        // Boton que regresa usuario a la ventana de ingreso
        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            var logWin = new PantallaIngreso();
            logWin.Show();
            this.Visible = false;
        }

        // Llama a la clase estadisticas al cerrarse
        private void OpcionesTecnico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
}
