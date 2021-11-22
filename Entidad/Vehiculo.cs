using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Vehiculo
    {
        public Vehiculo()
        {

        }

        public Vehiculo(string placa, string marca)
        {
            Placa = placa;
            Marca = marca;
        }

        public string Placa { get; set; }
        public string Marca { get; set; }
    }
}
