using BaseDatos.Controllers;
using BaseDatos.Models;
using System.Diagnostics;

namespace TabletUI
{
    public partial class ListaMiembros : Form
    {
        int codigo;
        UsuarioController uc = new UsuarioController();
        public ListaMiembros(int codigo)
        {
            
            this.codigo = codigo;
            InitializeComponent();
            GetMiembros();
        }

        private void GetMiembros()
        {
            foreach (var empleado in uc.GetAllUsuarios())
            {
                
                if (empleado.Tipousuarioid == 3)
                {
                    listBox1.Items.Add(empleado.Nombre + " " + empleado.Apellido1 + " " + empleado.Apellido2 + " (Técnico)");
                }

                else if (empleado.Tipousuarioid == 1)
                {
                    listBox1.Items.Add(empleado.Nombre + " " + empleado.Apellido1 + " " + empleado.Apellido2);
                }
                    
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.SelectedItem = "Técnico actual";
        }

        private void GestionarTecnico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (codigo == 2)
            {
                var superWin = new OpcionesSupervisor(codigo);
                superWin.Show();
            }
            else if (codigo == 3)
            {
                var superWin = new OpcionesTecnico(codigo);
                superWin.Show();
            }

            this.Visible = false;
        }
    }
}
