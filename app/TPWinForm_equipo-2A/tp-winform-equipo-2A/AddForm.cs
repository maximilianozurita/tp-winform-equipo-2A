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

        private void priceTextBox_keyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            this.priceValidationLabel.Text = 
                e.Handled ? "Solo se acepta Numeros " : "";

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente");
        }


        

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if(this.codeTextBox.Text == "")
            {
                this.codeValidationLabel.Text = "Requerido";
                isValid = false;
            }
            if(this.nameTextBox.Text == "")
            {
                this.nameValidationLabel.Text = "Requerido";
                isValid = false;
            }
            if(this.brandComboBox.Text == "")
            {
                this.brandValidationLabel.Text = "Requerido";
                isValid = false;
            }
            if(this.brandComboBox.Text == "") 
            {
                this.categoryValidationLabel.Text = "Requerido";
                isValid = false;
            }
            if(this.priceTextBox.Text == "")
            {
                this.priceTextBox.Text = "0";
            }
            if (isValid)
            {
                ArticuloSimple articuloSimple = new ArticuloSimple();
                articuloSimple.Name = this.nameTextBox.Text;
                articuloSimple.Code = this.codeTextBox.Text;
                articuloSimple.Description = this.descriptionTextBox.Text;
                articuloSimple.Category = ((Categoria)this.categoryComboBox.SelectedItem).ID;
                articuloSimple.ImageUrl = this.imageTextBox.Text;
                articuloSimple.Price = Convert.ToDouble( this.priceTextBox.Text);
                articuloSimple.Brand = ((Marca)this.brandComboBox.SelectedItem).ID;
                GuardadoArticuloNegocio guardadoArticuloNegocio = new GuardadoArticuloNegocio();
                guardadoArticuloNegocio.ArticuloSimple = articuloSimple;
                guardadoArticuloNegocio.Guardar();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                brandComboBox.DataSource = marcaNegocio.Listar();
                brandComboBox.ValueMember = "ID";
                brandComboBox.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
