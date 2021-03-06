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

        public void GuardarMulta(Multa_Usuario multa)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "CALL PK1INSERTAR.REGISTRAR_MULTA(:CodigoMulta,:Cedula,:IdMulta,:Estado,:FechaExp,:VehiculoId)";
                command.Parameters.Add(new OracleParameter("CodigoMulta", multa.CodigoMultaUsuario));
                command.Parameters.Add(new OracleParameter("Cedula", multa.Usuario.Codigo));
                command.Parameters.Add(new OracleParameter("IdMulta", multa.Multa.Mul_Id));
                command.Parameters.Add(new OracleParameter("Estado", multa.Estado));
                command.Parameters.Add(new OracleParameter("FechaExp", multa.FechaExpedicion));
                command.Parameters.Add(new OracleParameter("VehiculoId", multa.Vehiculo_Id));
                command.ExecuteNonQuery();
            }
        }

        public void GuardarVehiculo(Vehiculo vehiculo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO VEHICULO VALUES(:Placa,:Marca)";
                command.Parameters.Add(new OracleParameter("Placa", vehiculo.Placa));
                command.Parameters.Add(new OracleParameter("Marca", vehiculo.Marca));
                command.ExecuteNonQuery();
            }
        }

        public List<string> AñadirMulta()
        {
            List<string> multas = new List<string>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Multa";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    multas.Add(reader.GetString(1));
                }
                reader.Close();
            }
            return multas;
        }

        public string ObtenerPrecioMulta(string multa)
        {
            string mul = "";
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "SELECT * FROM Multa WHERE MUL_DESCRIPCION = :Descripcion";
                command.Parameters.Add(new OracleParameter("Descripcion", multa));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mul = reader.GetString(2);
                    }
                }
                reader.Close();
            }
            return mul;
        }

        public string ObtenerCodMulta(string multa)
        {
            string mul = "";
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "SELECT * FROM Multa WHERE MUL_DESCRIPCION = :Descripcion";
                command.Parameters.Add(new OracleParameter("Descripcion", multa));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mul = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return mul;
        }

        public string ContarMultasRegistradas()
        {
            string mul = "";
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) AS TOTAL_MULTAS_REGISTRADAS FROM MULTA_USUARIO";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mul = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return mul;
        }

        public string SumarMultasPendientes()
        {
            string mul = "";
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT SUM(M.mul_valor) FROM MULTA_USUARIO MU JOIN MULTA M ON (MU.mul_id_fk=M.mul_id_pk) WHERE MU.estado='PENDIENTE'";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mul = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return mul;
        }

        public string SumarMultasPendientesUsuario(string identificacion)
        {
            string mul = "";
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT SUM(M.mul_valor) FROM MULTA_USUARIO MU JOIN MULTA M ON (MU.mul_id_fk=M.mul_id_pk) WHERE MU.estado='PENDIENTE' AND MU.usu_cod_fk=:identificacion";
                command.Parameters.Add(new OracleParameter("identificacion", identificacion));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mul = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return mul;
        }

        public string ContarMultasPagadas()
        {
            string mul = "";
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) AS TOTAL_MULTAS_PAGADAS FROM HISTORIALPAGOMULTA";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mul = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return mul;
        }

        public string ContarMultasPendientes()
        {
            string mul = "";
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) AS TOTAL_MULTAS_PENDIENTES FROM MULTA_USUARIO WHERE ESTADO='PENDIENTE'";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mul = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return mul;
        }

    }
}
