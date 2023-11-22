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
    public partial class CrearLote : Form
    {
        LotePorLineaController lotControllerLinea = new LotePorLineaController();
        LoteController lotController = new LoteController();
        int linea;

        // Constructor que crea interfaz y guarda valor de linea
        public CrearLote(int linea)
        {
            InitializeComponent();
            this.linea = linea;
        }

        // Boton que crea lote y cierra ventana al ingresar los datos
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(idText.Text) || !String.IsNullOrEmpty(descText.Text) || !String.IsNullOrEmpty(productidText.Text)
                || !String.IsNullOrEmpty(cantidadText.Text))
            {
                lotController.AddLote(idText.Text, descText.Text, int.Parse(productidText.Text),
                    int.Parse(cantidadText.Text), 1);
                lotControllerLinea.AddLotePorLinea(idText.Text, linea, new DateOnly(DateTime.Now.Year,
                    DateTime.Now.Month, DateTime.Now.Day), new TimeOnly(9, 0),
                    new TimeOnly(0, 0));
                Close();
            }
        }
    }
}   