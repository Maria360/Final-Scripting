using System;
using System.Collections.Generic;
using System.Text;

namespace AlmacenDeportivo
{
    public class PdtoVendido
    {
        private Producto producto;
        private int cantidad;
        private double precioVenta;

        public PdtoVendido(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            precioVenta = producto.PrecioVenta;
        }

        public int Cantidad { get => cantidad; }
        public double PrecioVenta { get => precioVenta; }
        internal Producto Producto { get => producto;  }
    }
}
