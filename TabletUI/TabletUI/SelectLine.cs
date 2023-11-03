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
    public partial class SelectLine : Form
    {
        int codigo;
        public SelectLine(int codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        private void SelectLine_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {      
            var registroWin = new RegistradoEmp(codigo);
            registroWin.Show();   
            this.Visible = false;
            
        }
    }
}
