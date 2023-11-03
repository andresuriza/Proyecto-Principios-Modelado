using BaseDatos.Controllers;
using BaseDatos.Models;
using System.Diagnostics;

namespace TabletUI
{
    public partial class PantallaIngreso : Form
    {
        private string codigo;
        private int tipo;
        UsuarioController uc = new UsuarioController();
        public PantallaIngreso()
        {
            InitializeComponent();
        }

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
    }
}
