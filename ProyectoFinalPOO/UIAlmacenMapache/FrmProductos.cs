using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlmacenDeportivo;

namespace UIAlmacenMapache
{
    public partial class FrmProductos : Form
    {
        private List<Producto> productos;
        private List<NumericUpDown> nuds = new List<NumericUpDown>();
        public Venta venta;
        public FrmProductos(List<Producto> productos)
        {
            InitializeComponent();            
            this.productos = productos;
            CrearTarjetas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No hay texto en el nombre");
                return;
            }
            if (txtCorreo.Text.Length == 0 || !txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("Correo inválido");
                return;
            }

            Cliente cliente = new Cliente(txtNombre.Text, txtCorreo.Text);
            venta = new Venta(cliente);

            int contadorNUD = 0;
            for (int i = 0; i<productos.Count; i++)
            {                
                if (nuds[i].Value != 0)
                {
                    venta.AgregarProducto(productos[i], (int)nuds[i].Value);
                    contadorNUD++;
                }
            }
            if (contadorNUD != 0)
            {
                venta.FinalizarVenta(venta.Pdtos);
                DialogResult = DialogResult.Yes;
                FrmEmail frmEmail = new FrmEmail();
                frmEmail.Show();
                this.Close();
            }
            else MessageBox.Show("Debe ingresar cantidad a comprar");
        }

        private void lblPrecioBalon_Click(object sender, EventArgs e)
        {
            
        }

        private void selectCantidadPorteria_ValueChanged(object sender, EventArgs e)
        {

        }

        private void selectCantidadBalon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CrearTarjetas() 
        {
            nuds.Clear();
            flowLayoutPanel1.Controls.Clear();
            int i = 0;
            foreach (Producto producto in productos)
            {
                nuds.Insert(i, new NumericUpDown());

                //Se crea el panel
                Panel p = new Panel();
                p.Name = "panel" + (flowLayoutPanel1.Controls.Count + 1);
                p.BackgroundImageLayout = ImageLayout.Stretch; 
                p.BackgroundImage = Properties.Resources.fdp4;
                p.Size = new Size(260, 260);

                //se crea la imagen 
                PictureBox pb = new PictureBox(); //cómo agregamos al imagen
                pb.Size = new Size(169, 132);
                pb.Location = new Point(34, 14);
                p.Controls.Add(pb);

                //se crea label Nombre
                Label lbnombre = new Label();
                lbnombre.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                lbnombre.Text = producto.Nombre;
                lbnombre.Location = new Point(30, 149);
                p.Controls.Add(lbnombre);

                //se crea label precio 
                Label lbppg = new Label();
                lbppg.Font = new Font("Microsoft Sans Serif", 10);
                lbppg.Text = "$" + producto.PrecioVenta;
                lbppg.Location = new Point(30, 176);
                p.Controls.Add(lbppg);

                //se crea label disponibles
                Label lbdisp = new Label();
                lbdisp.Font = new Font("Microsoft Sans Serif", 12);
                lbdisp.Text = "Stock: " + producto.Stock;
                lbdisp.Location = new Point(146, 149);
                p.Controls.Add(lbdisp);

                //se crea numeric Up Down Escoger
                NumericUpDown numericEscoger = new NumericUpDown();
                numericEscoger.Location = new Point(151, 184);
                numericEscoger.Size = new Size(69, 20);
                numericEscoger.Maximum = producto.Stock;
                numericEscoger.Minimum = 0;
                nuds.Insert(i, numericEscoger);

                p.Controls.Add(numericEscoger);
                if (producto.Stock == 0) numericEscoger.Enabled = false;
                flowLayoutPanel1.Controls.Add(p);
                i++;
            }
        } 
        private void btnAgregar_Click_Click(object sender, EventArgs e)
        {

        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
