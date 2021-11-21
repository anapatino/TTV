using System;
using Entidad;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MultaUsuarioConsultaResponse
    {
        public List<Multa_Usuario> UsuarioMulta { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public MultaUsuarioConsultaResponse(List<Multa_Usuario> usuarioMulta)
        {
            UsuarioMulta = usuarioMulta;
            Error = false;
        }

        public MultaUsuarioConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}
