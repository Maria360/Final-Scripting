using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDeportivo
{
    public interface IManejadorDePersistencia
    {
        /// <summary>
        /// Carga los productos a la lista de productos
        /// </summary>
        /// <returns>Devuelve la lista de productos</returns>
        List<Producto> CargarProducto();
        /// <summary>
        /// Carga los proveedores a la lista de proveedores
        /// </summary>
        /// <returns>Devuelve la lista de proveedores</returns>
        List<Proveedor> CargarProveedor();
    }
}
