using BaseDatos.Controllers;
using BaseDatos.Models;
using System.Diagnostics;

namespace TabletUI
{
    public partial class OpcionesLote : Form
    {
        int codigo;
        int linea;

        LotePorLineaController lotControllerLinea = new LotePorLineaController();
        LoteController lotController = new LoteController();
        public OpcionesLote(int codigo, int linea)
        {
            this.codigo = codigo;
            this.linea = linea;
            InitializeComponent();

            GetLotes();
        }

        private void GetLotes()
        {
            foreach (var lote in lotControllerLinea.GetAllLotesPorLineas())
            {
                Lote loteEspecifico = lotController.GetLoteById(lote.Loteid);
                if (loteEspecifico.Estado != 3)
                {
                    if (lote.Lineaid == linea)
                    {
                        listBox1.Items.Add("Id: " + loteEspecifico.Id + " Descripcion: " + loteEspecifico.Descripcion +
                            " ProductoId: " + loteEspecifico.Productoid + " Cant.Esperada: " + loteEspecifico.Cantidadrequerida +
                            " Cant.Obtenida de momento: " + loteEspecifico.Cantidadobtenida);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codigo == 2)
            {
                var superWin = new OpcionesSupervisor(codigo, linea);
                superWin.Show();
            }
            else if (codigo == 3)
            {
                var superWin = new OpcionesTecnico(codigo, linea);
                superWin.Show();
            }

            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var window = new CrearLote(linea);
            window.ShowDialog();
            listBox1.Items.Clear();
            GetLotes();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                int Start = listBox1.Items[index].ToString().IndexOf("Id: ", 0) + "Id: ".Length;
                int End = listBox1.Items[index].ToString().IndexOf(" D", Start);

                string idToDelete = listBox1.Items[index].ToString().Substring(Start, End - Start);
                Lote loteEspecifico = lotController.GetLoteById(idToDelete);

                lotController.UpdateStatusLote(idToDelete, 3);

                listBox1.Items.Clear();
                GetLotes();
            }
        }

        private void OpcionesLote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }

    }     
}