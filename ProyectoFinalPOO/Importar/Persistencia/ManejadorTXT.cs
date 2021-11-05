using AlmacenDeportivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlmacenDeportivo
{
    public class ManejadorTXT : IManejadorDePersistencia
    {
        public List<Producto> CargarProducto()
        {
            List<Producto> productos = new List<Producto>();
            LeerTXT(productos);
            return productos;
        }
        private void LeerTXT(List<Producto> productos)
        {
            if (File.Exists("producto.txt"))
            {
                var pdtos = File.ReadAllLines("producto.txt");
                foreach (var item in pdtos)
                {
                    if (item[0] != '.')
                    {
                        string[] linea = item.Split('#');
                        if (item[0] == '*')
                        {
                            Producto pd = productos.Find(x => x.Codigo.ToString() == linea[1]);
                            if (pd is null)
                            {
                                PdtoIndividual pdto = new PdtoIndividual(linea[0].Substring(1), long.Parse(linea[1]));
                                pdto.Stock = int.Parse(linea[2]);
                                pdto.PrecioVenta = double.Parse(linea[3]);
                                productos.Add(pdto);
                            }
                        }
                        else if (item[0] == '-')
                        {
                            bool siStock = false;
                            for (int i = 2; i < linea.Length; i++)
                            {
                                Producto pd = productos.Find(x => x.Codigo == long.Parse(linea[i]));
                                if (pd != null)
                                {
                                    if (pd.Stock <= 0)
                                    {
                                        siStock = false;
                                        break;
                                    }
                                    else siStock = true;
                                }
                            }

                            Kit kit = new Kit(linea[0].Substring(1), long.Parse(linea[1]));
                            for (int i = 2; i < linea.Length; i++)
                            {
                                Producto pd = productos.Find(x => x.Codigo == long.Parse(linea[i]));
                                if (pd != null)
                                {
                                    kit.AgregarProductoKit(pd);
                                    if (!siStock) pd.Stock++;
                                }
                            }
                            if (!siStock)
                                kit.Stock = 0;
                            productos.Add(kit);
                        }
                    }
                }
            }
        }
        public List<Proveedor> CargarProveedor()
        {
            throw new NotImplementedException();
        }
    }
}
