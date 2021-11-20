using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class ConnectionManager
    {
        public DbConnection Connection;

        public ConnectionManager(string connectionString)
        {
            Connection = new OracleConnection(connectionString);

        }

        public void Open()
        {
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
