using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo14A
{
    public partial class frmModificarMarca : Form
    {
        private Marca marca;

        public frmModificarMarca()
        {
            InitializeComponent();
        }

        public frmModificarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            try
            {
                if (marca != null)
                {
                    txtDescMarca.Text = marca.DescripcionMarca;

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
            MarcaNegocio negocio = new MarcaNegocio();

            string mensajeError;
            if(!frmAgregarMarca.ValidarMarca(txtDescMarca.Text, out mensajeError))
            {
                MessageBox.Show(mensajeError);
                return;
            }
            try
            {
                marca.DescripcionMarca = txtDescMarca.Text;

                negocio.Modificar(marca);
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
