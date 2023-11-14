using BaseDatos.Controllers;
using BaseDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                Debug.WriteLine("Existo");
                /*
                Lote loteEspecifico = lotController.GetLoteById(lote.Loteid);
                //if (lote.Lineaid == linea)
               // {
                    listBox1.Items.Add("Id: " + loteEspecifico.Id + " Descripcion: " + loteEspecifico.Descripcion + 
                        " ProductoId: " + loteEspecifico.Productoid + " Cant.Esperada: " + loteEspecifico.Cantidadrequerida + 
                        " Cant.Obtenida de momento: " + loteEspecifico.Cantidadobtenida);
               // }
                */
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
