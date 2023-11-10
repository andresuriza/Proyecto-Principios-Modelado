using BaseDatos.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabletUI
{
    public partial class SelectLine : Form
    {
        int usrTipo;
        string codigo;
        UsuarioPorLineaController usrPerLine = new UsuarioPorLineaController();
        UsuarioController uc = new UsuarioController();
        public SelectLine(int usrTipo, string codigo)
        {
            this.usrTipo = usrTipo;
            this.codigo = codigo;
            InitializeComponent();
        }

        private void SelectLine_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            int linea = Int32.Parse((sender as Button).Text);
            string cedula = uc.GetUsuarioByCodigo(codigo).Cedula;
            usrPerLine.AddUsuarioEnLinea(cedula, linea, new DateOnly(2023,
                11, 03), new TimeOnly(9, 0), new TimeOnly(17, 0));

            //usrPerLine.DeleteUsuarioEnLinea("118891234", 1);
            var registroWin = new RegistradoEmp(usrTipo, linea);
            registroWin.Show();
            this.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
