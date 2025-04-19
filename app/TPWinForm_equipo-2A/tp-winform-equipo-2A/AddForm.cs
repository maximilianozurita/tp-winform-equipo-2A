using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_winform_equipo_2A.Models;

namespace tp_winform_equipo_2A
{
    public partial class AddForm : Form
    {
        public Product Product { get; private set; }
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
                this.Product = new Product();
                this.Product.Name = this.nameTextBox.Text;
                this.Product.Code = this.codeTextBox.Text;
                this.Product.Description = this.descriptionTextBox.Text;
                this.Product.Category = this.categoryComboBox.Text;
                this.Product.Image = this.imageTextBox.Text;
                this.Product.Price = System.Convert.ToDouble( this.priceTextBox.Text);
                this.Product.Brand = this.brandComboBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            
        }

        

        
    }
}
