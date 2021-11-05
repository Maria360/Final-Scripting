using System;
using System.Collections.Generic;
using System.Text;

namespace AlmacenDeportivo
{
    public abstract class Producto
    {
        private string nombre;
        internal int stock;
        private long codigo;
        private double precioVenta;

        public Producto(string nombre, long codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }
        public string Nombre { get => nombre; }
        public int Stock { get => stock; set => stock = value; }
        public long Codigo { get => codigo;  }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }


        /// <summary>
        /// Actualiza el inventario después de la compra de un producto.
        /// </summary>
        /// <param name="cantidad"></param>
        abstract public void ActualizarStockCompra(int cantidad);

        /// <summary>
        /// Actualiza el inventario después de la venta de uno o varios productos.
        /// </summary>
        /// <param name="cantidad"></param>
        abstract public void ActualizarStockVenta(int cantidad);

        /// <summary>
        /// Actualiza el precio de venta de los productos basado en el precio de compra mayor.
        /// </summary>
        /// <param name="precio"></param>
        virtual public void ActualizarPrecioVenta(double precio)
        {
            precioVenta = precio + (precio * 0.3);
        }
    }
}
