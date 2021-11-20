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
    public class UsuarioRepository
    {
        DbConnection _connection;

        public UsuarioRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public void GuardarUsuario(Usuario usuario)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "CALL PK1INSERTAR.REGISTRAR_USUARIO(:Codigo,:Prinombre,:Segnombre,:Priape,:Segape,:FechaNacim,:Telefono,:GrupSan,:LiCod,:CiudCod,:BarrCod,:RessCod)";
                command.Parameters.Add(new OracleParameter("Codigo", usuario.Codigo));
                command.Parameters.Add(new OracleParameter("Prinombre", usuario.Pri_nombre));
                command.Parameters.Add(new OracleParameter("Segnombre", usuario.Seg_nombre));
                command.Parameters.Add(new OracleParameter("Priape", usuario.Pri_apellido));
                command.Parameters.Add(new OracleParameter("Segape", usuario.Seg_apellido));
                command.Parameters.Add(new OracleParameter("FechaNacim", usuario.FechaNacimiento));
                command.Parameters.Add(new OracleParameter("Telefono", usuario.Telefono));
                command.Parameters.Add(new OracleParameter("GrupSan", usuario.Grupo_Sanguineo));
                command.Parameters.Add(new OracleParameter("LiCod", usuario.LicenciaCodigo));
                command.Parameters.Add(new OracleParameter("CiudCod", usuario.CiudadCodigo));
                command.Parameters.Add(new OracleParameter("BarrCod", usuario.BarrioCodigo));
                command.Parameters.Add(new OracleParameter("RessCod", usuario.RestriccionCodigo));
                command.ExecuteNonQuery();
            }
        }

    }
}
