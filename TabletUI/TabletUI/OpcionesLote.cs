using BaseDatos.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabletUI
{
    public partial class OpcionesLote : Form
    {
        int codigo;
        LoteController lotController = new LoteController();
        public OpcionesLote(int codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
            GetLotes();
        }

        private void GetLotes()
        {
            foreach (var lote in lotController.GetAllLotes())
            {

                listBox1.Items.Add("Id: " + lote.Id + " Descripcion: " + lote.Descripcion + " ProductoId: " + lote.Productoid
                    + " Cant.Esperada: " + lote.Cantidadrequerida + " Cant.Obtenida de momento: " + lote.Cantidadobtenida);

            }
            /*
            "Id: " + listaLotes[i].Id +
                                " Descripcion: " + listaLotes[i].Descripcion +
                                " ProductoId: " + listaLotes[i].Productoid +
                                " Cant.Esperada: " + listaLotes[i].Cantidadrequerida +
                                " Cant.Obtenida de momento: " + listaLotes[i].Cantidadobtenida)
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codigo == 2)
            {
                var superWin = new OpcionesSupervisor(codigo, 0);
                superWin.Show();
            }
            else if (codigo == 3)
            {
                var superWin = new OpcionesTecnico(codigo, 0);
                superWin.Show();
            }

            this.Visible = false;
        }
    }
}
