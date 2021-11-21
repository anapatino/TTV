using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Multa
    {
        public Multa()
        {

        }

        public Multa(string cedula,string codigo,DateTime fechaExpedicion,string vehiculoId,string vehiculoNombre,string descripcion, decimal valor)
        {
            Cedula = cedula;
            Mul_Id = codigo;
            Estado = "PENDEINTE";
            FechaExpedicion = fechaExpedicion;
            Vehiculo_Id = vehiculoId;
            VehiculoNombre = vehiculoNombre;
            Descripcion = descripcion;
            Valor = valor;
        }

        public string Cedula { get; set; }
        public string Mul_Id { get; set; }
        public string Estado { get; set; }
        public DateTime FechaExpedicion { get; set; }
        public string Vehiculo_Id { get; set; }
        public string VehiculoNombre { get; set; }
        public string Descripcion { get; set; }
        public Decimal Valor { get; set; }

        public int GenerarCodigo()
        {
            Random r = new Random();
            return r.Next(1, 9999999);
        }
    }
}
