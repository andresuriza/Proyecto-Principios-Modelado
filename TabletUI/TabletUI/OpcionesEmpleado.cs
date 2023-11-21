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
        
        public OpcionesEmpleado(string cedula)
        {
            this.cedula = cedula;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void returnButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            var w1 = new PantallaIngreso();
            w1.Show();
        }

        private void terminarButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void breakButton_MouseClick(object sender, MouseEventArgs e)
        {
            usrPerLinea.UpdateUsuarioTime(this.cedula, new TimeOnly(0,15));

            var registroWin = new RegistradoEmp(0, 0, "", "break");
            registroWin.Show();
            this.Visible = false;
        }

        private void OpcionesEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
    //public class Empleado
    //{
    //    public TimeSpan workTime;
    //    public TimeOnly initialTime;
    //    public Boolean onBreak = false;

    //    public void SetInitialTime(TimeOnly initialTime)
    //    {
    //        this.initialTime = initialTime;
    //    }

    //    public void Break(TimeOnly currTime)
    //    {
    //        workTime = workTime + (currTime - initialTime);
    //    }

    //    public void Resume(TimeOnly currTime)
    //    {
    //        initialTime = currTime;
    //    }

    //    public TimeSpan GetWorkTime()
    //    {
    //        return workTime;
    //    }

    //    public Boolean GetOnBreak()
    //    {
    //        return onBreak;
    //    }
    //}
}