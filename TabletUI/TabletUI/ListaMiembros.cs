using BaseDatos.Controllers;
using BaseDatos.Models;
using System.Diagnostics;

namespace TabletUI
{
    public partial class ListaMiembros : Form
    {
        int codigo;
        int lineaId;

        UsuarioController uc = new UsuarioController();
        UsuarioPorLineaController usrPerLinea = new UsuarioPorLineaController();

        // Constructor que crea interfaz y obtiene empleados en lista para mostrarlos en la listbox
        public ListaMiembros(int codigo, int lineaId)
        {

            this.codigo = codigo;
            this.lineaId = lineaId;
            InitializeComponent();
            GetEmpleados();
            //deleteAll();
        }

        // Metodo que elimina todos los empleados en todas las lineas
        private void deleteAll()
        {
            foreach (var empleadoLista in usrPerLinea.GetAllUsuarios())
            {
                Usuario empleado = uc.GetUsuarioByCedula(empleadoLista.Cedula);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, usrPerLinea.GetUsuarioLinea(empleado.Cedula));
            }
        }

        // Metodo que obtiene los operarios y tecnicos en una linea y lo agrega a la listbox, si es tecnico se indica en la listbox
        private void GetEmpleados()
        {
            foreach (var empleadoLista in usrPerLinea.GetAllUsuarios())
            {
                Usuario empleado = uc.GetUsuarioByCedula(empleadoLista.Cedula);

                if (empleadoLista.Lineaid == lineaId)
                {
                    if (empleado.Tipousuarioid == 1)
                    {
                        listBox1.Items.Add(empleado.Cedula + " " + empleado.Nombre + " " + empleado.Apellido1 + " " +
                            empleado.Apellido2);
                    }
                    else if (empleado.Tipousuarioid == 3)
                    {
                        listBox1.Items.Add(empleado.Cedula + " " + empleado.Nombre + " " + empleado.Apellido1 + " " +
                            empleado.Apellido2 + " (Tecnico)");
                    }
                }
            }
        }

        // Metodo que convierte a los tecnicos en operarios
        private void removeTecnicos()
        {
            foreach (var empleadoLista in usrPerLinea.GetAllUsuarios())
            {
                Usuario empleado = uc.GetUsuarioByCedula(empleadoLista.Cedula);

                if (empleado.Tipousuarioid == 3 && empleadoLista.Lineaid == lineaId)
                {
                    uc.UpdateTipo(empleadoLista.Cedula, 1);
                }
            }
        }

        // Boton que regresa a usuario a su ventana de opciones correspondiente, ya sea supervisor o tecnico
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (codigo == 2)
            {
                var superWin = new OpcionesSupervisor(codigo, lineaId);
                superWin.Show();
            }
            else if (codigo == 3)
            {
                var superWin = new OpcionesTecnico(codigo, lineaId);
                superWin.Show();
            }

            this.Visible = false;
        }

        // Metodo que permite al supervisor volver tecnico a un empleado al hacer doble click en la listbox
        private void listBox1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (codigo == 2)
            {
                int index = this.listBox1.IndexFromPoint(e.Location);

                if (index != ListBox.NoMatches)
                {
                    removeTecnicos();
                    uc.UpdateTipo(listBox1.Items[index].ToString().Substring(0, 9), 3);
                    listBox1.Items.Clear();
                    GetEmpleados();
                }
            }
        }

        // Llama a la clase estadisticas al cerrarse
        private void ListaMiembros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
}