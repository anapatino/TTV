using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Licencia
    {
        public Licencia()
        {

        }

        public Licencia(string codigo, string organismo, DateTime fechaexp, string codcat)
        {
            Codigo = codigo;
            Organismo = organismo;
            FechaExp = fechaexp;
            CodCat = codcat;
        }

        public string Codigo { get; set; }
        public string Organismo { get; set; }
        public DateTime FechaExp { get; set; }
        public string CodCat { get; set; }

    }
}
