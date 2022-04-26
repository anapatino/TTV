using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using Infraestructura;

namespace Logica
{
    public class EmailService
    {
        Email email;

        public EmailService()
        {
            email = new Email();
        }

        public string RecuperarContrasena(Cuenta cuenta)
        {
            string mensaje=string.Empty;

            try
            { 
                mensaje = email.EnviarEmail(cuenta);
                return mensaje;
            }
            catch (Exception e)
            {
                return $"Se presento el siguiente Error : {e.Message}";
            }

        }

    }
}
