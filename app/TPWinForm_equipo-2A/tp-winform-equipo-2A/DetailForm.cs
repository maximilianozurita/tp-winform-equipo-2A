using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace tp_winform_equipo_2A
{
    public partial class DetailForm : Form
    {
        private Articulo articuloObj = null;
        public DetailForm(Articulo ArticuloSelected)
        {
            InitializeComponent();
            this.articuloObj = ArticuloSelected;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            //Cargar datos del objeto
        }
    }
}
