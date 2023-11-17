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
    public partial class RegistradoEmp : Form
    {
        int codigo;
        int linea;
        string cedula;
        string tipo;

        public RegistradoEmp(int codigo, int linea, string cedula, string tipo)
        {
            this.cedula = cedula;
            this.codigo = codigo;
            this.linea = linea;
            this.tipo = tipo;

            InitializeComponent();

            if (tipo == "break")
            {
                label1.Text = "Se registró su break, al ingresar de nuevo se continuará su jornada";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipo == "break")
            {
                this.Visible = false;
                var w1 = new PantallaIngreso();
                w1.Show();
            }

            else
            {
                if (codigo == 1)
                {
                    var opEmpleado = new OpcionesEmpleado(cedula);
                    opEmpleado.Show();
                }

                else if (codigo == 2)
                {
                    var opSupervisor = new OpcionesSupervisor(codigo, linea);
                    opSupervisor.Show();
                }

                else if (codigo == 3)
                {
                    var opTecnico = new OpcionesTecnico(codigo, linea);
                    opTecnico.Show();
                }

                this.Visible = false;
            }
        }

        private void RegistradoEmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.Test();
        }
    }
}
