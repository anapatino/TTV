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


        public Multa_Usuario(string codigoMulta, string descripcion, string cedula, string pri_nom, string pri_ape, decimal valor, DateTime fechaExp, string estado)
        {
            CodigoMulta = codigoMulta;
            Multa_descripcion = descripcion;
            Cedula = cedula;
            Pri_nombre = pri_nom;
            Pri_Apellido = Pri_Apellido;
            ValorMulta = valor;
            Fecha_expedicion = fechaExp;
            Estado = estado;
        }

        public string CodigoMulta { get; set; }
        public string Multa_descripcion { get; set; }
        public string Cedula { get; set; }
        public string Pri_nombre { get; set; }
        public string Pri_Apellido { get; set; }
        public decimal ValorMulta { get; set; }
        public DateTime Fecha_expedicion { get; set; }
        public string Estado { get; set; }
      


    }
}
