using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ComboxConsultasResponse
    {
        public List<string> Combox { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ComboxConsultasResponse(List<string> combox)
        {
            Combox = combox;
            Error = false;
        }

        public ComboxConsultasResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}
