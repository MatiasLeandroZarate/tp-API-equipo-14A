using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo14A
{
    public partial class ListaMarca : Form
    {
        public List<Marca> listaMarca;
        public ListaMarca()
        {
            InitializeComponent();
        }

        private void ListaMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void tbxDesc_TextChanged(object sender, EventArgs e)
        {
            filtra();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvListaMarca.CurrentRow.DataBoundItem;

            frmModificarMarca ventana = new frmModificarMarca(seleccionado);
            ventana.ShowDialog();
            cargar();
        }

        public void cargar()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            listaMarca = marcaNegocio.listar();

            dgvListaMarca.DataSource = listaMarca;
        }
        public void filtra()
        {
            List<Marca> listaFiltrada;

            if(tbxDesc.Text != "")
            {
                listaFiltrada = listaMarca.FindAll(descripcion => descripcion.DescripcionMarca.ToUpper().Contains(tbxDesc.Text.ToUpper()));
            }
            else
            {
                listaFiltrada = listaMarca;
            }

            dgvListaMarca.DataSource = null;
            dgvListaMarca.DataSource = listaFiltrada;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca ventana = new frmAgregarMarca();
            ventana.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public void Eliminar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar la marca?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    seleccionado = (Marca)dgvListaMarca.CurrentRow.DataBoundItem;
                    negocio.EliminarDB(seleccionado.ID);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
