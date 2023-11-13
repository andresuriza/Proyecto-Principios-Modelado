using BaseDatos.Controllers;
using BaseDatos.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

            if (usrTipo == 3) { // Si tecnico cambia, se vuelve operario de nuevo
                uc.UpdateTipo(cedula, 1);
            }
            
            usrPerLine.AddUsuarioEnLinea(cedula, linea, new DateOnly(DateTime.Now.Year,
                DateTime.Now.Month, DateTime.Now.Day), new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute), new TimeOnly(0, 0));

            var registroWin = new RegistradoEmp(uc.GetUsuarioType(codigo), linea);
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
