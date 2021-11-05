using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDeportivo
{
    public class RepProducto : Reporte
    {
        public RepProducto()
        {          
        }
        public override string GenerarReporte(List<Compra> compras, List<Venta> ventas, List<Producto> productos)
        {
            string text = "";
            foreach (var item in productos)
            {
                string line = $"Producto: {item.Nombre}\n\tStock: {item.Stock}\n";
                text = String.Concat(text, line);
                
            }
            return text;
        }
    }
}
