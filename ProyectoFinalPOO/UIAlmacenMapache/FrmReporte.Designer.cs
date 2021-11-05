
namespace UIAlmacenMapache
{
    partial class FrmReporte
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
            this.btnRepCompra = new System.Windows.Forms.Button();
            this.btnRepVentas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.TXTReport = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRepCompra
            // 
            this.btnRepCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepCompra.Location = new System.Drawing.Point(42, 87);
            this.btnRepCompra.Name = "btnRepCompra";
            this.btnRepCompra.Size = new System.Drawing.Size(117, 50);
            this.btnRepCompra.TabIndex = 0;
            this.btnRepCompra.Text = "Compras";
            this.btnRepCompra.UseVisualStyleBackColor = true;
            this.btnRepCompra.Click += new System.EventHandler(this.btnRepCompra_Click);
            // 
            // btnRepVentas
            // 
            this.btnRepVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepVentas.Location = new System.Drawing.Point(42, 199);
            this.btnRepVentas.Name = "btnRepVentas";
            this.btnRepVentas.Size = new System.Drawing.Size(117, 50);
            this.btnRepVentas.TabIndex = 1;
            this.btnRepVentas.Text = "Ventas";
            this.btnRepVentas.UseVisualStyleBackColor = true;
            this.btnRepVentas.Click += new System.EventHandler(this.btnRepVentas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(42, 320);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(117, 50);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // TXTReport
            // 
            this.TXTReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TXTReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTReport.Location = new System.Drawing.Point(204, 19);
            this.TXTReport.Name = "TXTReport";
            this.TXTReport.ReadOnly = true;
            this.TXTReport.Size = new System.Drawing.Size(404, 414);
            this.TXTReport.TabIndex = 4;
            this.TXTReport.Text = "";
            this.TXTReport.TextChanged += new System.EventHandler(this.TXTReport_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIAlmacenMapache.Properties.Resources.aaaaa;
            this.pictureBox1.Location = new System.Drawing.Point(601, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTReport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnRepVentas);
            this.Controls.Add(this.btnRepCompra);
            this.Name = "FrmReporte";
            this.Text = "Generar Reporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRepCompra;
        private System.Windows.Forms.Button btnRepVentas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox TXTReport;
    }
}