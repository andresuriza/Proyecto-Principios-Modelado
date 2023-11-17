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

                var registroWin = new RegistradoEmp(0, 0, "", "break");
                registroWin.Show();
                this.Visible = false;

                emp.SetInitialTime(pastTime);
                emp.Break(currTime);

                string[] authors;

                authors = new string[] {"Empleado: " +  cedula, "Inicio: " + emp.initialTime,
                    "Actual: " + currTime, "Break finalizado, " + "horas laboradas: " + emp.GetWorkTime()};

                File.WriteAllLines("Empleados.txt", authors);

                currTime = new TimeOnly(17, 0);

                emp.Resume(new TimeOnly(14, 0));
                emp.Break(currTime);

                authors = new string[] {"Empleado: " +  cedula, "Inicio: " + emp.initialTime,
                    "Actual: " + currTime, "Break finalizado, " + "horas laboradas: " + emp.GetWorkTime()};

                File.AppendAllLines("Empleados.txt", authors);
                
                string readText = File.ReadAllText("empleados.txt");
                Debug.WriteLine(readText);
            }
        }

        private void OpcionesEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
    public class Empleado
    {
        public TimeSpan workTime;
        public TimeOnly initialTime;
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