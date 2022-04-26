using Datos;
using Entidad;
using System;

namespace Logica
{


    public class UsuarioService
    {
        ConnectionManager connectionManager;
        UsuarioRepository usuarioRepository;

        public UsuarioService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            usuarioRepository = new UsuarioRepository(connectionManager.Connection);
        }

        public string Guardar(Usuario usuario)
        {
            try
            {
                connectionManager.Open();
                usuarioRepository.GuardarUsuario(usuario);
                return "Se guardaron los datos Satisfactoriamente el Usuario";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { connectionManager.Close(); }
        }

        public ComboxConsultasResponse AñadirDepartamento()
        {
            try
            {
                connectionManager.Open();
                return new ComboxConsultasResponse(usuarioRepository.AñadirDepartamento());
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

        public ComboxConsultasResponse AñadirBarrios()
        {
            try
            {
                connectionManager.Open();
                return new ComboxConsultasResponse(usuarioRepository.AñadirBarrio());
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

        public ComboxConsultasResponse AñadirRestricciones()
        {
            try
            {
                connectionManager.Open();
                return new ComboxConsultasResponse(usuarioRepository.AñadirRestriccion());
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

        public ComboxConsultasResponse AñadirCiudades(string departamento)
        {
            try
            {
                connectionManager.Open();
                return new ComboxConsultasResponse(usuarioRepository.AñadirCiudad(departamento));
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

        public string ObtenerCiudad(string ciudad)
        {
            try
            {
                connectionManager.Open();
                string cat = usuarioRepository.ObtenerCiudad(ciudad);
                return cat;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Buscar Ciudad: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerDepartamento(string ciudad)
        {
            try
            {
                connectionManager.Open();
                string dep = usuarioRepository.ObtenerDepartamento(ciudad);
                return dep;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Buscar Departamento: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerBarrio(string barrio)
        {
            try
            {
                connectionManager.Open();
                string cat = usuarioRepository.ObtenerBarrio(barrio);
                return cat;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Buscar Barrio: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ObtenerRestriccion(string res)
        {
            try
            {
                connectionManager.Open();
                string cat = usuarioRepository.ObtenerRestriccion(res);
                return cat;
            }
            catch (Exception e)
            {
                return $"Error inesperado al Buscar Restriccion: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }
    }




}
