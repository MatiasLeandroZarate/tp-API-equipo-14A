namespace TPWinForm_Equipo14A
{
    partial class ListaArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaART = new System.Windows.Forms.DataGridView();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tbxDESCR = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarART = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaART)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaART
            // 
            this.dgvListaART.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaART.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvListaART.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvListaART.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaART.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaART.Location = new System.Drawing.Point(25, 65);
            this.dgvListaART.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaART.MultiSelect = false;
            this.dgvListaART.Name = "dgvListaART";
            this.dgvListaART.RowHeadersWidth = 51;
            this.dgvListaART.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaART.Size = new System.Drawing.Size(677, 193);
            this.dgvListaART.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(284, 44);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Descripcion:  ";
            // 
            // tbxDESCR
            // 
            this.tbxDESCR.Location = new System.Drawing.Point(355, 41);
            this.tbxDESCR.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDESCR.Name = "tbxDESCR";
            this.tbxDESCR.Size = new System.Drawing.Size(124, 20);
            this.tbxDESCR.TabIndex = 2;
            this.tbxDESCR.TextChanged += new System.EventHandler(this.tbxMarca_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(79, 44);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre: ";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(130, 42);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(124, 20);
            this.tbxNombre.TabIndex = 1;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(22, 21);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(72, 13);
            this.lblFiltro.TabIndex = 10;
            this.lblFiltro.Text = "Filtro Rápido: ";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Location = new System.Drawing.Point(312, 271);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 24);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Artículo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(518, 271);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 24);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar DB";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarART
            // 
            this.btnAgregarART.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarART.Location = new System.Drawing.Point(123, 271);
            this.btnAgregarART.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarART.Name = "btnAgregarART";
            this.btnAgregarART.Size = new System.Drawing.Size(88, 24);
            this.btnAgregarART.TabIndex = 4;
            this.btnAgregarART.Text = "Agregar Artículo";
            this.btnAgregarART.UseVisualStyleBackColor = true;
            this.btnAgregarART.Click += new System.EventHandler(this.btnAgregarART_Click);
            // 
            // ListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 306);
            this.Controls.Add(this.btnAgregarART);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tbxDESCR);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgvListaART);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(777, 345);
            this.Name = "ListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Articulos";
            this.Load += new System.EventHandler(this.ListaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaART)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaART;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox tbxDESCR;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarART;
    }
}