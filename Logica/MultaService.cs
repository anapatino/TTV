using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class MultaService
    {
        ConnectionManager connectionManager;
        MultaRepository multaRepository;

        public MultaService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            multaRepository = new MultaRepository(connectionManager.Connection);
        }

        public string Guardar(Multa_Usuario multa)
        {
            try
            {
                connectionManager.Open();
                multaRepository.GuardarMulta(multa);
                return "Se guardaron los datos Satisfactoriamente la Multa";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { connectionManager.Close(); }
        }

        public string GuardarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                connectionManager.Open();
                multaRepository.GuardarVehiculo(vehiculo);
                return "Se guardaron los datos Satisfactoriamente del Vehiculo";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { connectionManager.Close(); }
        }

        public ComboxConsultasResponse AñadirMulta()
        {
            try
            {
                connectionManager.Open();
                return new ComboxConsultasResponse(multaRepository.AñadirMulta());
            }
            catch (Exception e)
            {
                return new ComboxConsultasResponse($"Error inesperado al Consultar: {e.Message}");
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerPrecioMulta(string multa)
        {
            try
            {
                connectionManager.Open();
                string cat = multaRepository.ObtenerPrecioMulta(multa);
                return cat;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Eliminar: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerCodigoMulta(string multa)
        {
            try
            {
                connectionManager.Open();
                string cat = multaRepository.ObtenerCodMulta(multa);
                return cat;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Eliminar: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerMultasRegistradas()
        {
            try
            {
                connectionManager.Open();
                string totalMultas = multaRepository.ContarMultasRegistradas();
                return totalMultas;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Contar Multas Registradas: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerSumaMultasPendientes()
        {
            try
            {
                connectionManager.Open();
                string totalMultas = multaRepository.SumarMultasPendientes();
                return totalMultas;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Sumar Multas Registradas: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerSumaMultasPendientesUsuario(string identificacion)
        {
            try
            {
                connectionManager.Open();
                string totalMultas = multaRepository.SumarMultasPendientesUsuario(identificacion);
                return totalMultas;
            }
            catch (Exception e)
            {
                return "Error inesperado al Sumar Multas Registradas de un Usuario";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerMultasPendientes()
        {
            try
            {
                connectionManager.Open();
                string totalMultas = multaRepository.ContarMultasPendientes();
                return totalMultas;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Contar Multas Pendientes: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerMultasPagadas()
        {
            try
            {
                connectionManager.Open();
                string totalMultas = multaRepository.ContarMultasPagadas();
                return totalMultas;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Contar Multas Pagadas: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

    }
}
