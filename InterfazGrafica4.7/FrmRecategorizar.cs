using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidad;

namespace InterfazGrafica4._7
{
    public partial class FrmRecategorizar : Form
    {
        UsuarioLicenciaService recategorizarLicenciaService;
        LicenciaService licenciaService;

        public FrmRecategorizar()
        {
            InitializeComponent();
            recategorizarLicenciaService = new UsuarioLicenciaService(ConfigConnection.ConnectionString);
            licenciaService= new LicenciaService(ConfigConnection.ConnectionString);
            ActivarComponentesBaseDatos();
        }

        public void ActivarComponentesBaseDatos()
        {
            AñadirCategoria();
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            Recategorizar();
        }

        private void AñadirCategoria()
        {
            cmbCategoria.DataSource = licenciaService.AñadirCategorias().Combox;
        }


        public void Recategorizar()
        {
            string codigoLicencia = txtCodigoLicencia.Text;
            string nombreCategoria = cmbCategoria.Text;
            string codigoCategoria = licenciaService.ObtenerCategoria(nombreCategoria);
            var respuesta = recategorizarLicenciaService.ModificiarCategoria(codigoCategoria,codigoLicencia);
            MessageBox.Show(respuesta);
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

        public void VisualizarCodigoLicencia()
        {
            string codigo = txtFiltro.Text;
            var (mensaje, licenciaBuscada) = recategorizarLicenciaService.ConsultarPorCodigoLicencia(codigo);
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
            cmFiltro.Text = null;
            txtFiltro.Text = null;
            lbCategoria.Visible = false;
            cmbCategoria.Visible = false;
            cmbCategoria.Text = null;
            bnGuardar.Visible = false;
            lbCodigo.Visible =false;
            txtCodigoLicencia.Visible =false;
            txtCodigoLicencia.Text = null;
            txtPrecio.Visible = false;
            txtPrecio.Text = null;
            lbPrecio.Visible = false;
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
            txtPrecio.Visible = true;
            lbPrecio.Visible = true;
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = licenciaService.ObtenerPrecio(cmbCategoria.Text);
        }
    }
}
