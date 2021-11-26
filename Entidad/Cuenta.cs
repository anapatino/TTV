using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cuenta
    {
        public Cuenta()
        {

        }

        public Cuenta(string codigo,string nombre,string usuario,string password)
        {
            Codigo = codigo;
            NombreUsuario = nombre;
            Usuario = usuario;
            Password = password;
        }

        public string Codigo { get; set; }

        public string NombreUsuario { get; set; }

        public string Usuario { get; set; }

        public string Password { get; set; }
    }
}
