namespace TabletUI
{
    public partial class OpcionesSupervisor : Form
    {
        int codigo;
        int linea;
        public OpcionesSupervisor(int codigo, int linea)
        {
            this.codigo = codigo;
            this.linea = linea;
            InitializeComponent();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            var miembrosWin = new ListaMiembros(codigo, linea);
            miembrosWin.Show();
            this.Visible = false;

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            var loteWin = new OpcionesLote(codigo, linea);
            loteWin.Show();
            this.Visible = false;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            // Logica para break
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var logWin = new PantallaIngreso();
            logWin.Show();
            this.Visible = false;
        }
    }
}
