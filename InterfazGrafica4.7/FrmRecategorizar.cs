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
    public partial class FrmRecategorizar : Form
    {
        UsuarioLicenciaService recategorizarLicenciaService;

        public FrmRecategorizar()
        {
            InitializeComponent();
            recategorizarLicenciaService = new UsuarioLicenciaService(ConfigConnection.ConnectionString);
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            Recategorizar();
        }

        public void Recategorizar()
        {
            string codigoLicencia = txtCodigoLicencia.Text;
            string codigoCategoria = cmbCategoria.Text;
            codigoCategoria = AsignarCodigoCategoria(codigoCategoria);
            var respuesta = recategorizarLicenciaService.ModificiarCategoria(codigoCategoria,codigoLicencia);
            MessageBox.Show(respuesta);
        }

        public string AsignarCodigoCategoria(string codigoCategoria)
        {
            if (codigoCategoria.Equals("A1"))
            {
                return "0101"; 
            }
            else if (codigoCategoria.Equals("A2"))
            {
                return "0102";
            }
            else if (codigoCategoria.Equals("A3"))
            {
                return "0103";
            }
            else
            {
                return AsignarCodigoCategoriaB(codigoCategoria);
            }
            return null;
        }

        public string AsignarCodigoCategoriaB(string codigoCategoria)
        {
            if (codigoCategoria.Equals("B1"))
            {
                return "0104";
            }
            else if (codigoCategoria.Equals("B2"))
            {
                return "0105";
            }
            else if (codigoCategoria.Equals("B3"))
            {
                return "0106";
            }
            else
            {
                return AsignarCodigoCategoriaC(codigoCategoria);
            }
            return null;
        }

        public string AsignarCodigoCategoriaC(string codigoCategoria)
        {
            if (codigoCategoria.Equals("C1"))
            {
                return "0107";
            }
            else if (codigoCategoria.Equals("C2"))
            {
                return "0108";
            }
            else if (codigoCategoria.Equals("C3"))
            {
                return "0109";
            }
         
            return null;
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
            else if (filtro.Equals("IDENTIFICACION"))
            {
                VisualizarCedula();
            }
            else if (filtro.Equals("ORGANISMO"))
            {
                VisualizarOrganismo();
            }
            else if (filtro.Equals("CATEGORIA"))
            {
                VisualizarCategoria();
            }
            else if (filtro.Equals("NOMBRE"))
            {
                VisualizarNombre();
            }
            else if (filtro.Equals("ANIO"))
            {
                VisualizarFecha();
            }
        }

        public void VisualizarTodo()
        {
            var respuesta = recategorizarLicenciaService.ConsultarLicenciaa();
            VisualizarTabla(respuesta);
        }

        public void VisualizarCedula()
        {
            string identificacion = txtFiltro.Text;
            var (mensaje, personaBuscada) = recategorizarLicenciaService.ConsultarPorIdentificacion(identificacion);
            if (mensaje.Equals($" Se encuentra Registrado {identificacion}"))
            {
                AgregarRegistroTabla(personaBuscada);
            }
            MessageBox.Show(mensaje);
        }

        public void VisualizarOrganismo()
        {
            string organismo = txtFiltro.Text;
            var respuesta = recategorizarLicenciaService.ConsultarPorOrganismo(organismo);
            VisualizarTabla(respuesta);
        }

        public void VisualizarCategoria()
        {
            string categoria = txtFiltro.Text;
            var respuesta = recategorizarLicenciaService.ConsultarPorCategoria(categoria);
            VisualizarTabla(respuesta);
        }

        public void VisualizarNombre()
        {
            string nombre = txtFiltro.Text;
            var respuesta = recategorizarLicenciaService.ConsultarPorNombre(nombre);
            VisualizarTabla(respuesta);
        }

        public void VisualizarFecha()
        {
            int fecha = int.Parse(txtFiltro.Text);
            var respuesta = recategorizarLicenciaService.ConsultarPorAnio(fecha);
            VisualizarTabla(respuesta);
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
            cmFiltro.Text = null;
            txtFiltro.Text = null;
            lbCategoria.Visible = false;
            cmbCategoria.Visible = false;
            cmbCategoria.Text = null;
            bnGuardar.Visible = false;
            lbCodigo.Visible =false;
            txtCodigoLicencia.Visible =false;
            txtCodigoLicencia.Text = null;
        }

        public void ActivarComponentes()
        {
            dgvTabla.Visible = true;
            bnLimpiar.Visible = true;
            lbCategoria.Visible = true;
            cmbCategoria.Visible = true;
            cmbCategoria.Text = null;
            bnGuardar.Visible = true;
            lbCodigo.Visible = true;
            txtCodigoLicencia.Visible = true;
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }
    }
}
