using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDeportivo
{
    public interface IFactura
    {
        bool GenerarFactura(Venta venta);
        
        bool EnviarFactura();
    }
}
