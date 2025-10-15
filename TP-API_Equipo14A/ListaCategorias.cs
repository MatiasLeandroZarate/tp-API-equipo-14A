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
    public partial class ListaCategorias : Form
    {
        public List<Categoria> listaCategoria;
        public ListaCategorias()
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
            Categoria seleccionado;
            seleccionado = (Categoria)dgvListaCategorias.CurrentRow.DataBoundItem;

            frmModificarCategoria ventana = new frmModificarCategoria(seleccionado);
            ventana.ShowDialog();
            cargar();
        }

        public void cargar()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            listaCategoria = categoriaNegocio.listar();

            dgvListaCategorias.DataSource = listaCategoria;
        }

        public void filtra()
        {
            List<Categoria> listaFiltrada;

            if (tbxDesc.Text != "")
            {
                listaFiltrada = listaCategoria.FindAll(descripcion => descripcion.DescripcionCategoria.ToUpper().Contains(tbxDesc.Text.ToUpper()));
            }
            else
            {
                listaFiltrada = listaCategoria;
            }

            dgvListaCategorias.DataSource = null;
            dgvListaCategorias.DataSource = listaFiltrada;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria ventana = new frmAgregarCategoria();
            ventana.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public void Eliminar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar la categoría?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    seleccionado = (Categoria)dgvListaCategorias.CurrentRow.DataBoundItem;
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
