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


        public Multa_Usuario(Usuario usuario, Multa multa, string codigo, string idVehiculo, string nombreVehiculo, string estado, DateTime fecha)
        {
            Usuario = usuario;
            Multa = multa;
            CodigoMultaUsuario = codigo;
            Vehiculo_Id = idVehiculo;
            VehiculoNombre = nombreVehiculo;
            Estado = estado;
            FechaExpedicion = fecha;
        }


        public Usuario Usuario { get; set; }

        public Multa Multa { get; set; }

        public string CodigoMultaUsuario { get; set; }
        public string Vehiculo_Id { get; set; }

        public string VehiculoNombre { get; set; }

        public string Estado { get; set; }

        public DateTime FechaExpedicion { get; set; }

        public int GenerarCodigo()
        {
            Random r = new Random();
            return r.Next(1, 9999);
        }

    }
}
