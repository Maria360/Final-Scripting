using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Mail;

namespace AlmacenDeportivo
{
    public class Venta
    {
        private List<PdtoVendido> pdtosVendidos = new List<PdtoVendido>();
        private Cliente cliente;

        private double subtotalVenta;
        private double subtotalNeto;

        private DateTime fechaVenta;
        private double subtotal;
        private double iva = 0.19;
        private double dscto = 0.05;
        private double total;
        private int nroVenta;

        public Venta(Cliente cliente)
        {
            this.cliente = cliente;
            Random random = new Random();
            nroVenta = random.Next(1, 10000);
            fechaVenta = DateTime.Now;
        }
        public List<PdtoVendido> Pdtos { get => pdtosVendidos; }
        internal Cliente Cliente { get => cliente; }
        public DateTime FechaVenta { get => fechaVenta; }
        public double Subtotal { get => subtotal; }
        public double SubtotalNeto { get => subtotalNeto; }
        public double Iva { get => iva; }
        public double Total { get => total; }
        public int NroVenta { get => nroVenta; }
        public double Dscto { get => dscto; }

        /// <summary>
        /// Agrega un producto o kit a la lista de productos comprados y actualiza su stock
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        public void AgregarProducto(Producto producto, int cantidad)
        {
            if (producto.Stock != 0 && (producto.Stock - cantidad) >= 0)
            {
                PdtoVendido pdtoVendido = new PdtoVendido(producto, cantidad);
                subtotal = producto.PrecioVenta * cantidad;

                pdtosVendidos.Add(pdtoVendido);

                producto.ActualizarStockVenta(cantidad);
            }
            //control de error implementado en el diseño
        }
        /// <summary>
        /// Finaliza la venta, suma los totales de cada producto vendido, genera el total de la venta
        /// </summary>
        /// <param name="pdtosVendidos"></param>
        public void FinalizarVenta(List<PdtoVendido> pdtosVendidos)
        {
            try
            {
                total = 0;
                subtotalNeto = 0;
                for (int i = 0; i < pdtosVendidos.Count; i++)
                {
                    subtotalNeto += pdtosVendidos[i].PrecioVenta * pdtosVendidos[i].Cantidad;
                    subtotalVenta = pdtosVendidos[i].PrecioVenta * pdtosVendidos[i].Cantidad * (iva + 1);

                    if (pdtosVendidos[i].Cantidad >= 12)
                        subtotalVenta -= (subtotalVenta * dscto);

                    total += subtotalVenta;
                }
                
                GenerarFacturaVenta();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Crea una interfaz de factura y genera la factura de venta
        /// </summary>
        public void GenerarFacturaVenta()
        {
            IFactura generacionFactura = new FacturaMAIL();
            generacionFactura.GenerarFactura(this);
        }
    }
}
