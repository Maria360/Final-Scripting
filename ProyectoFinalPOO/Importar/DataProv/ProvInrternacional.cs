using System;
using System.Collections.Generic;
using System.Text;

namespace AlmacenDeportivo
{
    public class ProvInternacional: Proveedor
    {
        private double tmv = 3665;
        public ProvInternacional(string calificacion, string nombre) : base(calificacion, nombre)
        {

        }
        public double Tmv { get => tmv;  }
       
        public override double ConsultarRecargo(int cantidad)
        {
            return 1;
        }
        public override double ConvertirMoneda(double precio)
        {
            return precio * tmv;
        }
    }
}
