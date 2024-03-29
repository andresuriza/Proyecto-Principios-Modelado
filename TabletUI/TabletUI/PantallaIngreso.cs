﻿using BaseDatos.Controllers;
using BaseDatos.Models;
using System.Diagnostics;

namespace TabletUI
{
    public partial class PantallaIngreso : Form
    {
        private string codigo;
        UsuarioController uc = new UsuarioController();

        // Constructor interfaz
        public PantallaIngreso()
        {
            InitializeComponent();
        }

        // Metodo al presionar boton de ingreso que procesa el codigo ingresado
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            codigo = richTextBox1.Text;


            if (uc.GetUsuarioName(codigo) == codigo)
            {
                var w1 = new SelectLine(uc.GetUsuarioType(codigo), codigo);
                w1.Show();
                this.Visible = false;
            }

            else if (uc.GetUsuarioName(codigo) == "n/a")
            {
                errorLabel.Show();
            }
        }

        // Llama a la clase estadisticas al cerrarse
        private void PantallaIngreso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }

        private void PantallaIngreso_Load(object sender, EventArgs e)
        {

        }
    }
}
