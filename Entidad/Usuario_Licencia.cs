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

        public Usuario_Licencia(Usuario usuario ,Licencia licencia)
        {
            Usuario = usuario;
            Licencia = licencia;
        }

        public Usuario Usuario { get; set; }

        public Licencia Licencia { get; set; }
    }
}
