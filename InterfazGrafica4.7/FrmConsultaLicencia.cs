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

    public partial class FrmConsultaLicencia : Form
    {
        UsuarioLicenciaService usuarioLicenciaService;

        public FrmConsultaLicencia()
        {
            InitializeComponent();
            usuarioLicenciaService = new UsuarioLicenciaService(ConfigConnection.ConnectionString);
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ValidarFiltro();
        }

        public void ValidarFiltro()
        {
            string filtro = cmFiltro.Text;
            if (filtro.Equals("TODO"))
            {
                VisualizarTodo();
            }
            else if (filtro.Equals("CEDULA"))
            {
                VisualizarCedula();
            }
            else if (filtro.Equals("ORGANISMO"))
            {
                VisualizarOrganismo();
            }
            else
            {
                ValidarFiltroExtenso(filtro);
            }
        }

        public void ValidarFiltroExtenso(string filtro)
        {
            if (filtro.Equals("CATEGORIA"))
            {
                VisualizarCategoria();
            }
            else if (filtro.Equals("NOMBRE"))
            {
                VisualizarNombre();
            }
            else if (filtro.Equals("FECHA"))
            {
                VisualizarFecha();
            }
            else
            {
                VisualizarCodigoLicencia();
            }
        }

        public void VisualizarTodo()
        {
            var respuesta = usuarioLicenciaService.ConsultarLicenciaa();
            VisualizarTabla(respuesta);
        }

        public void VisualizarCedula()
        {
            string identificacion = txtFiltro.Text;
            var (mensaje, personaBuscada) = usuarioLicenciaService.ConsultarPorIdentificacion(identificacion);
            if (mensaje.Equals($" Se encuentra Registrado {identificacion}"))
            {
                AgregarRegistroTabla(personaBuscada);
            }
            MessageBox.Show(mensaje);
        }

        public void VisualizarOrganismo()
        {
            string organismo= txtFiltro.Text;
            var respuesta = usuarioLicenciaService.ConsultarPorOrganismo(organismo);
            VisualizarTabla(respuesta);
        }

        public void VisualizarCategoria()
        {
            string categoria = txtFiltro.Text;
            var respuesta = usuarioLicenciaService.ConsultarPorCategoria(categoria);
            VisualizarTabla(respuesta);
        }
        
        public void VisualizarNombre()
        {
            string nombre = txtFiltro.Text;
            var respuesta = usuarioLicenciaService.ConsultarPorNombre(nombre);
            VisualizarTabla(respuesta);
        }

        public void VisualizarFecha()
        {
            int fecha = int.Parse(txtFiltro.Text);
            var respuesta = usuarioLicenciaService.ConsultarPorAnio(fecha);
            VisualizarTabla(respuesta);
        }

        public void VisualizarCodigoLicencia()
        {
            string codigo= txtFiltro.Text;
            var (mensaje, licenciaBuscada) = usuarioLicenciaService.ConsultarPorCodigoLicencia(codigo);
            if (mensaje.Equals($"Se encuentra Registrado la Licencia con Nro {codigo}"))
            {
                AgregarRegistroTabla(licenciaBuscada);
            }
            MessageBox.Show(mensaje);
        }

        public void VisualizarTabla(LicenciaUsuarioConsultaResponse respuesta)
        {
  
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                ActivarComponentes();
                foreach (var i in respuesta.UsuarioLicencia)
                {
                    dgvTabla.Rows.Add
                    (
                      i.Licencia.Codigo,
                      i.Usuario.Codigo,
                      i.Usuario.Pri_nombre,
                      i.Usuario.Pri_apellido,
                      i.Usuario.Grupo_Sanguineo,
                      i.Licencia.Organismo,
                      i.Licencia.CodCat,
                      i.Licencia.FechaExp
                    );
                }
            }
        }

        public void AgregarRegistroTabla(Usuario_Licencia i)
        {
            ActivarComponentes();
            dgvTabla.Rows.Add
                    (
                      i.Licencia.Codigo,
                      i.Usuario.Codigo,
                      i.Usuario.Pri_nombre,
                      i.Usuario.Pri_apellido,
                      i.Usuario.Grupo_Sanguineo,
                      i.Licencia.Organismo,
                      i.Licencia.CodCat,
                      i.Licencia.FechaExp
                    );

        }

        public void LimpiarComponentes()
        {
            dgvTabla.Visible = false;
            bnLimpiar.Visible = false;
            dgvTabla.Rows.Clear();
            btnDetalles.Visible = false;
            cmFiltro.Text = null;
            txtFiltro.Text = null;
        }

        public void ActivarComponentes()
        {
            dgvTabla.Visible = true;
            bnLimpiar.Visible = true;
            btnDetalles.Visible = true;
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }
    }
}
