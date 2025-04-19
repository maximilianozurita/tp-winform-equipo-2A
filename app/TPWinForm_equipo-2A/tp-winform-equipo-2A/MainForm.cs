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
            detailForm.Product = new Product();
            detailForm.ShowDialog();
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            AddForm modifyForm = new AddForm();
            modifyForm.ShowDialog();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Product product = new Product();
            this.dataGridView.DataSource = product;

        }
    }
}
