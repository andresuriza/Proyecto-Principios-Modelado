namespace TabletUI
{
    public partial class OpcionesSupervisor : Form
    {
        int codigo;
        public OpcionesSupervisor(int codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            var miembrosWin = new ListaMiembros(codigo);
            miembrosWin.Show();
            this.Visible = false;

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            var loteWin = new OpcionesLote(codigo);
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
