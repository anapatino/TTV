using System;
using Entidad;
using Logica;
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
    public partial class FrmPagoMulta : Form
    {
        UsuarioMultaService usuarioPagoMultaService;

        public FrmPagoMulta()
        {
            InitializeComponent();
            usuarioPagoMultaService = new UsuarioMultaService(ConfigConnection.ConnectionString);
        }

 
        public void LimpiarComponentes()
        {
            dgvTabla.Visible = false;
            dgvTabla.Rows.Clear();
            cmFiltro.Text = null;
            txtFiltro.Text = null;
            lbValor.Visible = false;
            txtCodigoMultaPagar.Visible = false;
            txtCodigoMultaPagar.Text = null;
            bnLimpiar.Visible = false;
            btnPagar.Visible = false;
        }

        public void ActivarComponentes()
        {
            dgvTabla.Visible = true;
            lbValor.Visible = true;
            txtCodigoMultaPagar.Visible = true;
            bnLimpiar.Visible = true;
            btnPagar.Visible = true;
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
            var respuesta = usuarioPagoMultaService.ConsultarMultaa();
            VisualizarTabla(respuesta);
        }

        public void VisualizarIdentificacion()
        {
            string identificacion = txtFiltro.Text;
            var (mensaje, personaBuscada) = usuarioPagoMultaService.ConsultarPorIdentificacion(identificacion);
            if (mensaje.Equals($" Se encuentra Registrado {identificacion}"))
            {
                AgregarRegistroTabla(personaBuscada);
            }
            MessageBox.Show(mensaje);
        }

        public void VisualizarNombre()
        {
            string nombre = txtFiltro.Text;
            var respuesta = usuarioPagoMultaService.ConsultarPorNombre(nombre);
            VisualizarTabla(respuesta);
        }

        public void VisualizarDescripcion()
        {
            string descripcion = txtFiltro.Text;
            var respuesta = usuarioPagoMultaService.ConsultarPorDescripcion(descripcion);
            VisualizarTabla(respuesta);
        }

        public void VisualizarEstado()
        {
            string estado = txtFiltro.Text;
            var respuesta = usuarioPagoMultaService.ConsultarPorEstado(estado);
            VisualizarTabla(respuesta);
        }

        public void VisualizarAnio()
        {
            int fecha = int.Parse(txtFiltro.Text);
            var respuesta = usuarioPagoMultaService.ConsultarPorAnio(fecha);
            VisualizarTabla(respuesta);
        }

        public void VisualizarTabla(MultaUsuarioConsultaResponse respuesta)
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
                    dgvTabla.Rows.Add
                    (
                      i.CodigoMultaUsuario,
                      i.Multa.Descripcion,
                      i.Vehiculo_Id,
                      i.VehiculoNombre,
                      i.Usuario.Codigo,
                      i.Usuario.Pri_nombre,
                      i.Usuario.Pri_apellido,
                      i.Multa.Valor,
                      i.FechaExpedicion,
                      i.Estado
                    );
                }
            }
        }

        public void AgregarRegistroTabla(Multa_Usuario i)
        {
            ActivarComponentes();
            dgvTabla.Rows.Add
                    (
                      i.CodigoMultaUsuario,
                      i.Multa.Descripcion,
                      i.Vehiculo_Id,
                      i.VehiculoNombre,
                      i.Usuario.Codigo,
                      i.Usuario.Pri_nombre,
                      i.Usuario.Pri_apellido,
                      i.Multa.Valor,
                      i.FechaExpedicion,
                      i.Estado
                    );

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           ValidarFiltro();
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            PagarMulta();
        }

        public void PagarMulta()
        {
            string codigoMulta = txtCodigoMultaPagar.Text;
            var respuesta = usuarioPagoMultaService.ModificiarEstado(codigoMulta);
            MessageBox.Show(respuesta);
        }
    }
}
