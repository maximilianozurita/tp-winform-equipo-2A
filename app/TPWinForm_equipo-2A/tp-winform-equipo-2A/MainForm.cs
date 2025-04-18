using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                dataGridViewArticulo.DataSource = ArtNegocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
