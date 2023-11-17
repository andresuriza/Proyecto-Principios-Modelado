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
        LotePorLineaController lotControllerLinea = new LotePorLineaController();
        UsuarioController uc = new UsuarioController();
        LoteController lotController = new LoteController();
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
            int linea = int.Parse((sender as Button).Text);
            string cedula = uc.GetUsuarioByCodigo(codigo).Cedula;

            int n = 0;

            foreach (var empleadoLista in usrPerLine.GetAllUsuarios())
            {
                if (empleadoLista.Lineaid == linea)
                {
                    n++;                      
                }
            }

            if (n <= 8 || usrTipo == 2)
            {
                if (usrTipo == 3 && usrPerLine.GetUsuarioLinea(cedula) != linea)
                {
                    uc.UpdateTipo(cedula, 1);
                }

                usrPerLine.CheckUsuarioEnLinea(cedula, linea, new DateOnly(DateTime.Now.Year,
                DateTime.Now.Month, DateTime.Now.Day), new TimeOnly(9, 0), new TimeOnly(0, 0));

                var registroWin = new RegistradoEmp(uc.GetUsuarioType(codigo), linea, cedula, "");
                registroWin.Show();
                this.Visible = false;
            }
            else 
            {}
            
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

        private void SelectLine_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
