using System;
using Datos;
using Entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LicenciaUsuarioConsultaResponse
    {
        public List<Usuario_Licencia> UsuarioLicencia { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public LicenciaUsuarioConsultaResponse(List<Usuario_Licencia> usuarioLicencia)
        {
            UsuarioLicencia= usuarioLicencia;
            Error = false;
        }

        public LicenciaUsuarioConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
   
}
