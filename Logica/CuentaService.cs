using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class CuentaService
    {
        ConnectionManager connectionManager;
        CuentaRepository cuentaRepository;

        public CuentaService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            cuentaRepository = new CuentaRepository(connectionManager.Connection);
        }

        public (string mensaje, Cuenta usuario) VerificarCuenta(string usuario,string password)
        {
            try
            {
                connectionManager.Open();
                var usuarioEncontrado = cuentaRepository.VerificarIngreso(usuario,password);
                if (usuarioEncontrado == null)
                {
                    return ("Usuario y/o Password Ingresados Incorrectamente", null);
                }
                return ("Iniciar Seccion", usuarioEncontrado);
            }
            catch (Exception e)
            {
                return ($"Error inesperado al Buscar Usuario y/o Password: {e.Message}", null);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public (string mensaje, Cuenta usuario) RecuperarCuenta(string usuario)
        {
            try
            {
                connectionManager.Open();
                var usuarioEncontrado = cuentaRepository.VerificarIngresoCuenta(usuario);
                if (usuarioEncontrado == null)
                {
                    return ("Usuario Ingresados Incorrectamente", null);
                }
                return ("Usuario Registrado", usuarioEncontrado);
            }
            catch (Exception e)
            {
                return ($"Error inesperado al Buscar Usuario: {e.Message}", null);
            }
            finally
            {
                connectionManager.Close();
            }
        }
    }
}
