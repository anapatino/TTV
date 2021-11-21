using System;
using Entidad;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class HistorialPagoMultaService
    {
        HistorialPagoMultaRepository historialPagoRepository;
        ConnectionManager connectionManager;

        public HistorialPagoMultaService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            historialPagoRepository = new HistorialPagoMultaRepository(connectionManager.Connection);
        }


        public HistorialPagoMultaConsultaResponse ConsultarPagoss()
        {
            try
            {
                connectionManager.Open();
                return new HistorialPagoMultaConsultaResponse(historialPagoRepository.ConsultarPagos());
            }
            catch (Exception e)
            {
                return new HistorialPagoMultaConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            finally
            {
                connectionManager.Close();
            }
        }


        public (string mensaje, HistorialPagoMulta usuario) ConsultarPorIdentificacion(string identificacion)
        {
            try
            {
                connectionManager.Open();
                var usuario = historialPagoRepository.BuscarUsuario(identificacion);
                if (usuario == null)
                {
                    return ("No se encontró un registro con la identificacion Solicitada", usuario);
                }
                return ($" Se encuentra Registrado {identificacion}", usuario);
            }
            catch (Exception e)
            {
                return ($"Error inesperado al Buscar: {e.Message}", null);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public HistorialPagoMultaConsultaResponse ConsultarPorNombre(string nombre)
        {
            try
            {
                connectionManager.Open();
                return new HistorialPagoMultaConsultaResponse(historialPagoRepository.FiltroNombre(nombre));
            }
            catch (Exception e)
            {
                return new HistorialPagoMultaConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public HistorialPagoMultaConsultaResponse ConsultarPorAnio(int year)
        {
            try
            {
                connectionManager.Open();
                return new HistorialPagoMultaConsultaResponse(historialPagoRepository.FiltroFecha(year));
            }
            catch (Exception e)
            {
                return new HistorialPagoMultaConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public HistorialPagoMultaConsultaResponse ConsultarPorDescripcion(string descripcion)
        {
            try
            {
                connectionManager.Open();
                return new HistorialPagoMultaConsultaResponse(historialPagoRepository.FiltroDescripcion(descripcion));
            }
            catch (Exception e)
            {
                return new HistorialPagoMultaConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public HistorialPagoMultaConsultaResponse ConsultarPorEstado(string estado)
        {
            try
            {
                connectionManager.Open();
                return new HistorialPagoMultaConsultaResponse(historialPagoRepository.FiltroEstado(estado));
            }
            catch (Exception e)
            {
                return new HistorialPagoMultaConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }


    }

}
