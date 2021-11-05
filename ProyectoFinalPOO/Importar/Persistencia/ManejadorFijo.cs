using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDeportivo
{
    public class ManejadorFijo : IManejadorDePersistencia
    {
        public List<Producto> CargarProducto()
        {
            throw new NotImplementedException();
        }

        public List<Proveedor> CargarProveedor()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            proveedores.Add(new ProvInternacional("AAA", "Kevin"));
            proveedores.Add(new ProvInternacional("A", "Juan"));
            proveedores.Add(new ProvNacional("A", "Pepe"));
            proveedores.Add(new ProvNacional("AA", "Camilo"));
            proveedores.Add(new ProvNacional("AAA", "Florencio"));
            return proveedores;
        }
    }
}
