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
    public partial class FrmInformacionLicencia : Form
    {
        UsuarioLicenciaService usuarioLicenciaService;
        UsuarioService usuarioService;

        public FrmInformacionLicencia(Usuario_Licencia personaBuscada)
        {
            Persona = personaBuscada;
            InitializeComponent();
            usuarioLicenciaService = new UsuarioLicenciaService(ConfigConnection.ConnectionString);
            usuarioService = new UsuarioService(ConfigConnection.ConnectionString);
            LlenarDatos();
        }

        public Usuario_Licencia Persona { get; set; }

        private void LlenarDatos()
        {
            LlenarPanelUsuario();
            LlenarDatosPanelLicencia();
        }

        private void LlenarPanelUsuario()
        {
            txtCedula.Text = Persona.Usuario.Codigo;
            txtPriNombre.Text = Persona.Usuario.Pri_nombre;
            txtSegNombre.Text = Persona.Usuario.Seg_nombre;
            txtPriApellido.Text = Persona.Usuario.Pri_apellido;
            txtSegApellido.Text = Persona.Usuario.Seg_apellido;
            txtFechaNacimiento.Text = Persona.Usuario.FechaNacimiento.ToString();
            txtTelefono.Text = Persona.Usuario.Telefono;
            txtGrupoSanguineo.Text = Persona.Usuario.Grupo_Sanguineo;
            txtCiudad.Text = Persona.Usuario.CiudadCodigo;
            txtDepartamento.Text =usuarioService.ObtenerDepartamento(txtCiudad.Text);
            txtBarrio.Text = Persona.Usuario.BarrioCodigo;
        }

        private void LlenarDatosPanelLicencia()
        {
            txtCategoria.Text = Persona.Licencia.CodCat;
            txtCodigoLic.Text = Persona.Licencia.Codigo;
            txtRestriccion.Text =Persona.Usuario.RestriccionCodigo;
            txtOrganismo.Text =Persona.Licencia.Organismo;
            txtFechaExpedicion.Text = Persona.Licencia.FechaExp.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
