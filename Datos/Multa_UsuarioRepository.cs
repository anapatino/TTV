﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
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
                command.CommandText = "SELECT U.usu_cod_pk,U.pri_nombre,U.SEGUN_NOMBRE,U.PRI_APELLIDO,U.SEGUN_APELLIDO,U.USU_FECHANACIMIENTO,U.USU_TELEFONO,U.USU_GRUPOSANGUINEO,U.LI_CODIGO_FK,C.CIUD_NOMBRE,B.BARR_NOMBRE,R.RES_DESCRIPCION,M.MUL_ID_PK,M.MUL_DESCRIPCION,M.MUL_VALOR,T.CODIGO_MUL_USU,T.fecha_expedicion,T.estado,V.VEH_ID_PK,V.VEH_NOMBRE FROM MULTA_USUARIO T JOIN USUARIO U ON(T.USU_COD_FK = U.USU_COD_PK) JOIN MULTA M ON(T.MUL_ID_FK = M.MUL_ID_PK) JOIN BARRIO B ON(U.BARR_CODIGO_FK= B.BARR_CODIGO_PK) JOIN CIUDAD C ON(U.CIUD_CODIGO_FK = C.CIUD_CODIGO_PK) JOIN RESTRICCION R ON(R.RES_COD_PK= U.RES_COD_FK) JOIN VEHICULO V ON(T.VEH_ID_FK= V.VEH_ID_PK)";

                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Multa mul = new Multa();
                        Usuario usuario = new Usuario();
                        usuario.Codigo = reader.GetString(0);
                        usuario.Pri_nombre = reader.GetString(1);
                        usuario.Seg_nombre = reader.GetString(2);
                        usuario.Pri_apellido = reader.GetString(3);
                        usuario.Seg_apellido = reader.GetString(4);
                        usuario.FechaNacimiento = reader.GetDateTime(5);
                        usuario.Telefono = reader.GetString(6);
                        usuario.Grupo_Sanguineo = reader.GetString(7);
                        usuario.LicenciaCodigo = reader.GetString(8);
                        usuario.CiudadCodigo = reader.GetString(9);
                        usuario.BarrioCodigo = reader.GetString(10);
                        usuario.RestriccionCodigo = reader.GetString(11);
                        mul.Mul_Id = reader.GetString(12);
                        mul.Descripcion = reader.GetString(13);
                        mul.Valor = reader.GetDecimal(14);
                        string codigoMultaUsuario = reader.GetString(15);
                        DateTime fechaExpedicion = reader.GetDateTime(16);
                        string estado = reader.GetString(17);
                        string vehiculoId = reader.GetString(18);
                        string vehiculoNombre = reader.GetString(19);
                        Multa_Usuario multa =new Multa_Usuario(usuario,mul, codigoMultaUsuario, vehiculoId, vehiculoNombre, estado, fechaExpedicion);
                        multas.Add(multa);   
                    }
                }
                reader.Close();
            }
            return multas; ;
        }

        public  void ModificarEstado(string codigoMultaUsuario)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update multa_usuario set ESTADO='PAGADO' where CODIGO_MUL_USU=:codigoMultaUsuario";
                command.Parameters.Add(new OracleParameter("codigoMultaUsuario", codigoMultaUsuario));
                int fila = command.ExecuteNonQuery();
            }
        }

        public Multa_Usuario BuscarCodigoMultaUsuario(string codigo)
        {
            return (Multa_Usuario)ConsultarMultas().FirstOrDefault(m => m.CodigoMultaUsuario.Equals(codigo));
        }

        public Multa_Usuario BuscarUsuario(string identificacion)
        {
            return (Multa_Usuario)ConsultarMultas().FirstOrDefault(m => m.Usuario.Codigo.Equals(identificacion));
        }

        public List<Multa_Usuario> FiltroNombre(string nombre)
        {
            return ConsultarMultas().Where(m => m.Usuario.Pri_nombre.Equals(nombre)).ToList();
        }

        public List<Multa_Usuario> FiltroFecha(int fecha)
        {
            return ConsultarMultas().Where(m => m.FechaExpedicion.Year == fecha).ToList();
        }

        public List<Multa_Usuario> FiltroDescripcion(string descripcion)
        {
            return ConsultarMultas().Where(m => m.Multa.Descripcion.Equals(descripcion)).ToList();
        }

        public List<Multa_Usuario> FiltroEstado(string estado)
        {
            return ConsultarMultas().Where(m => m.Estado.Equals(estado)).ToList();
        }

    }
}
