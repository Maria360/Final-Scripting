using System;
using System.Collections.Generic;
using System.Text;

namespace AlmacenDeportivo
{
    public class ProvNacional: Proveedor
    {
        public ProvNacional(string calificacion, string nombre) : base(calificacion, nombre)
        {

        }
        
        
        public override double ConsultarRecargo(int cantidad)
        {
            if (Calificacion == "A")
                return 1.01;
            else if (Calificacion == "AA")
                return 1.02;
            else if (Calificacion == "AAA")
            {
                if (cantidad >= 200)
                    return 0.97; //descuento del 3%
                else return 1.02;
            }
            else
            {
                throw new Exception("Calificación Inválida"); 
            }
        }
        public override double ConvertirMoneda(double precio)
        {
            return precio;
        }
    }
}
