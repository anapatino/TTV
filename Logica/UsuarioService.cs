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

    }




}
