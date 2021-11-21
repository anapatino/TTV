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
    public class HistorialPagoMultaRepository
    {
        DbConnection _connection;

        public HistorialPagoMultaRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public List<HistorialPagoMulta> ConsultarPagos()
        {
            List<HistorialPagoMulta> pagos = new List<HistorialPagoMulta>();

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "";
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
                        DateTime fechaPago = reader.GetDateTime(19);
                        HistorialPagoMulta pago = new HistorialPagoMulta(usuario, mul,fechaPago);
                        pagos.Add(pago);
                    }
                }
                reader.Close();
            }
            return pagos; ;
        }

        public HistorialPagoMulta BuscarUsuario(string identificacion)
        {
            return (HistorialPagoMulta)ConsultarPagos().FirstOrDefault(m => m.Usuario.Codigo.Equals(identificacion));
        }

        public List<HistorialPagoMulta> FiltroNombre(string nombre)
        {
            return ConsultarPagos().Where(m => m.Usuario.Pri_nombre.Equals(nombre)).ToList();
        }

        public List<HistorialPagoMulta> FiltroFecha(int fecha)
        {
            return ConsultarPagos().Where(m => m.Multa.FechaExpedicion.Year == fecha).ToList();
        }

        public List<HistorialPagoMulta> FiltroDescripcion(string descripcion)
        {
            return ConsultarPagos().Where(m => m.Multa.Descripcion.Equals(descripcion)).ToList();
        }

        public List<HistorialPagoMulta> FiltroEstado(string estado)
        {
            return ConsultarPagos().Where(m => m.Multa.Estado.Equals(estado)).ToList();
        }

    }
}
