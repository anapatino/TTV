using System;
using Entidad;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioMultaService
    {
        Multa_UsuarioRepository usuarioMultaRepository;
        ConnectionManager connectionManager;

        public UsuarioMultaService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            usuarioMultaRepository = new Multa_UsuarioRepository(connectionManager.Connection);
        }


        public MultaUsuarioConsultaResponse ConsultarMultaa()
        {
            try
            {
                connectionManager.Open();
                return new MultaUsuarioConsultaResponse(usuarioMultaRepository.ConsultarMultas());
            }
            catch (Exception e)
            {
                return new MultaUsuarioConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            finally
            {
                connectionManager.Close();
            }
        }


        public (string mensaje, Multa_Usuario usuario) ConsultarPorIdentificacion(string identificacion)
        {
            try
            {
                connectionManager.Open();
                var usuario = usuarioMultaRepository.BuscarUsuario(identificacion);
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

        public MultaUsuarioConsultaResponse ConsultarPorNombre(string nombre)
        {
            try
            {
                connectionManager.Open();
                return new MultaUsuarioConsultaResponse(usuarioMultaRepository.FiltroNombre(nombre));
            }
            catch (Exception e)
            {
                return new MultaUsuarioConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public MultaUsuarioConsultaResponse ConsultarPorAnio(int year)
        {
            try
            {
                connectionManager.Open();
                return new MultaUsuarioConsultaResponse(usuarioMultaRepository.FiltroFecha(year));
            }
            catch (Exception e)
            {
                return new MultaUsuarioConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public MultaUsuarioConsultaResponse ConsultarPorDescripcion(string descripcion)
        {
            try
            {
                connectionManager.Open();
                return new MultaUsuarioConsultaResponse(usuarioMultaRepository.FiltroDescripcion(descripcion));
            }
            catch (Exception e)
            {
                return new MultaUsuarioConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public MultaUsuarioConsultaResponse ConsultarPorEstado(string estado)
        {
            try
            {
                connectionManager.Open();
                return new MultaUsuarioConsultaResponse(usuarioMultaRepository.FiltroEstado(estado));
            }
            catch (Exception e)
            {
                return new MultaUsuarioConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }


    }

}
