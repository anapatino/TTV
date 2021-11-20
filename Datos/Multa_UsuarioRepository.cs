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
    public class Multa_UsuarioRepository
    {
        DbConnection _connection;

        public Multa_UsuarioRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public List<Multa_Usuario> ConsultarMultas()
        {
            List<Multa_Usuario> multas = new List<Multa_Usuario>();

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = " SELECT M.MUL_ID_PK,M.MUL_DESCRIPCION,U.usu_cod_pk,U.pri_nombre,U.PRI_APELLIDO,M.MUL_VALOR,T.fecha_expedicion,T.estado FROM MULTA_USUARIO T JOIN USUARIO U ON(T.USU_COD_FK = U.USU_COD_PK) JOIN MULTA M ON(T.MUL_ID_FK = M.MUL_ID_PK)";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Multa_Usuario multa = new Multa_Usuario();
                        multa.CodigoMulta = reader.GetString(0);
                        multa.Multa_descripcion = reader.GetString(1);
                        multa.Cedula = reader.GetString(2);
                        multa.Pri_nombre = reader.GetString(3);
                        multa.Pri_Apellido = reader.GetString(4);
                        multa.ValorMulta = reader.GetDecimal(5);
                        multa.Fecha_expedicion = reader.GetDateTime(6);
                        multa.Estado = reader.GetString(7);
                        multas.Add(multa);   
                    }
                }
                reader.Close();
            }
            return multas; ;
        }

        public Multa_Usuario BuscarUsuario(string identificacion)
        {
            return (Multa_Usuario)ConsultarMultas().FirstOrDefault(m => m.Cedula.Equals(identificacion));
        }

        public List<Multa_Usuario> FiltroNombre(string nombre)
        {
            return ConsultarMultas().Where(m => m.Pri_nombre.Equals(nombre)).ToList();
        }

        public List<Multa_Usuario> FiltroFecha(int fecha)
        {
            return ConsultarMultas().Where(m => m.Fecha_expedicion.Year == fecha).ToList();
        }

        public List<Multa_Usuario> FiltroDescripcion(string descripcion)
        {
            return ConsultarMultas().Where(m => m.Multa_descripcion.Equals(descripcion)).ToList();
        }

        public List<Multa_Usuario> FiltroEstado(string estado)
        {
            return ConsultarMultas().Where(m => m.Estado.Equals(estado)).ToList();
        }


    }
}
