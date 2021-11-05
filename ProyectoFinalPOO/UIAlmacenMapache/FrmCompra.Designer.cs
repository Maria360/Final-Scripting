
namespace UIAlmacenMapache
{
    partial class FrmCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.listProveedores = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectCantidadCompra = new System.Windows.Forms.NumericUpDown();
            this.lblSelectProducto = new System.Windows.Forms.Label();
            this.listProductos = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudKits = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lstKits = new System.Windows.Forms.ListBox();
            this.btnKits = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectCantidadCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKits)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCalificacion);
            this.groupBox1.Controls.Add(this.lblSeleccion);
            this.groupBox1.Controls.Add(this.listProveedores);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(23, 142);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(73, 15);
            this.lblCalificacion.TabIndex = 2;
            this.lblCalificacion.Text = "Calificación:";
            this.lblCalificacion.Click += new System.EventHandler(this.lblCalificacion_Click);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(3, 36);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(139, 15);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "Selecciona el proveedor";
            // 
            // listProveedores
            // 
            this.listProveedores.DisplayMember = "Nombre";
            this.listProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProveedores.FormattingEnabled = true;
            this.listProveedores.ItemHeight = 16;
            this.listProveedores.Location = new System.Drawing.Point(17, 62);
            this.listProveedores.Name = "listProveedores";
            this.listProveedores.Size = new System.Drawing.Size(167, 68);
            this.listProveedores.TabIndex = 0;
            this.listProveedores.SelectedIndexChanged += new System.EventHandler(this.listProveedores_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMoneda);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.selectCantidadCompra);
            this.groupBox2.Controls.Add(this.lblSelectProducto);
            this.groupBox2.Controls.Add(this.listProductos);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(266, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 289);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(188, 242);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(32, 15);
            this.lblMoneda.TabIndex = 5;
            this.lblMoneda.Text = "COP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite el precio unitario del producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PresionarLetra);
            // 
            // selectCantidadCompra
            // 
            this.selectCantidadCompra.Location = new System.Drawing.Point(82, 152);
            this.selectCantidadCompra.Name = "selectCantidadCompra";
            this.selectCantidadCompra.Size = new System.Drawing.Size(70, 30);
            this.selectCantidadCompra.TabIndex = 2;
            this.selectCantidadCompra.ValueChanged += new System.EventHandler(this.selectCantidadCompra_ValueChanged);
            // 
            // lblSelectProducto
            // 
            this.lblSelectProducto.AutoSize = true;
            this.lblSelectProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProducto.Location = new System.Drawing.Point(11, 39);
            this.lblSelectProducto.Name = "lblSelectProducto";
            this.lblSelectProducto.Size = new System.Drawing.Size(203, 15);
            this.lblSelectProducto.TabIndex = 1;
            this.lblSelectProducto.Text = "Selecciona el producto y la cantidad";
            // 
            // listProductos
            // 
            this.listProductos.DisplayMember = "Nombre";
            this.listProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 16;
            this.listProductos.Location = new System.Drawing.Point(31, 62);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(167, 68);
            this.listProductos.TabIndex = 0;
            this.listProductos.SelectedIndexChanged += new System.EventHandler(this.listProductos_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIAlmacenMapache.Properties.Resources.raccoon_PNG16969;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(306, 332);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(149, 40);
            this.btnFinalizarCompra.TabIndex = 4;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKits);
            this.groupBox3.Controls.Add(this.nudKits);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lstKits);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(549, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 289);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generar Kit";
            // 
            // nudKits
            // 
            this.nudKits.Location = new System.Drawing.Point(82, 152);
            this.nudKits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKits.Name = "nudKits";
            this.nudKits.Size = new System.Drawing.Size(70, 30);
            this.nudKits.TabIndex = 2;
            this.nudKits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Selecciona el kit y la cantidad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lstKits
            // 
            this.lstKits.DisplayMember = "Nombre";
            this.lstKits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKits.FormattingEnabled = true;
            this.lstKits.ItemHeight = 16;
            this.lstKits.Location = new System.Drawing.Point(31, 62);
            this.lstKits.Name = "lstKits";
            this.lstKits.Size = new System.Drawing.Size(167, 68);
            this.lstKits.TabIndex = 0;
            this.lstKits.SelectedIndexChanged += new System.EventHandler(this.lstKits_SelectedIndexChanged);
            // 
            // btnKits
            // 
            this.btnKits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKits.Location = new System.Drawing.Point(40, 208);
            this.btnKits.Name = "btnKits";
            this.btnKits.Size = new System.Drawing.Size(149, 40);
            this.btnKits.TabIndex = 7;
            this.btnKits.Text = "Generar";
            this.btnKits.UseVisualStyleBackColor = true;
            this.btnKits.Click += new System.EventHandler(this.btnKits_Click);
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(838, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectCantidadCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.ListBox listProveedores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown selectCantidadCompra;
        private System.Windows.Forms.Label lblSelectProducto;
        private System.Windows.Forms.ListBox listProductos;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudKits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstKits;
        private System.Windows.Forms.Button btnKits;
    }
}