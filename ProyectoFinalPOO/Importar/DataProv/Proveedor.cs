using System;
using System.Collections.Generic;
using System.Text;

namespace AlmacenDeportivo
{
    public abstract class Proveedor
    {
        private string calificacion;
        private string nombre;

        public Proveedor(string calificacion, string nombre)
        {
            this.calificacion = calificacion.ToUpper();
            this.nombre = nombre;
        }

        public string Calificacion { get => calificacion;  }
        public string Nombre { get => nombre; }

        public abstract double ConvertirMoneda(double precio);
        
        public abstract double ConsultarRecargo(int cantidad);
    }
}
