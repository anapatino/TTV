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

        public HistorialPagoMulta(string historialId, string codigo, string pri_nombre, string pri_apellido, string multaId, string multaDescripcion, string estado, DateTime fechapago)
        {
            HistoriaId = historialId;
            Codigo = codigo;
            Pri_nombre = pri_nombre;
            Pri_Apellido = pri_apellido;
            Multa_id = multaId;
            Multa_descripcion = multaDescripcion;
            Estado = estado;
            FechaPago = fechapago;
            Mul_valor = valor;
        }

        public string HistoriaId { get; set; }
        public string Codigo { get; set; }
        public string Pri_nombre { get; set; }
        public string Pri_Apellido { get; set; }
        public string Multa_id { get; set; }
        public string Multa_descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Mul_valor { get; set; }
    }
}
