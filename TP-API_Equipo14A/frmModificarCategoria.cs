using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo14A
{
    public partial class frmModificarCategoria : Form
    {
        private Categoria categoria;
        public frmModificarCategoria()
        {
            InitializeComponent();
        }
    
        public frmModificarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            string mensajeError;
            if (!frmAgregarCategoria.ValidarCategoria(txtDesc.Text, out mensajeError))
            {
                MessageBox.Show(mensajeError);
                return;
            }
            try
            {
                categoria.DescripcionCategoria = txtDesc.Text;

                negocio.Modificar(categoria);
                MessageBox.Show("Modificado Exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmModificarCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (categoria != null)
                {
                    txtDesc.Text = categoria.DescripcionCategoria;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
