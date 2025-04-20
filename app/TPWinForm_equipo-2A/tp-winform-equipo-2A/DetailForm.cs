using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_winform_equipo_2A
{
    public partial class DetailForm : Form
    {
        private Articulo _articulo;
        private string _url;
        public DetailForm(Articulo articuloObj, string imageUrl)
        {
            this._articulo = articuloObj;
            this._url = imageUrl;
            InitializeComponent();
            ChargeForm();
        }

        private void ChargeForm()
        {
            this.codeTextBox.Text = this._articulo.Codigo;
            this.nameTextBox.Text = this._articulo.Nombre;
            this.descriptionTextBox.Text = this._articulo.Descripcion;
            this.brandTextBox.Text = this._articulo.Marca.Descripcion;
            this.categoryTextBox.Text = this._articulo.Categoria.Descripcion;
            this.priceTextBox.Text = this._articulo.Precio.ToString();
            try
            {
                this.ImagePictureBox.Load(this._url);
            }
            catch
            {
                this.ImagePictureBox.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
