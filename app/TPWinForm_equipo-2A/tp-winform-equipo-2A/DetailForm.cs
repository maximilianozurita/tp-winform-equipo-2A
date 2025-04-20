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
using dominio;

namespace tp_winform_equipo_2A
{
    public partial class DetailForm : Form
    {
        private Articulo _articulo;
        private string _url;
        public DetailForm(Articulo articuloObj)
        {
            this._articulo = articuloObj;
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

            foreach (Imagen img in _articulo.Imagenes)
            {
                if (!listImagenes.Items.Contains(img.ImagenUrl))
                {
                    listImagenes.Items.Add(img.ImagenUrl);
                }
            }
            string urlImagen = _articulo.Imagenes != null && _articulo.Imagenes.Count > 0 ? _articulo.Imagenes[0].ImagenUrl : "";
            CargarImagen(urlImagen);
        }
        private void listImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listImagenes.SelectedItem != null)
            {
                CargarImagen(listImagenes.SelectedItem.ToString());
            }
        }
        private void CargarImagen(string url)
        {
            try
            {
                this.ImagePictureBox.Load(url);
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
