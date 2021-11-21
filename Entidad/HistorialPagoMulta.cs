using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class HistorialPagoMulta
    {
        public HistorialPagoMulta()
        {

        }

        public HistorialPagoMulta(Usuario usuario, Multa multa,DateTime fechaPago)
        {
            Usuario = usuario;
            Multa = multa;
            FechaPago = fechaPago;
        }

        public Usuario Usuario { get; set; }
        public Multa Multa { get; set; }
        public DateTime FechaPago { get; set; }
       
    }
}
