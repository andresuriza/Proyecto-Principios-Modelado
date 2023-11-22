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

        // Constructor que crea interfaz y guarda valores de cedula, codigo, linea y tipo de usuario. Tambien se reutiliza para la
        // ventana emergente de inicio de un break
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

        // Boton que verifica que tipo de usuario es y abre la ventana correspondiente, si es un break regresa a la pantalla de
        // ingreso
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

        // Llama a la clase estadisticas al cerrarse
        private void RegistradoEmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
}
