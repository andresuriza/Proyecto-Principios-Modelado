namespace TabletUI
{
    public partial class ReporteMaquinaria : Form
    {
        int codigo;
        string estado = "funcional";
        public ReporteMaquinaria(int codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            var w1 = new OpcionesTecnico(codigo, 0);
            w1.Show();
        }

        private void estadoButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (estado == "funcional")
            {
                estado = "fallo";
                estadoLabel.Text = "con fallos";
                estadoButton.Text = "Marcar funcional";
            }
            else
            {
                estado = "funcional";
                estadoLabel.Text = "funcionando";
                estadoButton.Text = "Marcar fallo";
            }
        }

        private void ReporteMaquinaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.Test();
        }
    }
}
