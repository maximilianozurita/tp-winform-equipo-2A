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
            InitValidationElement();
        }
        public AddForm(Articulo articuloObj)
        {
            InitializeComponent();
            InitValidationElement();
            this.articuloObj = articuloObj;
        }
        private void InitValidationElement()
        {
            this.categoryValidationLabel.Text = "";
            this.brandValidationLabel.Text = "";
            this.codeValidationLabel.Text = "";
            this.nameValidationLabel.Text = "";
            this.priceValidationLabel.Text = "";
            this.descripcionValidationLabel.Text = "";
            this.ListImageValidation.Text = "";
            this.priceTextBox.KeyPress += new KeyPressEventHandler(priceTextBox_keyPress);
<<<<<<< HEAD
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            this.brandComboBox.DataSource = marcaNegocio.Listar();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            this.categoryComboBox.DataSource = categoriaNegocio.Listar();


=======
>>>>>>> bbb0314d4b910aa0a0a0394ec048b396a50d8ab6
        }
        private void priceTextBox_keyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                this.priceValidationLabel.Text = "";
            }
            else
            {
                e.Handled = true;
                this.priceValidationLabel.Text = "Solo se acepta Numeros";
            }

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
            if (priceTextBox.Text == "" || priceTextBox.Text == "0")
            {
                priceValidationLabel.Text = "Requerido";
                isValid = false;
            }
            if (descriptionTextBox.Text == "")
            {
                descripcionValidationLabel.Text = "Requerido";
                isValid = false;
            }
            if (listaImagenes.Items.Count == 0)
            {
                ListImageValidation.Text = "Al menos 1 imagen";
                isValid = false;
            }
            return isValid;
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                InitValidationElement();
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
            if (!ValidarUrlImagen(url)) return;

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

        private bool ValidarUrlImagen(string url)
        {

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Agregue una url.");
                return false;
            }
            try
            {
                ImagePictureBox.Load(url);
                return true;
            }
            catch
            {
                MessageBox.Show("Url invalida.");
                return false;
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
