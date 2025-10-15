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
    public partial class ListaArticulos : Form
    {
        public List<Articulos> listaArticulos;
        public ListaArticulos()
        {
            InitializeComponent();
        }

        private void ListaArticulos_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void tbxMarca_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvListaART.CurrentRow.DataBoundItem;

            frmModificar ventana = new frmModificar(seleccionado);
            ventana.ShowDialog();
            cargar();
        }


        public void cargar()
        {
             ArticulosNegocio articuloNegocio = new ArticulosNegocio();
            listaArticulos = articuloNegocio.listaART();
            dgvListaART.DataSource = listaArticulos;
            dgvListaART.Columns[5].Visible = false;
            dgvListaART.Columns[7].Visible = false;
            dgvListaART.Columns[8].Visible = false;
        }
        private void Filtrar()
        {
            List<Articulos> listaFiltrada;

            if (tbxDESCR.Text != "" && tbxNombre.Text == "")
            {
                listaFiltrada = listaArticulos.FindAll( descripcion => descripcion.DescripcionART.ToUpper().Contains(tbxDESCR.Text.ToUpper()));
            }
            else if (tbxDESCR.Text == "" && tbxNombre.Text != "")
            {
                listaFiltrada = listaArticulos.FindAll(id => id.Nombre.ToUpper().Contains(tbxNombre.Text.ToUpper()));
            }
            else if (tbxDESCR.Text != "" && tbxNombre.Text != "")
            {
                listaFiltrada = listaArticulos.FindAll(descripcion => descripcion.DescripcionART.ToUpper().Contains(tbxDESCR.Text.ToUpper()) && descripcion.Nombre.ToUpper().Contains(tbxNombre.Text.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvListaART.DataSource = null;
            dgvListaART.DataSource = listaFiltrada;
            dgvListaART.Columns[5].Visible = false;
            dgvListaART.Columns[7].Visible = false;
            dgvListaART.Columns[8].Visible = false;

        }

        private void btnAgregarART_Click(object sender, EventArgs e)
        {
            frmAgregar ventana = new frmAgregar();
            ventana.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public void Eliminar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar el artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    seleccionado = (Articulos)dgvListaART.CurrentRow.DataBoundItem;
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
