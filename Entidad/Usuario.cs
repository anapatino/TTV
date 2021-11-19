using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        public Usuario()
        {

        }

        public Usuario(string codigo, string pri_nombre, string seg_nombre, string pri_apellido, string seg_apellido, DateTime fechaNacimiento, string telefono, string grupoSanguineo,string licenciaCodigo,string ciudadCodigo,string barrioCodigo,string restriccionCodigo )
        {
            Codigo = codigo;
            Pri_nombre = pri_nombre;
            Seg_nombre = seg_nombre;
            Pri_apellido = pri_apellido;
            Seg_apellido = seg_apellido;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Grupo_Sanguineo = grupoSanguineo;
            LicenciaCodigo = licenciaCodigo;
            CiudadCodigo = ciudadCodigo;
            BarrioCodigo = barrioCodigo;
            RestriccionCodigo = restriccionCodigo;
    }

        public string Codigo{ get; set; }
        public string Pri_nombre { get; set; }
        public string Seg_nombre { get; set; }
        public string Pri_apellido { get; set; }
        public string Seg_apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Grupo_Sanguineo { get; set; }
        public string LicenciaCodigo { get; set; }
        public string CiudadCodigo { get; set; }
        public string BarrioCodigo { get; set; }
        public string RestriccionCodigo { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
