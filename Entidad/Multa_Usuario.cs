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

        public Multa_Usuario(string usu_cod_fk,string pri_nombre, string pri_apellido,string mul_id_fk,string mul_descripcion,  string estado, DateTime fechaexpedicion, decimal mul_valor)
        {
            Usu_cod_fk = usu_cod_fk;
            Pri_nombre = pri_nombre;
            Pri_Apellido = pri_apellido;
            Mul_id_fk = mul_id_fk;
            Mul_descripcion = mul_descripcion;
            Estado = estado;
            Fecha_expedicion = fechaexpedicion;
            Mul_valor = mul_valor;
        }

        public string Usu_cod_fk { get; set; }
        public string Pri_nombre { get; set; }
        public string Pri_Apellido { get; set; }
        public string Mul_id_fk { get; set; }
        public string Mul_descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_expedicion { get; set; }
        public decimal Mul_valor { get; set; }


    }
}
