using System;
using Entidad;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioLicenciaService
    {
        Usuario_LicenciaRepository usuarioLicenciaRepository;
        ConnectionManager connectionManager;

        public UsuarioLicenciaService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            usuarioLicenciaRepository = new Usuario_LicenciaRepository(connectionManager.Connection);
        }


        public LicenciaUsuarioConsultaResponse ConsultarLicenciaa()
        {
            try
            {
                connectionManager.Open();
                return new LicenciaUsuarioConsultaResponse(usuarioLicenciaRepository.ConsultarLicencia());
            }
            catch (Exception e)
            {
                return new LicenciaUsuarioConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ModificiarCategoria(string codigoCategoria, string codigoLicencia)
        {
            try
            {
                connectionManager.Open();
                if (usuarioLicenciaRepository.BuscarCodigoLicenciaUsuario(codigoLicencia) == null)
                {
                    return $"No es posible realizar la Modificación de Categoria, la persona con Nro Licencia {codigoLicencia} no existe";
                }
                usuarioLicenciaRepository.ModificarCategoria(codigoCategoria,codigoLicencia);
                return "Se realizó la Modificación Satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Modificar la categoria: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public (string mensaje, Usuario_Licencia usuario) ConsultarPorIdentificacion(string identificacion)
        {
            try
            {
                connectionManager.Open();
                var usuario = usuarioLicenciaRepository.BuscarUsuario(identificacion);
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

        public LicenciaUsuarioConsultaResponse ConsultarPorOrganismo(string organismo)
        {
            try
            {
                connectionManager.Open();
                return new LicenciaUsuarioConsultaResponse(usuarioLicenciaRepository.FiltroOrganismo(organismo));
            }
            catch (Exception e)
            {
                return new LicenciaUsuarioConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }


        public LicenciaUsuarioConsultaResponse ConsultarPorCategoria(string categoria)
        {
            try
            {
                connectionManager.Open();
                return new LicenciaUsuarioConsultaResponse(usuarioLicenciaRepository.FiltroCategoria(categoria));
            }
            catch (Exception e)
            {
                return new LicenciaUsuarioConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public LicenciaUsuarioConsultaResponse ConsultarPorNombre(string nombre)
        {
            try
            {
                connectionManager.Open();
                return new LicenciaUsuarioConsultaResponse(usuarioLicenciaRepository.FiltroNombre(nombre));
            }
            catch (Exception e)
            {
                return new LicenciaUsuarioConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public LicenciaUsuarioConsultaResponse ConsultarPorAnio(int year)
        {
            try
            {
                connectionManager.Open();
                return new LicenciaUsuarioConsultaResponse(usuarioLicenciaRepository.FiltroFecha(year));
            }
            catch (Exception e)
            {
                return new LicenciaUsuarioConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

    }

}
