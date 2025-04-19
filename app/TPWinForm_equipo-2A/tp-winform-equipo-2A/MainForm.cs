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
using tp_winform_equipo_2A.Models;

namespace tp_winform_equipo_2A
{
    public partial class MainForm : Form
    {
        private List<Articulo> ListArticulo;
        public MainForm()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                //aqui se guarda en la base de datos a travez de un servicio
                //por ejemplo Database.Save(addForm.Product);
                MessageBox.Show("el producto "+ addForm.Product.Name +" ha sido guardado");
            }
        }

        private void detailProductButton_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
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
            Cargar();
        }

        private void ListMarcas_Click(object sender, EventArgs e)
        {
            ListMarcas listMarca = new ListMarcas();
            listMarca.ShowDialog();
            Cargar();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            CategoriaNegocio CatNegocio = new CategoriaNegocio();
            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            try
            {
                //Listado de categorias
                nameCategoria.DataSource = CatNegocio.Listar();
                nameCategoria.ValueMember = "ID";
                nameCategoria.DisplayMember = "Descripcion";

                //Listado de marcas
                nameMarca.DataSource = MarcaNegocio.Listar();
                nameMarca.ValueMember = "ID";
                nameMarca.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Listado de articulos
            ArticuloNegocio ArtNegocio = new ArticuloNegocio();
            try
            {
                ListArticulo = ArtNegocio.Listar();
                dataGridViewArticulo.DataSource = ListArticulo;
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

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> articulosFiltrados = new List<Articulo>();
            string filtro = textFiltro.Text.ToUpper();
            if (filtro != "")
            {
                articulosFiltrados = ListArticulo.FindAll(x => 
                    x.Nombre.ToUpper().Contains(filtro) || 
                    x.Descripcion.ToUpper().Contains(filtro) ||
                    x.Codigo.ToUpper().Contains(filtro)
                );
            }
            else
            {
                articulosFiltrados = ListArticulo;
            }
            dataGridViewArticulo.DataSource = null;
            dataGridViewArticulo.DataSource = articulosFiltrados;
        }
    }
}
