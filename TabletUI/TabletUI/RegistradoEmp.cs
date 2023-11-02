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
        string codigo;
        public RegistradoEmp(string  codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (codigo == "empleado")
            {
                var opEmpleado = new OpcionesEmpleado();
                opEmpleado.Show();
            }

            else if (codigo == "supervisor") {
                var opSupervisor = new OpcionesSupervisor();
                opSupervisor.Show();
            }

            else if (codigo == "tecnico")
            {
                var opTecnico = new OpcionesTecnico();
                opTecnico.Show();
            }

            this.Visible = false;
        }
    }
}
