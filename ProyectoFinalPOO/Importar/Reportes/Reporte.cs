using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDeportivo
{
    public abstract class Reporte
    {      
        protected Reporte()
        {
        }
        /// <summary>
        /// Genera un reporte con la lista de compras, ventas o inventario.
        /// </summary>
        /// <param name="compras"></param>
        /// <param name="ventas"></param>
        /// <param name="productos"></param>
        /// <returns></returns> Retorna un string
        public abstract string GenerarReporte(List<Compra> compras, List<Venta> ventas, List<Producto> productos);
    }
}
