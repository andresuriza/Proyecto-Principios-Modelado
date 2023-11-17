using BaseDatos.Controllers;
using BaseDatos.Models;
using System;
using System.Diagnostics;

namespace TabletUI
{
    public partial class OpcionesEmpleado : Form
    {
        UsuarioPorLineaController usrPerLinea = new UsuarioPorLineaController();
        string cedula;
        Empleado emp = new Empleado();

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
            if (emp.GetOnBreak() == false)
            {
                emp.onBreak = true;
                
                TimeOnly pastTime = usrPerLinea.GetUsuarioTime(cedula);
                //TimeOnly currTime = new TimeOnly(DateTime.Now.Hour + 2, DateTime.Now.Minute);
                TimeOnly currTime = new TimeOnly(13, 0);

                Debug.Write("Inicio: ");
                Debug.WriteLine(pastTime);

                Debug.Write("Actual: ");
                Debug.WriteLine(currTime);

                emp.SetInitialTime(pastTime);
                Debug.Write("Break iniciado, horas laboradas: ");
                emp.Break(currTime);
                Debug.WriteLine(emp.GetWorkTime());

                var registroWin = new RegistradoEmp(0, 0, "", "break");
                registroWin.Show();
                this.Visible = false;
                //-------------Se continua trabajando------------------------------
                emp.Resume(new TimeOnly(14, 0));
                emp.Break(new TimeOnly(17, 0));
                Debug.WriteLine(emp.GetWorkTime());
            }
        }
    }
    public class Empleado
    {
        private TimeSpan workTime;
        private TimeOnly initialTime;
        public Boolean onBreak = false; 

        public void SetInitialTime(TimeOnly initialTime)
        {
            this.initialTime = initialTime;
        }
       
        public void Break(TimeOnly currTime)
        {
            workTime = workTime + (currTime - initialTime);
        }

        public void Resume(TimeOnly currTime)
        {
            initialTime = currTime;
        }

        public TimeSpan GetWorkTime()
        {
            return workTime;
        }

        public Boolean GetOnBreak()
        {
            return onBreak;
        }
    }
}