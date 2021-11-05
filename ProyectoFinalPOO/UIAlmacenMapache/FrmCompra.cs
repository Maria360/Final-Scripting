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
    public partial class FrmCompra : Form
    {
        public Compra compra;
        public FrmCompra(List<Producto> pdtos, List<Proveedor> proveedores)
        {
            InitializeComponent();
            compra = new Compra();

            listProveedores.DataSource = proveedores;
            foreach (var item in pdtos) if (item is PdtoIndividual) listProductos.Items.Add(item);
            foreach (var item in pdtos) if (item is Kit) lstKits.Items.Add(item);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Compra_Load(object sender, EventArgs e)
        {

        }
        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                
                int cantidadCompra = Convert.ToInt32(selectCantidadCompra.Value);
                double precioCompra = double.Parse(textBox1.Text);
                Producto pdto = (Producto)listProductos.SelectedItem;
                Proveedor prvdr = (Proveedor)listProveedores.SelectedItem;

                if (cantidadCompra <= 0 || pdto == null)
                {
                    MessageBox.Show("Verifique los datos ingresados");
                }
                else
                {
                    compra.Comprar(pdto, cantidadCompra, prvdr, precioCompra);
                    MessageBox.Show("Compra realizada exitosamente");
                    DialogResult = DialogResult.Yes;
                }
            }
            catch 
            {
                MessageBox.Show("Error: Debes llenar todos los campos solicitados");
            }
        }
        private void listProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void selectCantidadCompra_ValueChanged(object sender, EventArgs e)
        {

        }
        private void lblCalificacion_Click(object sender, EventArgs e)
        {

        }
        private void listProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCalificacion.Text = $"Calificación: {((Proveedor)listProveedores.SelectedItem).Calificacion}";

            //label del precio a ingresar
            if (listProveedores.SelectedItem is ProvInternacional)
                lblMoneda.Text = "USD";
            else if (listProveedores.SelectedItem is ProvNacional)
                lblMoneda.Text = "COP";
            else lblMoneda.Text = "...";
        }
        private void PresionarLetra(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void lstKits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnKits_Click(object sender, EventArgs e)
        {
            int cantidad = (int)nudKits.Value;
            if(lstKits.SelectedItem == null)
                MessageBox.Show("Seleccione un Kit");
            else
            {
                Kit kit = (Kit)lstKits.SelectedItem;
                if (kit.GenerarStock(cantidad))
                    MessageBox.Show("Kit creado exitosamente!");
                else
                    MessageBox.Show("No hay stock suficiente para crear ese kit");
            }
        }
    }
}
