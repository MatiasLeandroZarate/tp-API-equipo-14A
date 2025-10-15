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
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria nuevo = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            string mensajeError;
            if (!ValidarCategoria(txtDesc.Text, out mensajeError))
            {
                MessageBox.Show(mensajeError);
                return;
            }
            try
            {
                nuevo.DescripcionCategoria = txtDesc.Text;
                negocio.Agregar(nuevo);
                MessageBox.Show("Agregado Exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool ValidarCategoria(string descripcion, out string mensajeError)
        {
            mensajeError = "";

            if (!string.IsNullOrWhiteSpace(descripcion) && descripcion.Length > 50)
            {
                mensajeError = "La descripción debe tener hasta 50 caracteres.";
                return false;
            }

            return true;
        }
    }
}
