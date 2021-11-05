using System;
using System.Collections.Generic;
using System.Text;

namespace AlmacenDeportivo
{
    public class Cliente
    {
        private string nombre;
        private string email;

        public Cliente(string nombre, string email)
        {
            this.nombre = nombre;
            this.email = email;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
    }
}
