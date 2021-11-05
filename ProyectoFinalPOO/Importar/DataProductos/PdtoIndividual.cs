using System;
using System.Collections.Generic;
using System.Text;

namespace AlmacenDeportivo
{
    public class PdtoIndividual: Producto
    {
        public PdtoIndividual(string nombre, long codigo) : base (nombre, codigo)
        {

        }

        public override void ActualizarStockCompra(int cantidad)
        {
            stock += cantidad;
        }

        public override void ActualizarStockVenta(int cantidad)
        {
            stock -= cantidad;
        }
    }
}
