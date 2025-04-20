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
                MessageBox.Show("el producto ha sido guardado");
            }
        }

        private void detailProductButton_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            detailForm.ShowDialog();
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow data = dataGridViewArticulo.CurrentRow;
            if (data != null) 
            {
                MessageBox.Show("No hay articulos seleccionados");
                return;
            }
            Articulo ArticuloSelected = (Articulo)data.DataBoundItem;
            AddForm modifyForm = new AddForm(ArticuloSelected);
            modifyForm.ShowDialog();
            Cargar();
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
            ArticuloNegocio ArtNegocio = new ArticuloNegocio();
            try
            {
                //Listado de categorias
                List<Categoria> listaCategorias = new List<Categoria>();
                listaCategorias = CatNegocio.Listar();
                listaCategorias.Insert(0, new Categoria { ID = 0, Descripcion = "Todas" }); //Valor por default para poder filtrar con y sin categoria/marca
                filtroCategoria.DataSource = listaCategorias;
                filtroCategoria.ValueMember = "ID";
                filtroCategoria.DisplayMember = "Descripcion";

                //Listado de marcas
                List<Marca> listaMarcas = new List<Marca>();
                listaMarcas = MarcaNegocio.Listar();
                listaMarcas.Insert(0, new Marca { ID = 0, Descripcion = "Todas" });
                filtroMarca.DataSource = listaMarcas;
                filtroMarca.ValueMember = "ID";
                filtroMarca.DisplayMember = "Descripcion";

                //Listado de articulos
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
            if(dataGridViewArticulo.CurrentRow != null)
            {
                Articulo ArticuloSeleccionado = (Articulo)dataGridViewArticulo.CurrentRow.DataBoundItem;
                string urlImagen = ArticuloSeleccionado.Imagenes != null && ArticuloSeleccionado.Imagenes.Count > 0 ? ArticuloSeleccionado.Imagenes[0].ImagenUrl : "";
                CargarImagen(urlImagen);
            }
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
            Buscar();
        }

        private void Buscar()
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

        private void filterButton_Click(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNegocio = new ArticuloNegocio();
            try
            {
                string categoria = (int)filtroCategoria.SelectedValue != 0 ? filtroCategoria.SelectedItem.ToString() : "";
                string marca = (int)filtroMarca.SelectedValue != 0 ? filtroMarca.SelectedItem.ToString() : "";
                ListArticulo = ArtNegocio.Filtrar(marca, categoria); //Para que el buscador filtre por el listado filtrado
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textFiltro.Text = "";
            Cargar();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewArticulo.CurrentRow != null)
                {
                    ArticuloNegocio ArtNegocio = new ArticuloNegocio();
                    Articulo ArtSeleccionado = (Articulo)dataGridViewArticulo.CurrentRow.DataBoundItem;
                    ArtNegocio.Eliminar(ArtSeleccionado);
                    MessageBox.Show("Eliminado exitosamente");
                    Cargar();
                }
                else
                {
                    MessageBox.Show("No hay articulo seleccionado para eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
