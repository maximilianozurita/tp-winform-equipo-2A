using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_winform_equipo_2A
{
    public partial class ListCategoria : Form
    {
        public ListCategoria()
        {
            InitializeComponent();
        }

        private void ListCategoria_Load(object sender, EventArgs e)
        {

        }

        private void AgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria addCat = new AgregarCategoria();
            addCat.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarCategoria modCat = new ModificarCategoria();
            modCat.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
