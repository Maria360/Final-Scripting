
namespace UIAlmacenMapache
{
    partial class FrmMainMenu
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgMapache = new System.Windows.Forms.PictureBox();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMapache)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(25, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(740, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "EL MAPACHE DEPORTIVO";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // imgMapache
            // 
            this.imgMapache.Image = global::UIAlmacenMapache.Properties.Resources.MAPAHCE;
            this.imgMapache.Location = new System.Drawing.Point(129, 143);
            this.imgMapache.Name = "imgMapache";
            this.imgMapache.Size = new System.Drawing.Size(516, 350);
            this.imgMapache.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMapache.TabIndex = 1;
            this.imgMapache.TabStop = false;
            this.imgMapache.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.Location = new System.Drawing.Point(59, 105);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(191, 59);
            this.btnCompra.TabIndex = 2;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Location = new System.Drawing.Point(288, 105);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(191, 59);
            this.btnVenta.TabIndex = 3;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(515, 105);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(191, 59);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnLista
            // 
            this.btnLista.Enabled = false;
            this.btnLista.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(12, 406);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(133, 62);
            this.btnLista.TabIndex = 5;
            this.btnLista.Text = "Actualizar Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Visible = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 480);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.imgMapache);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmMainMenu";
            this.Text = "El Mapache Deportivo";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMapache)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgMapache;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnLista;
    }
}

