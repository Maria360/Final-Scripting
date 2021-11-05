using System;
using System.Collections.Generic;
using System.Text;

namespace AlmacenDeportivo
{
    public class Kit : Producto
    {
        private List<Producto> productos = new List<Producto>();
        public Kit(string nombre, long codigo) : base (nombre, codigo)
        {
            this.stock++;
        }
        public List<Producto> Productos { get => productos; }

        /// <summary>
        /// Añade productos individuales al kit, recalcula el precio y disminuye el stock de los productos individuales.
        /// </summary>
        /// <param name="producto"></param>
        public void AgregarProductoKit(Producto producto)
        {
            productos.Add(producto);
            producto.Stock--;
            RecalcularPrecio();
        }

        /// <summary>
        /// Recalcula el precio del kit basado en el precio de los productos individuales que contiene.
        /// </summary>
        private void RecalcularPrecio()
        {
            double precioVentaTmp = 0;
            foreach (var item in Productos)
            {
                precioVentaTmp += item.PrecioVenta;
            }
            precioVentaTmp *= 0.92; //descuento kit
            this.PrecioVenta = precioVentaTmp;
        }

        public override void ActualizarPrecioVenta(double precio)
        {
            throw new Exception("No es posible actualizar precio al kit");
        }
        public override void ActualizarStockCompra(int cantidad)
        {
            throw new Exception("No es posible actualizar stock por compras de kits");
        }
        public override void ActualizarStockVenta(int cantidad)
        {
            stock -= cantidad;
        }


        /// <summary>
        /// Genera un stock particular para los kits en caso de que existan los productos necesarios para crearlos.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns>Si hay stock de productos individuales suficiente para crear el kit, returna true; si no, retorna false.</returns>
        public bool GenerarStock(int cantidad)
        {
            bool siStock = false;
            foreach (Producto item in productos)
            {
                if (item.Stock >= cantidad)
                    siStock = true;
                else
                {
                    siStock = false;
                    break;
                }
            }
            if (siStock == true)
            {
                this.stock += cantidad;
                foreach (Producto item in productos) item.Stock -= cantidad;
                return true;
            }
            else return false;
        }
    }
}
