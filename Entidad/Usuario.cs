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

        public Usuario(string usu_cod_pk, string pri_nombre, string seg_nombre, string pri_apellido, string seg_apellido, DateTime usu_fechaNacimiento, string usu_telefono, string usu_grupoSanguineo,string li_codigo_fk,string ciud_codigo_fk,string barr_codgio_fk,string res_cod_fk )
        {
            Usu_codigo_pk = usu_cod_pk;
            Pri_nombre = pri_nombre;
            Seg_nombre = seg_nombre;
            Pri_apellido = pri_apellido;
            Seg_apellido = seg_apellido;
            Usu_fechaNacimiento = usu_fechaNacimiento;
            Usu_telefono = usu_telefono;
            Usu_grupo_Sanguineo = usu_grupoSanguineo;
            Li_codigo_fk = li_codigo_fk;
            Ciud_codigo_fk = ciud_codigo_fk;
            Barr_codigo_fk = barr_codgio_fk;
            Res_cod_fk = res_cod_fk;
    }

        public string Usu_codigo_pk { get; set; }
        public string Pri_nombre { get; set; }
        public string Seg_nombre { get; set; }
        public string Pri_apellido { get; set; }
        public string Seg_apellido { get; set; }
        public DateTime Usu_fechaNacimiento { get; set; }
        public string Usu_telefono { get; set; }
        public string Usu_grupo_Sanguineo { get; set; }
        public string Li_codigo_fk { get; set; }
        public string Ciud_codigo_fk { get; set; }
        public string Barr_codigo_fk { get; set; }
        public string Res_cod_fk { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
