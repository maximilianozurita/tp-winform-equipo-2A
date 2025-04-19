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
    public partial class AgregarCategoria : Form
    {
        private Categoria CategoriaOBj = null;
        public AgregarCategoria()
        {
            InitializeComponent();
        }
        public AgregarCategoria(Categoria CatModificar)
        {
            InitializeComponent();
            this.CategoriaOBj = CatModificar;
        }
        private void AgregarCategoria_Load(object sender, EventArgs e)
        {
            if (CategoriaOBj != null)
            {
                nombreCategoria.Text = CategoriaOBj.Descripcion;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            CategoriaNegocio CatNegocio = new CategoriaNegocio();
            try
            {
                if (CategoriaOBj == null)
                {
                    CategoriaOBj = new Categoria();
                }
                CategoriaOBj.Descripcion = nombreCategoria.Text;
                if (CategoriaOBj.ID != 0)
                {
                    CatNegocio.Modificar(CategoriaOBj);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    CatNegocio.Agregar(CategoriaOBj);
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
