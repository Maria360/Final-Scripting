using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;

namespace AlmacenDeportivo
{
    public class FacturaMAIL : IFactura
    {
        public bool GenerarFactura(Venta venta)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"---> Venta No.{venta.NroVenta}" +
                    $"\n\tFecha: {venta.FechaVenta}" +
                    $"\n\tCliente: {venta.Cliente.Nombre}" +
                    $"\n\tEmail: {venta.Cliente.Email}");

                foreach (var item in venta.Pdtos)
                {
                    string pdto = item.Producto.Nombre;
                    string codigo = item.Producto.Codigo.ToString();
                    string cntdad = item.Cantidad.ToString();
                    string precio = item.PrecioVenta.ToString();

                    sb.AppendLine($"\n\tProducto: {pdto}" +
                   $"\n\tCódigo: {codigo}" +
                   $"\n\tCantidad: {cntdad}" +
                   $"\n\tPrecio Und: {precio}");
                }

                sb.AppendLine($"\n\tSubtotal Neto: {venta.SubtotalNeto}" +
                    $"\n\tTotal: {venta.Total}");

                File.WriteAllText("factura.txt", sb.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EnviarFactura()
        {
            throw new NotImplementedException();
            /*MailMessage msg = new MailMessage();

            msg.To.Add("anagigv1@gmail.com");
            msg.Subject = "Tu factura de compra";
            msg.SubjectEncoding = Encoding.UTF8;

            //Adjuntar el txt creado en generar factura
            msg.Body = "a hola";
            msg.BodyEncoding = Encoding.UTF8;

            msg.From = new MailAddress("somosclubpenguin@gmail.com");

            SmtpClient cliente = new SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("somosclubpenguin@gmail.com", "somosCP1");

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smpt.gmail.com";

            try
            {
                cliente.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }*/
        }
    }
}


