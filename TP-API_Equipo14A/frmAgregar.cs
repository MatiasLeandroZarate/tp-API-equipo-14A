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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulos nuevo = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();

            string mensajeError;
            if (!ValidarArticulo(txtCodArt.Text, txtNombreArt.Text, txtDescArt.Text, txtPrecio.Text, out mensajeError))
            {
                MessageBox.Show(mensajeError);
                return;
            }
            try
            {
                nuevo.CodigoArticulo = txtCodArt.Text;
                nuevo.Nombre = txtNombreArt.Text;
                nuevo.Marca.ID = (int)cboMarca.SelectedValue;
                nuevo.Categoria.ID = (int)cboCategoria.SelectedValue;
                nuevo.UrlImagen = txtURLImagen.Text;
                nuevo.DescripcionART = txtDescArt.Text;
                if (string.IsNullOrWhiteSpace(txtPrecio.Text))
                    nuevo.Precio = 0;
                else
                    nuevo.Precio = decimal.Parse(txtPrecio.Text);

                negocio.Agregar(nuevo);
                MessageBox.Show("Agregado Exitosamente");
                Close();

            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
            }
        }
        public static bool ValidarArticulo(string codigo, string nombre, string descripcion, string precio, out string mensajeError)
        {
            mensajeError = "";

        //El Isnullorwhitespace chequea si el valor ingresado es null o tiene solo espacios
        //Isletterordigit chequea num y letras.
            if (!string.IsNullOrWhiteSpace(codigo))
            {
                if (codigo.Length != 3)
                {
                    mensajeError = "El código de artículo debe tener exactamente 3 caracteres si se ingresa.";
                    return false;
                }
                foreach (char c in codigo)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        mensajeError = "El código de artículo solo admite letras y números (sin caracteres especiales).";
                        return false;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(nombre) && nombre.Length > 50)
            {
                mensajeError = "El nombre debe tener hasta 50 caracteres.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(descripcion) && descripcion.Length > 150)
            {
                mensajeError = "La descripción debe tener hasta 150 caracteres.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(precio) && (!decimal.TryParse(precio, out decimal p) || p < 0))
            {
                mensajeError = "El precio debe ser un número positivo";
                return false;
            }

            return true;
        }
    }
}
