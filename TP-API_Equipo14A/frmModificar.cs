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


namespace TPWinForm_Equipo14A
{
    public partial class frmModificar : Form
    {
        private Articulos articulo;

        public frmModificar()
        {
            InitializeComponent();
        }
        public frmModificar(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "ID";
                cboMarca.DisplayMember = "DescripcionMarca";

                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "ID";
                cboCategoria.DisplayMember = "DescripcionCategoria";

                if (articulo != null)
                {
                    //Hacer las validaciones

                    txtCodArt.Text = articulo.CodigoArticulo;
                    txtNombreArt.Text = articulo.Nombre;
                    txtURLImagen.Text = articulo.UrlImagen;
                    txtDescArt.Text = articulo.DescripcionART;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboMarca.SelectedValue = articulo.IDMarca; //Trae la Marca en la lista
                    //cboMarca.SelectedValue = articulo.Marca.ID;
                    cboCategoria.SelectedValue = articulo.IDCategoria;
                    //cboCategoria.SelectedValue = articulo.Categoria.ID;

                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            
        string mensajeError;
        if (!frmAgregar.ValidarArticulo(txtCodArt.Text, txtNombreArt.Text, txtDescArt.Text, txtPrecio.Text, out mensajeError))
        {
            MessageBox.Show(mensajeError);
            return;
        }
            try
            { 
                articulo.CodigoArticulo = txtCodArt.Text;
                articulo.Nombre = txtNombreArt.Text;

                if (articulo.Marca == null)
                    articulo.Marca = new Marca();
                if (articulo.Categoria == null)
                    articulo.Categoria = new Categoria();

                articulo.Marca.ID = (int)cboMarca.SelectedValue;
                articulo.Categoria.ID = (int)cboCategoria.SelectedValue;

                articulo.UrlImagen = txtURLImagen.Text;
                articulo.DescripcionART = txtDescArt.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                negocio.Modificar(articulo);
                MessageBox.Show("Modificado Exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
