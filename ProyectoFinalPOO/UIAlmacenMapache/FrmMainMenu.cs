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
    public partial class FrmMainMenu : Form
    {
        List<Producto> pdtos = new List<Producto>();
        List<Proveedor> proveedores = new List<Proveedor>();
        List<Compra> compras = new List<Compra>();
        List<Venta> ventas = new List<Venta>();

        public FrmMainMenu()
        {
            InitializeComponent();
            IManejadorDePersistencia manejadorTxt = new ManejadorTXT();
            IManejadorDePersistencia manejadorFijo = new ManejadorFijo();
            pdtos = manejadorTxt.CargarProducto();
            proveedores = manejadorFijo.CargarProveedor();
            //Program.Music();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sale el frm de compra
            FrmCompra frmCompra = new FrmCompra(pdtos, proveedores);
            frmCompra.ShowDialog();

            //si retorna correctamente hace esto
            if(frmCompra.DialogResult == DialogResult.Yes)
            {
                if(frmCompra.compra != null)
                {
                    compras.Add(frmCompra.compra);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new  FrmProductos(pdtos);
            frmProductos.ShowDialog();

            //si retorna correctamente hace esto
            if (frmProductos.DialogResult == DialogResult.Yes)
            {
                if (frmProductos.venta != null)
                {                  
                    ventas.Add(frmProductos.venta);
                }
            }
        }


        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte(compras, ventas, pdtos);
            frmReporte.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            EdicionTXT edicion = new EdicionTXT(pdtos);
            edicion.ReescribirProductos();
        }
    }
}
