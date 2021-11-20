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
                command.CommandText = "SELECT L.LIC_CODIGO_PK,U.USU_COD_PK,U.PRI_NOMBRE,U.SEGUN_APELLIDO,U.USU_GRUPOSANGUINEO,L.LIC_ORGANISMO,C.CAT_NOM,L.LIC_FECHA_EXPEDICION" +
                                      "FROM LICENCIA L JOIN USUARIO U ON(L.LIC_CODIGO_PK = U.LI_CODIGO_FK)" +
                                      "JOIN LICENCIA_CATEGORIA LC ON(LC.LIC_CODIGO_FK= L.LIC_CODIGO_PK)" +
                                      "JOIN CATEGORIA C ON(LC.CAT_COD_FK= C.CAT_COD_PK)";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Usuario_Licencia licencia = new Usuario_Licencia();
                        licencia.Codigo = reader.GetString(0);
                        licencia.Cedula = reader.GetString(1);
                        licencia.Nombre = reader.GetString(2);
                        licencia.Apellido = reader.GetString(3);
                        licencia.GrupoSan = reader.GetString(4);
                        licencia.Organismo = reader.GetString(5);
                        licencia.Categoria = reader.GetString(6);
                        licencia.FechaExpedicion = reader.GetDateTime(7);
                        licencias.Add(licencia);
                    }
                }
                reader.Close();
            }
            return licencias;
        }

        public Usuario_Licencia BuscarUsuario(string identificacion)
        {
            return (Usuario_Licencia)ConsultarLicencia().FirstOrDefault(l => l.Cedula.Equals(identificacion));
        }

        public List<Usuario_Licencia> FiltroOrganismo(string organismo)
        {
            return ConsultarLicencia().Where(l => l.Organismo.Equals(organismo)).ToList();
        }

        public List<Usuario_Licencia> FiltroCategoria(string categoria)
        {
            return ConsultarLicencia().Where(l => l.Categoria.Equals(categoria)).ToList();
        }

        public List<Usuario_Licencia> FiltroNombre(string nombre)
        {
            return ConsultarLicencia().Where(l => l.Nombre.Equals(nombre)).ToList();
        }

        public List<Usuario_Licencia> FiltroFecha(DateTime fecha)
        {
            return ConsultarLicencia().Where(l => l.FechaExpedicion.Equals(fecha)).ToList();
        }

    }
}
