using System;
using Logica;
using Entidad;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica4._7
{
    public partial class FrmHistorialPagoMulta : Form
    {
        HistorialPagoMultaService historialPagoService;

        public FrmHistorialPagoMulta()
        {
            InitializeComponent();
            historialPagoService = new HistorialPagoMultaService(ConfigConnection.ConnectionString);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           ValidarFiltro();
        }


        private void bnLimpiar_Click(object sender, EventArgs e)
        {
           LimpiarComponentes();
        }

        public void LimpiarComponentes()
        {
            dgvTabla.Visible = false;
            bnLimpiar.Visible = false;
            dgvTabla.Rows.Clear();
            cmFiltro.Text = null;
            txtFiltro.Text = null;
        }

        public void ActivarComponentes()
        {
            dgvTabla.Visible = true;
            bnLimpiar.Visible = true;
        }

        public void ValidarFiltro()
        {
            string filtro = cmFiltro.Text;
            if (filtro.Equals("TODOS"))
            {
                VisualizarTodo();
            }
            else if (filtro.Equals("IDENTIFICACION"))
            {
                VisualizarIdentificacion();
            }
            else if (filtro.Equals("NOMBRE"))
            {
                VisualizarNombre();
            }
            else if (filtro.Equals("DESCRIPCION"))
            {
                VisualizarDescripcion();
            }
            else if (filtro.Equals("ESTADO"))
            {
                VisualizarEstado();
            }
            else if (filtro.Equals("ANIO"))
            {
                VisualizarAnio();
            }
        }

        public void VisualizarTodo()
        {
            var respuesta = historialPagoService.ConsultarPagoss();
            VisualizarTabla(respuesta);
        }

        public void VisualizarIdentificacion()
        {
            string identificacion = txtFiltro.Text;
            var (mensaje, personaBuscada) = historialPagoService.ConsultarPorIdentificacion(identificacion);
            if (mensaje.Equals($" Se encuentra Registrado {identificacion}"))
            {
                AgregarRegistroTabla(personaBuscada);
            }
            MessageBox.Show(mensaje);
        }

        public void VisualizarNombre()
        {
            string nombre = txtFiltro.Text;
            var respuesta = historialPagoService.ConsultarPorNombre(nombre);
            VisualizarTabla(respuesta);
        }

        public void VisualizarDescripcion()
        {
            string descripcion = txtFiltro.Text;
            var respuesta = historialPagoService.ConsultarPorDescripcion(descripcion);
            VisualizarTabla(respuesta);
        }

        public void VisualizarEstado()
        {
            string estado = txtFiltro.Text;
            var respuesta = historialPagoService.ConsultarPorEstado(estado);
            VisualizarTabla(respuesta);
        }

        public void VisualizarAnio()
        {
            int fecha = int.Parse(txtFiltro.Text);
            var respuesta = historialPagoService.ConsultarPorAnio(fecha);
            VisualizarTabla(respuesta);
        }

        public void VisualizarTabla(HistorialPagoMultaConsultaResponse respuesta)
        {

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                ActivarComponentes();
                foreach (var i in respuesta.UsuarioMulta)
                {
                    if (i.Estado.Equals("PAGADO"))
                    {
                        dgvTabla.Rows.Add
                         (
                            i.CodigoHistorial,
                            i.Usuario.Codigo,
                            i.Usuario.Pri_nombre,
                            i.Usuario.Pri_apellido,
                            i.CodigoMultaUsuario,
                            i.Multa.Descripcion,
                            i.Multa.Valor,
                            i.VehiculoId,
                            i.VehiculoNombre,
                            i.Estado,
                            i.FechaPago
                         );
                    }
                    
                }
            }
        }

        public void AgregarRegistroTabla(HistorialPagoMulta i)
        {
            ActivarComponentes();
            if (i.Estado.Equals("PAGADO"))
            {
                dgvTabla.Rows.Add
                 (
                    i.CodigoHistorial,
                    i.Usuario.Codigo,
                    i.Usuario.Pri_nombre,
                    i.Usuario.Pri_apellido,
                    i.CodigoMultaUsuario,
                    i.Multa.Descripcion,
                    i.Multa.Valor,
                    i.VehiculoId,
                    i.VehiculoNombre,
                    i.Estado,
                    i.FechaPago
                 );
            }
        }


    }
}
