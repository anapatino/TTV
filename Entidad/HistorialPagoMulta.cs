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

        public HistorialPagoMulta(Usuario usuario, Multa multa,string codigo,string codigoMultaUsuario,string idVehiculo,string nombreVehiculo,string estado,DateTime fechaPago)
        {
            Usuario = usuario;
            Multa = multa;
            CodigoHistorial = codigo;
            CodigoMultaUsuario = codigoMultaUsuario;
            VehiculoId = idVehiculo;
            VehiculoNombre = nombreVehiculo;
            Estado = estado;
            FechaPago = fechaPago;
        }

        public Usuario Usuario { get; set; }

        public Multa Multa { get; set; }

        public string CodigoHistorial { get; set; }

        public string CodigoMultaUsuario { get; set; }

        public string VehiculoId { get; set; }

        public string VehiculoNombre { get; set; }

        public string Estado { get; set; }

        public DateTime FechaPago { get; set; }
       
    }
}
