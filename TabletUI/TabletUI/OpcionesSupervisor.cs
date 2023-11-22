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

        // Constructor que crea interfaz y guarda valores de codigo y linea del supervisor
        public OpcionesSupervisor(int codigo, int linea)
        {
            this.codigo = codigo;
            this.linea = linea;
            InitializeComponent();
        }

        // Boton que abre la interfaz para ver los empleados en la linea
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            var miembrosWin = new ListaMiembros(codigo, linea);
            miembrosWin.Show();
            this.Visible = false;

        }

        // Boton que abre la interfaz para accesar las opciones del lote
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            var loteWin = new OpcionesLote(codigo, linea);
            loteWin.Show();
            this.Visible = false;
        }

        // Boton que procesa un break de 15 minutos para todos los empleados en la linea
        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var empleadoLista in usrPerLinea.GetAllUsuarios())
            {
                Usuario empleado = uc.GetUsuarioByCedula(empleadoLista.Cedula);

                if (empleadoLista.Lineaid == linea && empleado.Tipousuarioid != 2)
                {
                    usrPerLinea.UpdateUsuarioTime(empleado.Cedula, new TimeOnly(0, 15));
                }
            }

            var registroWin = new RegistradoEmp(0, 0, "", "break");
            registroWin.Show();
            this.Visible = false;
        }

        // Boton que devuelve a la pantalla de ingreso
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var logWin = new PantallaIngreso();
            logWin.Show();
            this.Visible = false;
        }

        // Llama a la clase estadisticas al cerrarse
        private void OpcionesSupervisor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
}
