using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlmacenDeportivo
{
    public class EdicionTXT
    {
        //ESTO VA EN EL UML??

        List<Producto> pdtos;
        public EdicionTXT(List<Producto> pdtos)
        {
            this.pdtos = pdtos;
        }
        public void ReescribirProductos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(".* producto # codigo # stock # precio" +
                "\n.- kit # codigo kit # codigo pdtos");

            foreach (var item in pdtos)
            {
                if (item is PdtoIndividual)
                {
                    sb.AppendLine($"*{item.Nombre}#{item.Codigo}#{item.Stock}#{item.PrecioVenta}");
                }
                else if (item is Kit)
                {
                    sb.Append($"-{item.Nombre}#{item.Codigo}");
                    Kit kit = (Kit)item;
                    foreach(var producto in kit.Productos)
                        sb.Append($"#{producto.Codigo}");
                    sb.Append("\n");
                }
            }

            File.WriteAllText("productosssss.txt", sb.ToString());
        }
    }
}
