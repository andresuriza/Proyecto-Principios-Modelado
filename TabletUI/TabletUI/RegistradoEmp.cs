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

        public RegistradoEmp(int codigo, int linea)
        {
            this.codigo = codigo;
            this.linea = linea;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (codigo == 1)
            {
                // TODO: regresar a pantalla primero
                var opEmpleado = new OpcionesEmpleado();
                opEmpleado.Show();
            }

            else if (codigo == 2) {
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
}
