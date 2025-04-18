﻿using System;
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
    public partial class ListMarcas : Form
    {
        public ListMarcas()
        {
            InitializeComponent();
        }

        private void AgregarMarcas_Click(object sender, EventArgs e)
        {
            AgregarMarca addMarca = new AgregarMarca();
            addMarca.ShowDialog();
        }

        private void ModificarMarcas_Click(object sender, EventArgs e)
        {

            Marca marcaSelected = (Marca)dataGridViewMarca.CurrentRow.DataBoundItem;
            AgregarMarca modMarca = new AgregarMarca(marcaSelected);
            modMarca.ShowDialog();
        }

        private void EliminarMarca_Click(object sender, EventArgs e)
        {

        }
    }
}
