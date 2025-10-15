namespace TPWinForm_Equipo14A
{
    partial class frmModificarMarca
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
            this.lblTítuloModificar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblDescMarca = new System.Windows.Forms.Label();
            this.txtDescMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTítuloModificar
            // 
            this.lblTítuloModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTítuloModificar.AutoSize = true;
            this.lblTítuloModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTítuloModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTítuloModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTítuloModificar.Location = new System.Drawing.Point(43, 9);
            this.lblTítuloModificar.MinimumSize = new System.Drawing.Size(500, 50);
            this.lblTítuloModificar.Name = "lblTítuloModificar";
            this.lblTítuloModificar.Size = new System.Drawing.Size(500, 50);
            this.lblTítuloModificar.TabIndex = 19;
            this.lblTítuloModificar.Text = "MODIFICAR UNA MARCA";
            this.lblTítuloModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(390, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(47, 152);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(153, 32);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Aceptar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblDescMarca
            // 
            this.lblDescMarca.AutoSize = true;
            this.lblDescMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescMarca.Location = new System.Drawing.Point(144, 75);
            this.lblDescMarca.Name = "lblDescMarca";
            this.lblDescMarca.Size = new System.Drawing.Size(66, 13);
            this.lblDescMarca.TabIndex = 38;
            this.lblDescMarca.Text = "Descripción:";
            // 
            // txtDescMarca
            // 
            this.txtDescMarca.Location = new System.Drawing.Point(147, 91);
            this.txtDescMarca.MaxLength = 50;
            this.txtDescMarca.Name = "txtDescMarca";
            this.txtDescMarca.Size = new System.Drawing.Size(288, 20);
            this.txtDescMarca.TabIndex = 1;
            // 
            // frmModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 206);
            this.Controls.Add(this.lblDescMarca);
            this.Controls.Add(this.txtDescMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTítuloModificar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Marca";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTítuloModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblDescMarca;
        private System.Windows.Forms.TextBox txtDescMarca;
    }
}