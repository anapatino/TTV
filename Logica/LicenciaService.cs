using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class LicenciaService
    {
        ConnectionManager connectionManager;
        LicenciaRepository licenciaRepository;

        public LicenciaService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            licenciaRepository = new LicenciaRepository(connectionManager.Connection);
        }

        public string Guardar(Licencia licencia)
        {
            try
            {
                connectionManager.Open();
                licenciaRepository.GuardarLicencia(licencia);
                return "Se guardaron los datos Satisfactoriamente la Licencia";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { connectionManager.Close(); }
        }

        public ComboxConsultasResponse AñadirCategorias()
        {
            try
            {
                connectionManager.Open();
                return new ComboxConsultasResponse(licenciaRepository.AñadirCategoria());
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

        public string ObtenerPrecio(string categoria)
        {
            try
            {
                connectionManager.Open();
                string cat = licenciaRepository.PrecioCateoria(categoria);
                return cat;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Buscar: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerCategoria(string categoria)
        {
            try
            {
                connectionManager.Open();
                string cat = licenciaRepository.ObtenerCateoria(categoria);
                return cat;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Buscar: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public (string ,ArrayList) ObtenerDatosLicencia()
        {
            try
            {
                connectionManager.Open();
                var lic = licenciaRepository.ObtenerDatosLicencia();
                return ("ArrayList Con Datos",lic);
            }
            catch (Exception e)
            {
                return ($"Error inesperado al Buscar: {e.Message}",null);
            }
            finally
            {
                connectionManager.Close();
            }
        }
    }
}
