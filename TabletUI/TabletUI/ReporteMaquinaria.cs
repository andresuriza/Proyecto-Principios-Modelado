using BaseDatos.Controllers;
using System.Diagnostics;

namespace TabletUI
{
    public partial class ReporteMaquinaria : Form
    {
        int codigo;
        string estado;
        int linea;
        LineaController lineaController = new LineaController();

        // Constructor que crea interfaz y guarda valores de codigo de usuario y la linea
        public ReporteMaquinaria(int codigo, int linea)
        {
            this.codigo = codigo;
            this.linea = linea;
            InitializeComponent();
        }

        // Boton que regresa tecnico a la ventana de opciones
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            var w1 = new OpcionesTecnico(codigo, linea);
            w1.Show();
        }

        // Metodo que revisa si la maquinaria en la linea esta funcionando o no
        public void CheckLinea()
        {
            foreach (var lineas in lineaController.GetAllLineas())
            {
                if (lineas.Id == linea)
                {
                    if (lineas.Estadoid == 1)
                    {
                        estado = "funcional";
                        estadoLabel.Text = "funcionando";
                        estadoButton.Text = "Marcar fallo";
                    }

                    else if (lineas.Estadoid == 2)
                    {
                        estado = "no funcional";
                        estadoLabel.Text = "con fallos";
                        estadoButton.Text = "Marcar funcional";
                    }
                }
            }
        }

        // Boton que cambia el estado de la linea a funcional o no funcional
        private void estadoButton_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var lineas in lineaController.GetAllLineas())
            {
                if (lineas.Id == linea)
                {
                    if (lineas.Estadoid == 1)
                    {
                        lineaController.UpdateLinea(linea, 2);
                        estado = "fallo";
                        estadoLabel.Text = "con fallos";
                        estadoButton.Text = "Marcar funcional";
                    }
                    else if (lineas.Estadoid == 2)
                    {
                        lineaController.UpdateLinea(linea, 1);
                        estado = "funcional";
                        estadoLabel.Text = "funcionando";
                        estadoButton.Text = "Marcar fallo";
                    }
                }
            }
        }

        // Llama a la clase estadisticas al cerrarse
        private void ReporteMaquinaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
}
