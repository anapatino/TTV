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
    public class LicenciaRepository
    {
        DbConnection _connection;

        public LicenciaRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public void GuardarLicencia(Licencia licencia)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "CALL PK1INSERTAR.REGISTRAR_LICENCIA_CATEGORIA(:Codigo,:Organismo,:FechaExp,:Categoria)";
                command.Parameters.Add(new OracleParameter("Codigo", licencia.Codigo));
                command.Parameters.Add(new OracleParameter("Organismo", licencia.Organismo));
                command.Parameters.Add(new OracleParameter("FechaExp", licencia.FechaExp));
                command.Parameters.Add(new OracleParameter("Categoria", licencia.CodCat));
                command.ExecuteNonQuery();
            }
        }
    }
}
