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
    public partial class FrmReporte : Form
    {
        List<Compra> compras = new List<Compra>();
        List<Venta> ventas = new List<Venta>();
        List<Producto> productos = new List<Producto>();

        public FrmReporte(List<Compra> compras, List<Venta> ventas, List<Producto> productos)
        {
            InitializeComponent();
            this.compras = compras;
            this.productos = productos;
            this.ventas = ventas;
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

        }

        private void btnRepCompra_Click(object sender, EventArgs e)
        {
            RepCompra repCompra = new RepCompra();
            TXTReport.Text = repCompra.GenerarReporte(compras, ventas, productos);                    
        }

        private void TXTReport_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRepVentas_Click(object sender, EventArgs e)
        {
            RepVenta repVenta = new RepVenta();
            TXTReport.Text = repVenta.GenerarReporte(compras, ventas, productos);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            RepProducto repProducto = new RepProducto();
            TXTReport.Text = repProducto.GenerarReporte(compras, ventas, productos);
        }
    }
}
