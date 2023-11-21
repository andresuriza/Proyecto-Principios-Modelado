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
        public ReporteMaquinaria(int codigo, int linea)
        {
            this.codigo = codigo;
            this.linea = linea;
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            var w1 = new OpcionesTecnico(codigo, linea);
            w1.Show();
        }

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

        private void ReporteMaquinaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }
    }
}
