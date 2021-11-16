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

        public Licencia(string codigo, string categoria, decimal precio, string organismo, DateTime fechaexpedicion)
        {
            Codigo = codigo;
            Categoria = categoria;
            Precio = precio;
            Organismo = organismo;
            FechaExpedicion = fechaexpedicion;
        }

        public string Codigo { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public string Organismo { get; set; }
        public DateTime FechaExpedicion { get; set; }
    }
}
