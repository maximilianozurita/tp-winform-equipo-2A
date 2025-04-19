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
    public partial class ListCategoria : Form
    {
        public ListCategoria()
        {
            InitializeComponent();
        }

        private void ListCategoria_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            CategoriaNegocio CatNegocio = new CategoriaNegocio();
            try
            {
                dataGridViewCategoria.DataSource = CatNegocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria addCat = new AgregarCategoria();
            addCat.ShowDialog();
            Cargar();
        }

        private void ModificarCategoria_Click(object sender, EventArgs e)
        {
            Categoria catSelected = (Categoria)dataGridViewCategoria.CurrentRow.DataBoundItem;
            AgregarCategoria modCat = new AgregarCategoria(catSelected);
            modCat.ShowDialog();
            Cargar();
        }

        private void EliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio CatNegocio = new CategoriaNegocio();
                Categoria CatSeleccionada = (Categoria)dataGridViewCategoria.CurrentRow.DataBoundItem;

                CatNegocio.eliminar(CatSeleccionada);
                MessageBox.Show("Eliminado exitosamente");
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
