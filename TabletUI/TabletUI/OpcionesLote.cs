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

        // Constructor que crea interfaz, guarda valores de codigo de usuario y linea, tambien llama al metodo para obtener
        // lotes
        public OpcionesLote(int codigo, int linea)
        {
            this.codigo = codigo;
            this.linea = linea;
            InitializeComponent();

            GetLotes();
        }

        // Metodo que obtiene todos los lotes activos en una linea
        private void GetLotes()
        {
            foreach (var lote in lotControllerLinea.GetAllLotesPorLineas())
            {
                Lote loteEspecifico = lotController.GetLoteById(lote.Loteid);
                if (loteEspecifico.Estado != 3 && lote.Lineaid == linea)
                {
                    listBox1.Items.Add("Id: " + loteEspecifico.Id + " Descripcion: " + loteEspecifico.Descripcion +
                        " ProductoId: " + loteEspecifico.Productoid + " Cant.Esperada: " + loteEspecifico.Cantidadrequerida +
                        " Cant.Obtenida de momento: " + loteEspecifico.Cantidadobtenida);
                }
            }
        }

        // Boton que regresa al usuario ya sea tecnico o operador a su ventana de opciones
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

        // Boton que abre ventana para crear lote
        private void button1_Click(object sender, EventArgs e)
        {
            var window = new CrearLote(linea);
            window.ShowDialog();
            listBox1.Items.Clear();
            GetLotes();
        }

        // Boton que marca un lote como finalizado y lo elimina de la lista
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

        // Llama a la clase estadisticas al cerrarse
        private void OpcionesLote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.RunStats();
        }

    }     
}