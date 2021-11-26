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
    public class CuentaRepository
    {
        DbConnection _connection;

        public CuentaRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public Cuenta VerificarIngreso(string usuario,string password)
        {
            Cuenta cuenta = null;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT *FROM CUENTA WHERE usuario=:usuario AND password=:password";
                command.Parameters.Add(new OracleParameter("usuario",usuario));
                command.Parameters.Add(new OracleParameter("password",password));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        cuenta = new Cuenta();
                        cuenta.Codigo = reader.GetString(0);
                        cuenta.NombreUsuario = reader.GetString(1);
                        cuenta.Usuario = reader.GetString(2);
                        cuenta.Password = reader.GetString(3);
                    }
                }             
            }
            return cuenta;
        }
    }
}
