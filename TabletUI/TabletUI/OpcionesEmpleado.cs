using BaseDatos.Controllers;
using BaseDatos.Models;
using System;
using System.Diagnostics;

namespace TabletUI
{
    public partial class OpcionesEmpleado : Form
    {
        UsuarioPorLineaController usrPerLinea = new UsuarioPorLineaController();
        UsuarioController uc = new UsuarioController();
        string cedula;

        // Constructor que crea interfaz y guarda valor de cedula
        public OpcionesEmpleado(string cedula)
        {
            this.cedula = cedula;
            InitializeComponent();
        }

        // Metodo que regresa usuario a la pantalla de ingreso
        private void returnButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            var w1 = new PantallaIngreso();
            w1.Show();
        }

        // Metodo que registra hora actual a la que el empleado termino su turno
        private void terminarButton_MouseClick(object sender, MouseEventArgs e)
        {
            usrPerLinea.UpdateUsuarioTime(cedula, new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute));
        }

        // Metodo que agrega un break de 15 minutos al tiempo de trabajo del empleado
        private void breakButton_MouseClick(object sender, MouseEventArgs e)
        {
            usrPerLinea.UpdateUsuarioTime(this.cedula, new TimeOnly(0, 15));

            var registroWin = new RegistradoEmp(0, 0, "", "break");
            registroWin.Show();
            this.Visible = false;
        }

        // Llama a la clase estadisticas al cerrarse
        private void OpcionesEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
}