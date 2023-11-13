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
        public ListaMiembros(int codigo, int lineaId)
        {

            this.codigo = codigo;
            this.lineaId = lineaId;
            InitializeComponent();
            GetMiembros();
            //deleteAll();
        }

        private void deleteAll()
        {
            foreach (var empleadoLista in usrPerLinea.GetAllUsuarios())
            {
                Usuario empleado = uc.GetUsuarioByCedula(empleadoLista.Cedula);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 1);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 2);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 3);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 4);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 5);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 6);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 7);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 8);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 9);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 10);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 11);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 12);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 13);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 14);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 15);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 16);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 17);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 18);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 19);
                usrPerLinea.DeleteUsuarioEnLinea(empleado.Cedula, 20);
            }
        }

        private void GetMiembros()
        {

            foreach (var empleadoLista in usrPerLinea.GetAllUsuarios())
            {
                Usuario empleado = uc.GetUsuarioByCedula(empleadoLista.Cedula);

                if (empleadoLista.Lineaid == lineaId)
                {
                    if (empleado.Tipousuarioid == 1) // Si es operario
                    {
                        listBox1.Items.Add(empleado.Cedula + " " + empleado.Nombre + " " + empleado.Apellido1 + " " +
                            empleado.Apellido2);
                    }
                    else if (empleado.Tipousuarioid == 3) // Si es tecnico
                    {
                        listBox1.Items.Add(empleado.Cedula + " " + empleado.Nombre + " " + empleado.Apellido1 + " " +
                            empleado.Apellido2 + " (Tecnico)");
                    }
                }
            }
        }

        private void removeTecnicos()
        {
            foreach (var empleadoLista in usrPerLinea.GetAllUsuarios())
            {
                Usuario empleado = uc.GetUsuarioByCedula(empleadoLista.Cedula);
               
                if (empleado.Tipousuarioid == 3) // Si es tecnico
                {
                    if (empleadoLista.Lineaid == lineaId)
                    {
                        uc.UpdateTipo(empleadoLista.Cedula, 1);
                    }
                }
            }
        }

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

        private void listBox1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (codigo == 2) // Solamente si es supervisor
            {
                int index = this.listBox1.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    removeTecnicos();
                    uc.UpdateTipo(listBox1.Items[index].ToString().Substring(0, 9), 3);
                    listBox1.Items.Clear();
                    GetMiembros();
                }
            }
        }
    }
}
