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


        public Multa_Usuario(string codigo,string pri_nombre, string pri_apellido,string multa_id,string multa_descripcion,  string estado)

        {
            Codigo = codigo;
            Pri_nombre = pri_nombre;
            Pri_Apellido = pri_apellido;
            Multa_id = multa_id;
            Multa_descripcion = multa_descripcion;
            Estado = estado;
            //Fecha_expedicion = fechaexpedicion;
            //Mul_valor = mul_valor;
        }

        public string Codigo { get; set; }
        public string Pri_nombre { get; set; }
        public string Pri_Apellido { get; set; }
        public string Multa_id { get; set; }
        public string Multa_descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_expedicion { get; set; }
        public decimal Mul_valor { get; set; }


    }
}
