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

        public List<string> AñadirDepartamento()
        {
            List<string> departamentos = new List<string>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT DEP_NOMBRE FROM Departamento";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                   departamentos.Add(reader.GetString(0));
                }
                reader.Close();
            }
            return departamentos;
        }

        public List<string> AñadirBarrio()
        {
            List<string> barrios = new List<string>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT BARR_NOMBRE FROM Barrio";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        barrios.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            return barrios;
        }

        public List<string> AñadirRestriccion()
        {
            List<string> restricciones = new List<string>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT RES_DESCRIPCION FROM Restriccion";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        restricciones.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            return restricciones;
        }

        public List<string> AñadirCiudad(string departamento)
        {
            List<string> ciudades = new List<string>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT D.dep_nombre, C.ciud_nombre FROM Ciudad C LEFT JOIN DEPARTAMENTO D ON(C.DEP_CODIGO_FK = D.DEP_CODIGO_PK) WHERE D.dep_nombre = :Departamento";
                command.Parameters.Add(new OracleParameter("Departamento", departamento));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ciudades.Add(reader.GetString(1));
                    }
                }
                reader.Close();
            }
            return ciudades;
        }

        public string ObtenerCiudad(string ciudad)
        {
            string ciud = "";
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "SELECT * FROM Ciudad WHERE CIUD_NOMBRE = :Ciudad";
                command.Parameters.Add(new OracleParameter("Ciudad", ciudad));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ciud = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return ciud;
        }

        public string ObtenerBarrio(string barrio)
        {
            string barr = "";
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "SELECT * FROM Barrio WHERE BARR_NOMBRE = :Barrio";
                command.Parameters.Add(new OracleParameter("Barrio", barrio));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        barr = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return barr;
        }

        public string ObtenerRestriccion(string restriccion)
        {
            string res = "";
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "SELECT * FROM Restriccion WHERE RES_DESCRIPCION = :Rescripcion";
                command.Parameters.Add(new OracleParameter("Restriccion", restriccion));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        res = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            return res;
        }

    }
}
