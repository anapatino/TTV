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
                command.CommandText = "CALL PK1INSERTAR.REGISTRAR_MULTA(:CodigoMulta,:Cedula,:IdMulta,:Estado,:FechaExp,:VehiculoId);";
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
                command.CommandText = "INSERT INTO VEHICULO VALUES(:Placa,:Marca);";
                command.Parameters.Add(new OracleParameter("Placa", vehiculo.Placa));
                command.Parameters.Add(new OracleParameter("Marca", vehiculo.Marca));
                command.ExecuteNonQuery();
            }
        }
    }
}
