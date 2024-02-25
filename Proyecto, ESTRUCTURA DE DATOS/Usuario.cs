using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }

        public Usuario(string nombre, string correo, string password)
        {
            Nombre = nombre;
            Correo = correo;
            Password = password;
        }
    }
}
