using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;
using System.Data;
using Entidad;

namespace Datos
{
    public class Usuario_LicenciaRepository
    {
        DbConnection _connection;

        public Usuario_LicenciaRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public List<Usuario_Licencia> ConsultarLicencia()
        {
            List<Usuario_Licencia> licencias = new List<Usuario_Licencia>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT U.USU_COD_PK,U.PRI_NOMBRE,U.SEGUN_NOMBRE,U.PRI_APELLIDO,U.SEGUN_APELLIDO,U.USU_FECHANACIMIENTO,U.USU_TELEFONO,U.USU_GRUPOSANGUINEO,U.LI_CODIGO_FK,C.CIUD_NOMBRE,B.BARR_NOMBRE,R.RES_DESCRIPCION,L.LIC_CODIGO_PK,L.LIC_ORGANISMO,L.LIC_FECHA_EXPEDICION, CA.CAT_NOM FROM USUARIO U JOIN CIUDAD C ON(U.CIUD_CODIGO_FK = C.CIUD_CODIGO_PK) JOIN BARRIO B ON(U.BARR_CODIGO_FK= B.BARR_CODIGO_PK) JOIN RESTRICCION R ON(R.RES_COD_PK= U.RES_COD_FK) JOIN LICENCIA L ON(L.LIC_CODIGO_PK= U.LI_CODIGO_FK) JOIN LICENCIA_CATEGORIA LC ON(LC.LIC_CODIGO_FK = U.LI_CODIGO_FK) JOIN CATEGORIA CA ON(LC.CAT_COD_FK = CA.CAT_COD_PK)";

                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        Licencia lic = new Licencia();
                        usuario.Codigo=reader.GetString(0);
                        usuario.Pri_nombre = reader.GetString(1);
                        usuario.Seg_nombre = reader.GetString(2);
                        usuario.Pri_apellido = reader.GetString(3);
                        usuario.Seg_apellido = reader.GetString(4);
                        usuario.FechaNacimiento = reader.GetDateTime(5);
                        usuario.Telefono = reader.GetString(6);
                        usuario.Grupo_Sanguineo = reader.GetString(7);
                        usuario.LicenciaCodigo = reader.GetString(8);
                        usuario.CiudadCodigo = reader.GetString(9);
                        usuario.BarrioCodigo = reader.GetString(10);
                        usuario.RestriccionCodigo = reader.GetString(11);
                        lic.Codigo = reader.GetString(12);
                        lic.Organismo = reader.GetString(13);
                        lic.FechaExp = reader.GetDateTime(14);
                        lic.CodCat = reader.GetString(15);
                        Usuario_Licencia licencia = new Usuario_Licencia(usuario, lic);
                        licencias.Add(licencia);
                    }
                }
                reader.Close();
            }
            return licencias;
        } 

        public void MapearDatos()
        {

        }

        public Usuario_Licencia BuscarUsuario(string identificacion)
        {
            return (Usuario_Licencia)ConsultarLicencia().FirstOrDefault(l => l.Usuario.Codigo.Equals(identificacion));
        }

        public List<Usuario_Licencia> FiltroOrganismo(string organismo)
        {
            return ConsultarLicencia().Where(l => l.Licencia.Organismo.Equals(organismo)).ToList();
        }

        public List<Usuario_Licencia> FiltroCategoria(string categoria)
        {
            return ConsultarLicencia().Where(l => l.Licencia.CodCat.Equals(categoria)).ToList();
        }

        public List<Usuario_Licencia> FiltroNombre(string nombre)
        {
            return ConsultarLicencia().Where(l => l.Usuario.Pri_nombre.Equals(nombre)).ToList();
        }

        public List<Usuario_Licencia> FiltroFecha(int fecha)
        {
            return ConsultarLicencia().Where(l => l.Licencia.FechaExp.Year==fecha).ToList();
        }

    }
}
