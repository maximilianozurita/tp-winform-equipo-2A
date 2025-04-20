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
                Console.WriteLine("el item es: "+item);
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
                if (IsValid())
                {
                    ArticuloSimple articuloSimple = new ArticuloSimple();
                    articuloSimple.Name = this.nameTextBox.Text;
                    articuloSimple.Code = this.codeTextBox.Text;
                    articuloSimple.Description = this.descriptionTextBox.Text;
                    articuloSimple.Category = ((Categoria)this.categoryComboBox.SelectedItem).ID;
                    articuloSimple.ImageUrl = this.imageTextBox.Text;
                    articuloSimple.Price = Convert.ToDouble(this.priceTextBox.Text);
                    articuloSimple.Brand = ((Marca)this.brandComboBox.SelectedItem).ID;
                    GuardadoArticuloNegocio guardadoArticuloNegocio = new GuardadoArticuloNegocio();
                    guardadoArticuloNegocio.ArticuloSimple = articuloSimple;
                    guardadoArticuloNegocio.Guardar();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                if (articuloObj.ID != 0)
                {
                    articuloNegocio.Modificar(articuloObj);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    articuloNegocio.Agregar(articuloObj);
                    MessageBox.Show("Agregado exitosamente");
                }
                Close();
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
                    nameTextBox.Text = articuloObj.Descripcion;
                    codeTextBox.Text = articuloObj.Codigo;
                    descriptionTextBox.Text = articuloObj.Descripcion;
                    priceTextBox.Text = articuloObj.Precio.ToString();
                    brandComboBox.SelectedValue = articuloObj.Marca.ID;
                    categoryComboBox.SelectedValue = articuloObj.Categoria.ID;
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
    }
}
