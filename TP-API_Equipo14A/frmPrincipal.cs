using dominio;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
/*
        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado ventana = new frmListado();
            ventana.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar ventana = new frmAgregar();
            ventana.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar ventana = new frmEliminar();
            ventana.ShowDialog();
        }

*/
        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado ventana = new frmListado();
            ventana.ShowDialog();
        }
        private void btnArticulos_Click(object sender, EventArgs e)
        {
            ListaArticulos ventana = new ListaArticulos();
            ventana.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            ListaMarca ventana = new ListaMarca ();
            ventana.ShowDialog();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            ListaCategorias ventana = new ListaCategorias();
            ventana.ShowDialog();
        }
    }
}
