using System;
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
    }
}
