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
    public partial class FrmCliente : Form
    {
        List<Producto> productos;
        public Venta venta;
       
        public FrmCliente(List<Producto> productos)
        {
            InitializeComponent();
            this.productos = productos;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClienteFin_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No hay texto en el nombre");
                return;
            }
            if (txtCorreo.Text.Length == 0)
            {
                MessageBox.Show("No hay texto en el correo");
                return;
            }
            Cliente cliente = new Cliente(txtNombre.Text, txtCorreo.Text);

            /*FrmProductos frmProductos = new FrmProductos(cliente, productos);
            frmProductos.Show();

            //si retorna correctamente hace esto
            if (frmProductos.DialogResult == DialogResult.Yes)
            {
                if (frmProductos.venta != null)
                {                   
                    this.venta = frmProductos.venta;
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                
            }*/
            // this.Close(); //cómo hacer que no nos devuelva al menú
        }
    }
}
