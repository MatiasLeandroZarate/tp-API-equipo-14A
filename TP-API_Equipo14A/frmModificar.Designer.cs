namespace TPWinForm_Equipo14A
{
    partial class frmModificar
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
            this.lblNombreArt = new System.Windows.Forms.Label();
            this.txtNombreArt = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURLImagen = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescArt = new System.Windows.Forms.Label();
            this.txtDescArt = new System.Windows.Forms.TextBox();
            this.lblCodigoArt = new System.Windows.Forms.Label();
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.lblTítuloModificar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreArt
            // 
            this.lblNombreArt.AutoSize = true;
            this.lblNombreArt.Location = new System.Drawing.Point(378, 95);
            this.lblNombreArt.Name = "lblNombreArt";
            this.lblNombreArt.Size = new System.Drawing.Size(47, 13);
            this.lblNombreArt.TabIndex = 34;
            this.lblNombreArt.Text = "Nombre:";
            // 
            // txtNombreArt
            // 
            this.txtNombreArt.Location = new System.Drawing.Point(381, 111);
            this.txtNombreArt.MaxLength = 50;
            this.txtNombreArt.Name = "txtNombreArt";
            this.txtNombreArt.Size = new System.Drawing.Size(288, 20);
            this.txtNombreArt.TabIndex = 20;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(585, 205);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 33;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(588, 221);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(168, 20);
            this.txtPrecio.TabIndex = 27;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Location = new System.Drawing.Point(493, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 32);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Location = new System.Drawing.Point(150, 279);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(153, 32);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "Aceptar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "URL de Imagen:";
            // 
            // txtURLImagen
            // 
            this.txtURLImagen.Location = new System.Drawing.Point(489, 167);
            this.txtURLImagen.MaxLength = 1000;
            this.txtURLImagen.Name = "txtURLImagen";
            this.txtURLImagen.Size = new System.Drawing.Size(267, 20);
            this.txtURLImagen.TabIndex = 24;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(286, 167);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(148, 21);
            this.cboCategoria.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Categoría:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(45, 167);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(192, 21);
            this.cboMarca.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Marca:";
            // 
            // lblDescArt
            // 
            this.lblDescArt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescArt.AutoSize = true;
            this.lblDescArt.Location = new System.Drawing.Point(42, 205);
            this.lblDescArt.Name = "lblDescArt";
            this.lblDescArt.Size = new System.Drawing.Size(66, 13);
            this.lblDescArt.TabIndex = 25;
            this.lblDescArt.Text = "Descripción:";
            // 
            // txtDescArt
            // 
            this.txtDescArt.Location = new System.Drawing.Point(45, 221);
            this.txtDescArt.MaxLength = 150;
            this.txtDescArt.Name = "txtDescArt";
            this.txtDescArt.Size = new System.Drawing.Size(492, 20);
            this.txtDescArt.TabIndex = 26;
            // 
            // lblCodigoArt
            // 
            this.lblCodigoArt.AutoSize = true;
            this.lblCodigoArt.Location = new System.Drawing.Point(132, 95);
            this.lblCodigoArt.Name = "lblCodigoArt";
            this.lblCodigoArt.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoArt.TabIndex = 21;
            this.lblCodigoArt.Text = "Codigo:";
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(135, 111);
            this.txtCodArt.MaxLength = 50;
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(168, 20);
            this.txtCodArt.TabIndex = 1;
            // 
            // lblTítuloModificar
            // 
            this.lblTítuloModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTítuloModificar.AutoSize = true;
            this.lblTítuloModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTítuloModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítuloModificar.Location = new System.Drawing.Point(146, 21);
            this.lblTítuloModificar.MinimumSize = new System.Drawing.Size(500, 50);
            this.lblTítuloModificar.Name = "lblTítuloModificar";
            this.lblTítuloModificar.Size = new System.Drawing.Size(500, 50);
            this.lblTítuloModificar.TabIndex = 18;
            this.lblTítuloModificar.Text = "MODIFICAR UN ARTÍCULO";
            this.lblTítuloModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 335);
            this.Controls.Add(this.lblNombreArt);
            this.Controls.Add(this.txtNombreArt);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtURLImagen);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescArt);
            this.Controls.Add(this.txtDescArt);
            this.Controls.Add(this.lblCodigoArt);
            this.Controls.Add(this.txtCodArt);
            this.Controls.Add(this.lblTítuloModificar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 374);
            this.Name = "frmModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Artículo";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreArt;
        private System.Windows.Forms.TextBox txtNombreArt;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtURLImagen;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescArt;
        private System.Windows.Forms.TextBox txtDescArt;
        private System.Windows.Forms.Label lblCodigoArt;
        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.Label lblTítuloModificar;
    }
}