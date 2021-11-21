using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Multa_Usuario
    {

        public Multa_Usuario()
        {
   
        }


        public Multa_Usuario(Usuario usuario, Multa multa)
        {
            Usuario = usuario;
            Multa = multa;
            
        }

        public Usuario Usuario { get; set; }
        public Multa Multa { get; set; }

    }
}
