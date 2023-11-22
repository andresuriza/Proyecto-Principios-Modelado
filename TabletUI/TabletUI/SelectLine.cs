﻿using BaseDatos.Controllers;

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

        // Constructor que crea interfaz y guarda valores del tipo de usuario y su codigo
        public SelectLine(int usrTipo, string codigo)
        {
            this.usrTipo = usrTipo;
            this.codigo = codigo;
            InitializeComponent();
        }

        // Metodo que procesa la ventana a abrir al seleccionar una linea 
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

            if (usrPerLine.GetUsuarioLinea(cedula) == linea || usrTipo == 2)
            {
                usrPerLine.UpdateUsuarioTime(cedula, new TimeOnly(0,0));
                var registroWin = new RegistradoEmp(uc.GetUsuarioType(codigo), linea, cedula, "");
                registroWin.Show();
                this.Visible = false;
            }
            else if (n <= 7) 
            {
                if (usrTipo == 3) 
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
            { }
        }

        // Llama a la clase estadisticas al cerrarse
        private void SelectLine_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
}
