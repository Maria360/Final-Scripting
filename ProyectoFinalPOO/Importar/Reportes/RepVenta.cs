using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDeportivo
{
    public class RepVenta : Reporte
    {
        public RepVenta()
        {          
        }

       
        public override string GenerarReporte(List<Compra> compras, List<Venta> ventas, List<Producto> productos)
        {
            string text = "";
            double totalGeneral = 0;
            foreach (var item in ventas)
            {
                string line = $"Nro. Compra: {item.NroVenta}\n\tFecha: {item.FechaVenta}\n\tTotal: {item.Total}\n";
                text = String.Concat(text, line);
                totalGeneral += item.Total;
            }
            string totalGral = $"Total General: {totalGeneral}";

            return text = String.Concat(text, totalGral);
        }
    }
}
