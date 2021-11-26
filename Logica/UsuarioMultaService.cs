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

        public string ModificiarEstado(string codigo)
        {
            try
            {
                connectionManager.Open();
                if (usuarioMultaRepository.BuscarCodigoMultaUsuario(codigo) == null)
                {
                    return $"No es posible realizar la Modificación del Pago, la persona con Nro Multa {codigo} no existe";
                }
   
                usuarioMultaRepository.ModificarEstado(codigo);
                return "Se realizó la Modificación Satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Modificar el Pago: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }


        public MultaUsuarioConsultaResponse ConsultarPorIdentificacion(string identificacion)
        {
            try
            {
                connectionManager.Open();
                return new MultaUsuarioConsultaResponse(usuarioMultaRepository.BuscarUsuario(identificacion));
            }
            catch (Exception e)
            {
                return new MultaUsuarioConsultaResponse("Error al Consultar Por Identificacion: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public (string mensaje, Multa_Usuario usuarioMulta) ConsultarPorCodigoMulta(string codigoMulta)
        {
            try
            {
                connectionManager.Open();
                var usuarioMulta = usuarioMultaRepository.BuscarCodigoMultaUsuario(codigoMulta);
                if (usuarioMulta == null)
                {
                    return ("No se encontró un registro con el Nro Multa Solicitada", null);
                }
                return ($"Se encuentra Registrado el Nro Multa {codigoMulta}", usuarioMulta);
            }
            catch (Exception e)
            {
                return ($"Error inesperado al Buscar Nro Multa: {e.Message}", null);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public (string mensaje, Multa_Usuario usuarioMulta) ConsultarPorPlaca(string placa)
        {
            try
            {
                connectionManager.Open();
                var usuarioMulta = usuarioMultaRepository.FiltroPlacaVehiculo(placa);
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

        public MultaUsuarioConsultaResponse ConsultarPorMarca(string marca)
        {
            try
            {
                connectionManager.Open();
                return new MultaUsuarioConsultaResponse(usuarioMultaRepository.FiltroMarcaVehiculo(marca));
            }
            catch (Exception e)
            {
                return new MultaUsuarioConsultaResponse("Error al Consultar Por Marca: " + e.Message);
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
                return new MultaUsuarioConsultaResponse("Error al Consultar Por Nombre: " + e.Message);
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
                return new MultaUsuarioConsultaResponse("Error al Consultar Por Anio: " + e.Message);
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
                return new MultaUsuarioConsultaResponse("Error al Consultar Por Descripcion: " + e.Message);
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
                return new MultaUsuarioConsultaResponse("Error al Consultar Por Estado: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }


    }

}
