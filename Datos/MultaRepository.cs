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
    public class MultaRepository
    {
        DbConnection _connection;

        public MultaRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public void GuardarUsuario(Multa multa)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "CALL PK1INSERTAR.REGISTRAR_MULTA(:Cedula,:MultaId,:Estado,:FechaExp,:VehiculoId);";
                command.Parameters.Add(new OracleParameter("Cedula", multa.Cedula));
                command.Parameters.Add(new OracleParameter("MultaId", multa.Mul_Id));
                command.Parameters.Add(new OracleParameter("Estado", multa.Estado));
                command.Parameters.Add(new OracleParameter("FechaExp", multa.FechaExpedicion));
                command.Parameters.Add(new OracleParameter("VehiculoId", multa.Vehiculo_Id));
                command.ExecuteNonQuery();
            }
        }
    }
}
