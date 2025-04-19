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
    public partial class AgregarMarca : Form
    {
        private Marca MarcaObj = null;
        public AgregarMarca()
        {
            InitializeComponent();
        }
        public AgregarMarca(Marca MarcaObj)
        {
            InitializeComponent();
            this.MarcaObj = MarcaObj;
        }

    }
}
