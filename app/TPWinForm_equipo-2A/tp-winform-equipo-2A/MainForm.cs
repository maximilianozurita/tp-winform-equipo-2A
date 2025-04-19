using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using tp_winform_equipo_2A.Models;

namespace tp_winform_equipo_2A
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("el producto ha sido guardado");
            }
        }

        private void detailProductButton_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            detailForm.Product = new Product();
            detailForm.ShowDialog();
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            AddForm modifyForm = new AddForm();
            modifyForm.ShowDialog();
        }
        private void ListCategorias_Click(object sender, EventArgs e)
        {
            ListCategoria listCategoria = new ListCategoria();
            listCategoria.ShowDialog();
        }

        private void ListMarcas_Click(object sender, EventArgs e)
        {
            ListMarcas listMarca = new ListMarcas();
            listMarca.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CategoriaNegocio CatNegocio = new CategoriaNegocio();
            try
            {
                nameCategoria.DataSource = CatNegocio.Listar();
                nameCategoria.ValueMember = "ID";
                nameCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Listado de articulos
            ArticuloNegocio ArtNegocio = new ArticuloNegocio();
            try
            {
                List<Articulo> listArtNegocio = new List<Articulo>();
                listArtNegocio = ArtNegocio.Listar();
                dataGridViewArticulo.DataSource = listArtNegocio;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo ArticuloSeleccionado = (Articulo)dataGridViewArticulo.CurrentRow.DataBoundItem;
            string urlImagen = ArticuloSeleccionado.Imagenes != null && ArticuloSeleccionado.Imagenes.Count > 0 ? ArticuloSeleccionado.Imagenes[0].ImagenUrl : "";
            CargarImagen(urlImagen);
        }
        private void CargarImagen(string urlImagen)
        {
            try
            {
                pictureBoxArticulo.Load(urlImagen);
            }
            catch
            {
                pictureBoxArticulo.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
            }
        }

    }
}
