using System;
using Datos;
using Entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class HistorialPagoMultaConsultaResponse
    {
        public List<HistorialPagoMulta> UsuarioMulta { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public HistorialPagoMultaConsultaResponse(List<HistorialPagoMulta> usuarioMulta)
        {
            UsuarioMulta = usuarioMulta;
            Error = false;
        }

        public HistorialPagoMultaConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}
