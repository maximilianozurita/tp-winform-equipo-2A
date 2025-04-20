using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace tp_winform_equipo_2A
{
    public partial class AddForm : Form
    {
        private Articulo articuloObj = null;
        public AddForm()
        {
            InitializeComponent();
            this.categoryValidationLabel.Text = "";
            this.brandValidationLabel.Text = "";
            this.codeValidationLabel.Text = "";
            this.nameValidationLabel.Text = "";
            this.priceValidationLabel.Text = "";
            this.priceTextBox.Text = "0";
            this.priceTextBox.KeyPress += new KeyPressEventHandler(priceTextBox_keyPress);
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            this.brandComboBox.DataSource = marcaNegocio.Listar();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            this.categoryComboBox.DataSource = categoriaNegocio.Listar();
            Console.WriteLine("aqui empieza la cosa");
            foreach (var item in categoriaNegocio.Listar())
            {
                Console.WriteLine("el item es: " + item);
            }
            foreach (var item in this.categoryComboBox.Items)
            {
                Console.WriteLine("el item es: " + item);
            }


        }
        public AddForm(Articulo articuloObj)
        {
            InitializeComponent();
            this.articuloObj = articuloObj;
        }

        private void priceTextBox_keyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            this.priceValidationLabel.Text =
                e.Handled ? "Solo se acepta Numeros " : "";

        }

        private bool IsValid()
        {
            bool isValid = true;
            if (codeTextBox.Text == "")
            {
                codeValidationLabel.Text = "Requerido";
                isValid = false;
            }
            if (nameTextBox.Text == "")
            {
                nameValidationLabel.Text = "Requerido";
                isValid = false;
            }
            if (brandComboBox.Text == "")
            {
                brandValidationLabel.Text = "Requerido";
                isValid = false;
            }
            if (brandComboBox.Text == "")
            {
                categoryValidationLabel.Text = "Requerido";
                isValid = false;
            }
            if (priceTextBox.Text == "")
            {
                priceTextBox.Text = "0";
            }
            return isValid;
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                if (articuloObj == null)
                {
                    articuloObj = new Articulo();
                }
                bool isModf = articuloObj.ID != 0;
                if (IsValid())
                {
                    articuloObj.Nombre = nameTextBox.Text;
                    articuloObj.Codigo = codeTextBox.Text;
                    articuloObj.Descripcion = descriptionTextBox.Text;
                    articuloObj.Precio = (float)decimal.Parse(priceTextBox.Text);
                    
                    articuloObj.Categoria = (Categoria)categoryComboBox.SelectedItem; ;
                    articuloObj.Marca = (Marca)brandComboBox.SelectedItem;

                    List<Imagen> imagenes = new List<Imagen>();
                    foreach (string url in listaImagenes.Items)
                    {
                        Imagen imagen = new Imagen
                        {
                            ImagenUrl = url
                        };
                        imagenes.Add(imagen);
                    }
                    articuloObj.Imagenes = imagenes;
                    if (isModf)
                    {
                        articuloNegocio.Modificar(articuloObj);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        articuloNegocio.Agregar(articuloObj);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 
        private void AddForm_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio catNegocio= new CategoriaNegocio();
            try
            {
                categoryComboBox.DataSource = catNegocio.Listar();
                categoryComboBox.ValueMember = "ID";
                categoryComboBox.DisplayMember = "Descripcion";

                brandComboBox.DataSource = marcaNegocio.Listar();
                brandComboBox.ValueMember = "ID";
                brandComboBox.DisplayMember = "Descripcion";


                if (articuloObj != null)
                {
                    nameTextBox.Text = articuloObj.Nombre;
                    codeTextBox.Text = articuloObj.Codigo;
                    descriptionTextBox.Text = articuloObj.Descripcion;
                    priceTextBox.Text = articuloObj.Precio.ToString();
                    if (articuloObj.Marca != null) brandComboBox.SelectedValue = articuloObj.Marca.ID;
                    if (articuloObj.Categoria != null)  categoryComboBox.SelectedValue = articuloObj.Categoria.ID;

                    foreach (Imagen img in articuloObj.Imagenes)
                    {
                        if (!listaImagenes.Items.Contains(img.ImagenUrl))
                        {
                            listaImagenes.Items.Add(img.ImagenUrl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarImagen_Click(object sender, EventArgs e)
        {
            string url = imageTextBox.Text;
            if (string.IsNullOrEmpty(url)) return;

            if (!listaImagenes.Items.Contains(url))
            {
                listaImagenes.Items.Add(url);
                imageTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Esta URL ya fue agregada.");
            }
        }

        private void borrarImagen_Click(object sender, EventArgs e)
        {
            if (listaImagenes.SelectedItem != null)
            {
                listaImagenes.Items.Remove(listaImagenes.SelectedItem);
            }
        }

        private void CargarImagen(string urlImagen)
        {
            try
            {
                ImagePictureBox.Load(urlImagen);
            }
            catch
            {
                ImagePictureBox.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
            }
        }

        private void listaImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaImagenes.SelectedItem != null)
            {
                CargarImagen(listaImagenes.SelectedItem.ToString());
            }
        }
    }
}
