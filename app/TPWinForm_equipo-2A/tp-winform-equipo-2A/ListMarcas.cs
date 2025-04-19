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
    public partial class ListMarcas : Form
    {
        public ListMarcas()
        {
            InitializeComponent();
        }

        private void ListMarcas_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            try
            {
                dataGridViewMarca.DataSource = MarcaNegocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AgregarMarcas_Click(object sender, EventArgs e)
        {
            AgregarMarca addMarca = new AgregarMarca();
            addMarca.ShowDialog();
            Cargar();
        }

        private void ModificarMarcas_Click(object sender, EventArgs e)
        {

            Marca marcaSelected = (Marca)dataGridViewMarca.CurrentRow.DataBoundItem;
            AgregarMarca modMarca = new AgregarMarca(marcaSelected);
            modMarca.ShowDialog();
            Cargar();
        }

        private void EliminarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio MarcaNegocio = new MarcaNegocio();
                Marca MarcaSelected = (Marca)dataGridViewMarca.CurrentRow.DataBoundItem;
                MarcaNegocio.Eliminar(MarcaSelected);
                MessageBox.Show("Eliminado exitosamente");
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
