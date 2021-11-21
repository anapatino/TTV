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

        public Multa(string codigo,string descripcion, decimal valor)
        {
           
            Mul_Id = codigo;
            Descripcion = descripcion;
            Valor = valor;
        }
      
        public string Mul_Id { get; set; }
    
        public string Descripcion { get; set; }

        public Decimal Valor { get; set; }

        public int GenerarCodigo()
        {
            Random r = new Random();
            return r.Next(1, 9999999);
        }
    }
}
