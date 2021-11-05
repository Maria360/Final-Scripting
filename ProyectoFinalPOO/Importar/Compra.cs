using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AlmacenDeportivo
{
    public class Compra
    {
        private Proveedor proveedor;
        private DateTime fechaCompra;   
        private double subtotal;
        private double total;
        private int nroCompra;
        private double dcto = 0.03;


        public Compra()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            nroCompra = random.Next(1, 10000);
            fechaCompra = DateTime.Now;
        }

        internal Proveedor Proveedor { get => proveedor; }
        public DateTime FechaCompra { get => fechaCompra;  }
        public double Subtotal { get => subtotal; }
        public double Total { get => total; }
        public int NroCompra { get => nroCompra; }
        public double Dcto { get => dcto; }

        /// <summary>
        /// Actualiza el stock del producto comprado, se establece su precio, se generan los totales y la factura de compra
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <param name="proveedor"></param>
        /// <param name="precio"></param>
        public void Comprar(Producto producto, int cantidad, Proveedor proveedor, double precio)
        {
            try
            {
                producto.ActualizarStockCompra(cantidad);
                precio = proveedor.ConvertirMoneda(precio);

                //establece precio de venta
                if (precio > (producto.PrecioVenta / 1.3))
                {
                    producto.ActualizarPrecioVenta(precio);
                }
                subtotal = cantidad * precio;
                //añade recargos o descuentos
                total = subtotal * proveedor.ConsultarRecargo(cantidad);
                GenerarFacturaCompra(producto, cantidad, proveedor, precio);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Genera un archivo de texto como factura de la compra
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <param name="proveedor"></param>
        /// <param name="precio"></param>
        public void GenerarFacturaCompra(Producto producto, int cantidad, Proveedor proveedor, double precio)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\n---> COMPRA No.{nroCompra}" +
                $"\n\tFecha: {fechaCompra}" +
                $"\n\tProducto: {producto.Nombre}" +
                $"\n\tCódigo: {producto.Codigo.ToString()}" +
                $"\n\tCantidad: {cantidad.ToString()}" +
                $"\n\tPrecio Und: {precio}" +
                $"\n\tProveedor: {proveedor.Nombre} ({proveedor.Calificacion})" +
                $"\n\tSubtotal: {subtotal}" +
                $"\n\tTotal: {total}");
            File.AppendAllText("compras.txt", sb.ToString());
        }
    }
}
