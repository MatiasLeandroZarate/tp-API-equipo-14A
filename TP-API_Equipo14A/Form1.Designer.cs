namespace TPWinForm_Equipo14A
{
    partial class frmListado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvART = new System.Windows.Forms.DataGridView();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvART
            // 
            this.dgvART.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvART.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvART.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvART.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvART.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvART.Location = new System.Drawing.Point(12, 71);
            this.dgvART.MultiSelect = false;
            this.dgvART.Name = "dgvART";
            this.dgvART.RowHeadersWidth = 51;
            this.dgvART.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvART.Size = new System.Drawing.Size(778, 211);
            this.dgvART.TabIndex = 3;
            this.dgvART.SelectionChanged += new System.EventHandler(this.dgvART_SelectionChanged);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagen.Location = new System.Drawing.Point(858, 71);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(237, 211);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 2;
            this.pbxImagen.TabStop = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(13, 20);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(72, 13);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Filtro Rápido: ";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(91, 45);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(164, 20);
            this.tbxNombre.TabIndex = 1;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre: ";
            // 
            // tbxMarca
            // 
            this.tbxMarca.Location = new System.Drawing.Point(358, 45);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(164, 20);
            this.tbxMarca.TabIndex = 2;
            this.tbxMarca.TextChanged += new System.EventHandler(this.tbxMarca_TextChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(309, 47);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 13);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca: ";
            // 
            // frmListado
            // 
            this.ClientSize = new System.Drawing.Size(1137, 387);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tbxMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.dgvART);
            this.MinimumSize = new System.Drawing.Size(1153, 426);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvART;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.Label lblMarca;
    }
}

