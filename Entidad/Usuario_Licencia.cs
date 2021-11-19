using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario_Licencia
    {
        public Usuario_Licencia()
        {

        }

        public Usuario_Licencia(string codigo, string cedula,string nombre,string apellido,string grupoSang, string organismo, string categoria,DateTime fechaexpedicion)
        {
            Codigo = codigo;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            GrupoSan = grupoSang;
            Organismo = organismo;
            Categoria = categoria;
            FechaExpedicion = fechaexpedicion;
        }

        public string Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string GrupoSan { get; set; }
        public string Organismo { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaExpedicion { get; set; }
    }
}
