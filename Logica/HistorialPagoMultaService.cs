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


        public HistorialPagoMultaConsultaResponse ConsultarPorIdentificacion(string identificacion)
        {
            try
            {
                connectionManager.Open();
                return new HistorialPagoMultaConsultaResponse(historialPagoRepository.BuscarUsuario(identificacion));
            }
            catch (Exception e)
            {
                return new HistorialPagoMultaConsultaResponse($"Error inesperado al Buscar: {e.Message}");
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public (string mensaje, HistorialPagoMulta usuarioMulta) ConsultarPorPlaca(string placa)
        {
            try
            {
                connectionManager.Open();
                var usuarioMulta = historialPagoRepository.FiltroPlacaVehiculo(placa);
                if (usuarioMulta == null)
                {
                    return ("No se encontró un registro con la placa  Solicitada", null);
                }
                return ($" Se encuentra Registrado la placa {placa}", usuarioMulta);
            }
            catch (Exception e)
            {
                return ($"Error al Buscar Placa : {e.Message}", null);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public (string mensaje, HistorialPagoMulta usuarioMulta) ConsultarCodigoHistorial(string codigo)
        {
            try
            {
                connectionManager.Open();
                var usuarioMulta = historialPagoRepository.BuscarCodigoHistorial(codigo);
                if (usuarioMulta == null)
                {
                    return ("No se encontró un registro con el codigo  Solicitada", null);
                }
                return ($"Se encuentra Registrado el codigo {codigo}", usuarioMulta);
            }
            catch (Exception e)
            {
                return ($"Error al Buscar el codigo: {e.Message}", null);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public (string mensaje, HistorialPagoMulta usuarioMulta) ConsultarCodigoMultaUsuario(string codigo)
        {
            try
            {
                connectionManager.Open();
                var usuarioMulta = historialPagoRepository.BuscarCodigoMultaUsuario(codigo);
                if (usuarioMulta == null)
                {
                    return ("No se encontró un registro con el codigo multa Solicitada", null);
                }
                return ($"Se encuentra Registrado el codigo de la multa {codigo}", usuarioMulta);
            }
            catch (Exception e)
            {
                return ($"Error al Buscar el codigo de la multa: {e.Message}", null);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public HistorialPagoMultaConsultaResponse ConsultarPorMarcaVehiculo(string marca)
        {
            try
            {
                connectionManager.Open();
                return new HistorialPagoMultaConsultaResponse(historialPagoRepository.FiltroMarcaVehiculo(marca));
            }
            catch (Exception e)
            {
                return new HistorialPagoMultaConsultaResponse($"Error inesperado al Buscar: {e.Message}");
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
