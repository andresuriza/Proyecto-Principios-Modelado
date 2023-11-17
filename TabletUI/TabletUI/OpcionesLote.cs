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
                if (lote.Lineaid == linea)
                {
                    listBox1.Items.Add("Id: " + loteEspecifico.Id + " Descripcion: " + loteEspecifico.Descripcion +
                        " ProductoId: " + loteEspecifico.Productoid + " Cant.Esperada: " + loteEspecifico.Cantidadrequerida +
                        " Cant.Obtenida de momento: " + loteEspecifico.Cantidadobtenida);
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

                //lotControllerLinea.DeleteLotePorLinea(idToDelete, linea);
                //lotController.DeleteLote(idToDelete);
                // Modificar e indicar que ya se terminó
                listBox1.Items.Clear();
                GetLotes();

                //-------------------------------------------------------------------------------------------

                TimeOnly pastTime = lotControllerLinea.GetLoteTime(idToDelete);

                TimeOnly currTime = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute);

                TimeSpan elapsedTime = currTime - pastTime;

                string[] authors;

                authors = new string[] {"Id: " + idToDelete, "Descripcion: " + loteEspecifico.Descripcion, 
                    "ProductoId: " + loteEspecifico.Productoid, "Cant.Esperada: " + loteEspecifico.Cantidadrequerida,
                    "Cant.Obtenida de momento: " + loteEspecifico.Cantidadrequerida, "Inicio: " + pastTime, 
                    "Tiempo de setup: " + elapsedTime * 0.6, "Tiempo de envasado: " + elapsedTime * 0.1, 
                    "Tiempo de etiquetado: " + elapsedTime * 0.05, "Tiempo de sellado: " + elapsedTime * 0.05, 
                    "Tiempo de finalización: " + elapsedTime * 0.2, "Fin: " + currTime, 
                    "------------------------------------------"};

                File.AppendAllLines("Lotes.txt", authors);
                string readText = File.ReadAllText("Lotes.txt");
                Debug.WriteLine(readText);
            }
        }

        private void OpcionesLote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estadisticas.Test();
        }

    }     
}