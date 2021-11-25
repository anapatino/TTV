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
                command.CommandText = "SELECT U.usu_cod_pk,U.pri_nombre,U.SEGUN_NOMBRE,U.PRI_APELLIDO,U.SEGUN_APELLIDO,U.USU_FECHANACIMIENTO,U.USU_TELEFONO,U.USU_GRUPOSANGUINEO,U.LI_CODIGO_FK,C.CIUD_NOMBRE,B.BARR_NOMBRE,R.RES_DESCRIPCION,M.MUL_ID_PK,M.MUL_DESCRIPCION,M.MUL_VALOR,T.HIST_COD_PK,T.CODIGO_MUL_USU,T.FECHAPAGO,T.ESTADO,V.VEH_ID_PK,V.VEH_NOMBRE FROM HISTORIALPAGOMULTA T JOIN USUARIO U ON(T.USU_COD_FK = U.USU_COD_PK) JOIN MULTA M ON(T.MUL_ID_FK = M.MUL_ID_PK) JOIN BARRIO B ON(U.BARR_CODIGO_FK= B.BARR_CODIGO_PK) JOIN CIUDAD C ON(U.CIUD_CODIGO_FK = C.CIUD_CODIGO_PK) JOIN RESTRICCION R ON(R.RES_COD_PK= U.RES_COD_FK) JOIN VEHICULO V ON(T.VEH_ID_FK= V.VEH_ID_PK)";

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
                        string codigo = reader.GetString(15);
                        string codigoMultaUsuario = reader.GetString(16);
                        DateTime fechaPago = reader.GetDateTime(17);
                        string estado = reader.GetString(18);
                        string idVehiculo = reader.GetString(19);
                        string nombreVehiculo = reader.GetString(20);
                        HistorialPagoMulta pago = new HistorialPagoMulta(usuario, mul, codigo, codigoMultaUsuario, idVehiculo,  nombreVehiculo, estado, fechaPago);
                        pagos.Add(pago);
                    }
                }
                reader.Close();
            }
            return pagos; ;
        }

        public List<HistorialPagoMulta> BuscarUsuario(string identificacion)
        {
            return ConsultarPagos().Where(m => m.Usuario.Codigo.Equals(identificacion)).ToList();
        }

        public HistorialPagoMulta BuscarCodigoMultaUsuario(string codigo)
        {
            return (HistorialPagoMulta) ConsultarPagos().FirstOrDefault(m => m.CodigoMultaUsuario.Equals(codigo));
        }

        public HistorialPagoMulta BuscarCodigoHistorial(string codigo)
        {
            return (HistorialPagoMulta) ConsultarPagos().FirstOrDefault(m => m.CodigoHistorial.Equals(codigo));
        }

        public List<HistorialPagoMulta> FiltroNombre(string nombre)
        {
            return (from m in ConsultarPagos()
                    where m.Usuario.Pri_nombre.ToLower().Contains(nombre.ToLower())
                    select m).ToList();
        }

        public List<HistorialPagoMulta> FiltroFecha(int fecha)
        {
            return ConsultarPagos().Where(m => m.FechaPago.Year == fecha).ToList();
        }

        public List<HistorialPagoMulta> FiltroDescripcion(string descripcion)
        {
            return (from m in ConsultarPagos()
                    where m.Multa.Descripcion.ToLower().Contains(descripcion.ToLower())
                    select m).ToList();
        }

        public List<HistorialPagoMulta> FiltroEstado(string estado)
        {
            return ConsultarPagos().Where(m => m.Estado.Equals(estado)).ToList();
        }

        public HistorialPagoMulta FiltroPlacaVehiculo(string placa)
        {
            return (HistorialPagoMulta) ConsultarPagos().FirstOrDefault(m => m.VehiculoId.Equals(placa));
        }

        public List<HistorialPagoMulta> FiltroMarcaVehiculo(string marca)
        {
            return  ConsultarPagos().Where(m => m.VehiculoNombre.Equals(marca)).ToList();
        }
    }
}
