using BaseDatos.Controllers;
using BaseDatos.Models;
using System.Windows.Forms;

namespace TabletUI
{
    public partial class OpcionesSupervisor : Form
    {
        int codigo;
        int linea;
        UsuarioPorLineaController usrPerLinea = new UsuarioPorLineaController();
        UsuarioController uc = new UsuarioController();
        public OpcionesSupervisor(int codigo, int linea)
        {
            this.codigo = codigo;
            this.linea = linea;
            InitializeComponent();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
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
            foreach (var empleadoLista in usrPerLinea.GetAllUsuarios())
            {
                Usuario empleado = uc.GetUsuarioByCedula(empleadoLista.Cedula);

                if (empleadoLista.Lineaid == linea)
                {
                    if (empleado.Tipousuarioid != 2) // Si no es supervisor
                    {
                        usrPerLinea.UpdateUsuarioTime(empleado.Cedula, new TimeOnly(0, 15));
                    }
                }
            }

            var registroWin = new RegistradoEmp(0, 0, "", "break");
            registroWin.Show();
            this.Visible = false;
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var logWin = new PantallaIngreso();
            logWin.Show();
            this.Visible = false;
        }

        private void OpcionesSupervisor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
}
