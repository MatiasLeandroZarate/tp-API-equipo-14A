namespace TPWinForm_Equipo14A
{
    partial class ListaMarca
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
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dgvListaMarca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarMarca.Location = new System.Drawing.Point(123, 271);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(88, 24);
            this.btnAgregarMarca.TabIndex = 2;
            this.btnAgregarMarca.Text = "Agregar Artículo";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(518, 271);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 24);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar DB";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Location = new System.Drawing.Point(312, 271);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 24);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Artículo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(79, 44);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 13);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Descripción: ";
            // 
            // tbxDesc
            // 
            this.tbxDesc.Location = new System.Drawing.Point(152, 41);
            this.tbxDesc.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(200, 20);
            this.tbxDesc.TabIndex = 0;
            this.tbxDesc.TextChanged += new System.EventHandler(this.tbxDesc_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(22, 21);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(72, 13);
            this.lblFiltro.TabIndex = 19;
            this.lblFiltro.Text = "Filtro Rápido: ";
            // 
            // dgvListaMarca
            // 
            this.dgvListaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvListaMarca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvListaMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaMarca.Location = new System.Drawing.Point(25, 65);
            this.dgvListaMarca.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaMarca.MultiSelect = false;
            this.dgvListaMarca.Name = "dgvListaMarca";
            this.dgvListaMarca.RowHeadersWidth = 51;
            this.dgvListaMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaMarca.Size = new System.Drawing.Size(677, 193);
            this.dgvListaMarca.TabIndex = 1;
            // 
            // ListaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 306);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgvListaMarca);
            this.MinimumSize = new System.Drawing.Size(777, 345);
            this.Name = "ListaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Marca";
            this.Load += new System.EventHandler(this.ListaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.DataGridView dgvListaMarca;
    }
}