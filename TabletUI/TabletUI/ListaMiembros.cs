namespace TabletUI
{
    public partial class ListaMiembros : Form
    {
        // TODO: Condicional para verificar si el que accesa el código es técnico o supervisor
        public ListaMiembros()
        {
            InitializeComponent();
        }

        private void UpdateListBoxItem(ListBox lb, object item)
        {
            int index = lb.Items.IndexOf(item);
            int currIndex = lb.SelectedIndex;
            lb.BeginUpdate();
            try
            {
                lb.ClearSelected();
                lb.Items[index] = item;
                lb.SelectedIndex = currIndex;
            }
            finally
            {
                lb.EndUpdate();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.SelectedItem = "Técnico actual";
        }

        private void GestionarTecnico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
