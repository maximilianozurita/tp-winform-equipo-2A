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
using negocio;

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

        private void AgregarMarca_Load(object sender, EventArgs e)
        {
            if (MarcaObj != null)
            {
                nombreMarca.Text = MarcaObj.Descripcion;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            try
            {
                if (MarcaObj == null)
                {
                    MarcaObj = new Marca();
                }
                if (string.IsNullOrWhiteSpace(nombreMarca.Text))
                {
                    MessageBox.Show("Descripcion vacia");
                    return;
                }
                MarcaObj.Descripcion = nombreMarca.Text;
                if (MarcaObj.ID != 0)
                {
                    MarcaNegocio.Modificar(MarcaObj);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    MarcaNegocio.Agregar(MarcaObj);
                    MessageBox.Show("Agregado exitosamente");
                }
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
