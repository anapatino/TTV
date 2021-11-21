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


        public Multa_Usuario(Usuario usuario, Multa multa,string idVehiculo,string nombreVehiculo,string estado,DateTime fecha)
        {
            Usuario = usuario;
            Multa = multa;
            Vehiculo_Id = idVehiculo;
            VehiculoNombre = nombreVehiculo;
            Estado = estado;
            FechaExpedicion = fecha;
        }


        public Usuario Usuario { get; set; }

        public Multa Multa { get; set; }

        public string Vehiculo_Id { get; set; }

        public string VehiculoNombre { get; set; }

        public string Estado { get; set; }

        public DateTime FechaExpedicion { get; set; }

    }
}
