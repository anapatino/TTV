using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;
using System.Data;
using Entidad;
using System.Collections;

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

        public List<string> AñadirCategoria()
        {
            List<string> categorias = new List<string>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT CAT_NOM FROM Categoria";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        categorias.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            return categorias;
        }

        public string PrecioCateoria(string categoria)
        {
            string cat = "";
            using (var command = _connection.CreateCommand())
            {
                
                command.CommandText = "SELECT * FROM Categoria WHERE CAT_NOM = :Categoria";
                command.Parameters.Add(new OracleParameter("Categoria", categoria));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cat = reader.GetString(3);
                    }                 
                }
                reader.Close();
            }
            return cat;
        }

        public string ObtenerCateoria(string categoria)
        {
            string cat = "";
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "SELECT * FROM Categoria WHERE CAT_NOM = :Categoria";
                command.Parameters.Add(new OracleParameter("Categoria", categoria));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cat = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return cat;
        }

        public ArrayList ObtenerDatosLicencia()
        {
            ArrayList lic =new ArrayList();
            using (var command = (OracleCommand)_connection.CreateCommand())
            {
                command.CommandText = "LlenarDiagrama";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("TOTAL_LICENCIAS", OracleDbType.Int32, ParameterDirection.Output);
                command.Parameters.Add("SIN_LICENCIA", OracleDbType.Int32, ParameterDirection.Output);
                command.ExecuteNonQuery();
                lic.Add(command.Parameters["TOTAL_LICENCIAS"]);
                lic.Add(command.Parameters["SIN_LICENCIA"]);
            }
            return lic;
        }
    }
}
