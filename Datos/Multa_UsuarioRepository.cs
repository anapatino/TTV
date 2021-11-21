﻿using System;
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
                        mul.Cedula = reader.GetString(0);
                        mul.Mul_Id = reader.GetString(12);
                        mul.Descripcion = reader.GetString(13);
                        mul.Valor = reader.GetDecimal(14);
                        mul.FechaExpedicion = reader.GetDateTime(15);
                        mul.Estado = reader.GetString(16);
                        mul.Vehiculo_Id = reader.GetString(17);
                        mul.VehiculoNombre = reader.GetString(18);
                        Multa_Usuario multa =new Multa_Usuario(usuario,mul);
                        multas.Add(multa);   
                    }
                }
                reader.Close();
            }
            return multas; ;
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
            return ConsultarMultas().Where(m => m.Multa.FechaExpedicion.Year == fecha).ToList();
        }

        public List<Multa_Usuario> FiltroDescripcion(string descripcion)
        {
            return ConsultarMultas().Where(m => m.Multa.Descripcion.Equals(descripcion)).ToList();
        }

        public List<Multa_Usuario> FiltroEstado(string estado)
        {
            return ConsultarMultas().Where(m => m.Multa.Estado.Equals(estado)).ToList();
        }


    }
}
