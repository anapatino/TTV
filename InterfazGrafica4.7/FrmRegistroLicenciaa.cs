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
    public partial class FrmRegistroLicenciaa : Form
    {
 
        UsuarioService usuarioService;
        LicenciaService licenciaService;

        public FrmRegistroLicenciaa()
        {
            InitializeComponent();
            usuarioService = new UsuarioService(ConfigConnection.ConnectionString);
            licenciaService = new LicenciaService(ConfigConnection.ConnectionString);
            ActivarCombos();
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        public void ActivarCombos()
        {
            AñadirDepartamento();
            AñadirBarrio();
            AñadirCategoria();
            AñadirRestriccion();
        }

        private void LimpiarComponentes()
        {
            txtCedula.Text = null;
            txtPriNombre.Text= null;
            txtSegNombre.Text = null;
            txtPriApellido.Text = null;
            txtSegApellido.Text = null;
            txtTelefono.Text = null;
            txtPrecio.Text = null;
            txtGS.Text = null;
            txtOrganismo.Text = null;
            cmbRestriccion.Text = null;
            cmbBarrio.Text = null;
            cmbCiudad.Text = null;
            cmbRestriccion.Text = null;
            cmDepartamento.Text = null;
            cmCategoria.Text = null;
        }

        private void txtCedula_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                e.Cancel = true;
                txtCedula.Focus();
                errorCedula.SetError(txtCedula, "Ingrese su Cedula");
            }
            else
            {
                e.Cancel = false;
                errorCedula.SetError(txtCedula,null);
            }
        }

        private void txtPriNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPriNombre.Text))
            {
                e.Cancel = true;
                txtPriNombre.Focus();
                errorPriNombre.SetError(txtPriNombre, "Ingrese su Primer Nombre");
            }
            else
            {
                e.Cancel = false;
                errorPriNombre.SetError(txtPriNombre, null);
            }
        }

        private void txtSegNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSegNombre.Text))
            {
                e.Cancel = true;
                txtSegNombre.Focus();
                errorSegNombre.SetError(txtSegNombre, "Ingrese su Segundo Nombre");
            }
            else
            {
                e.Cancel = false;
                errorSegNombre.SetError(txtSegNombre, null);
            }
        }

        private void txtPriApellido_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPriApellido.Text))
            {
                e.Cancel = true;
                txtPriApellido.Focus();
                errorPriApellido.SetError(txtPriApellido, "Ingrese su Primer Apellido");
            }
            else
            {
                e.Cancel = false;
                errorPriApellido.SetError(txtPriApellido, null);
            }
        }

        private void txtSegApellido_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSegApellido.Text))
            {
                e.Cancel = true;
                txtSegApellido.Focus();
                errorSegApellido.SetError(txtSegApellido, "Ingrese su Segundo Apellido");
            }
            else
            {
                e.Cancel = false;
                errorSegApellido.SetError(txtSegApellido, null);
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                e.Cancel = true;
                txtTelefono.Focus();
                errorTelefono.SetError(txtTelefono, "Ingrese su Telefono");
            }
            else
            {
                e.Cancel = false;
                errorTelefono.SetError(txtTelefono, null);
            }
        }

        private void txtGS_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGS.Text))
            {
                e.Cancel = true;
                txtGS.Focus();
                errorGrupo.SetError(txtGS, "Ingrese su Grupo Sanguineo");
            }
            else
            {
                e.Cancel = false;
                errorGrupo.SetError(txtGS, null);
            }
        }

        private void cmbCiudad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCiudad.Text))
            {
                e.Cancel = true;
                cmbCiudad.Focus();
                errorCiudad.SetError(cmbCiudad, "Seleccione una Ciudad");
            }
            else
            {
                e.Cancel = false;
                errorCiudad.SetError(cmbCiudad, null);
            }
        }

        private void cmbBarrio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBarrio.Text))
            {
                e.Cancel = true;
                cmbBarrio.Focus();
                errorBarrio.SetError(cmbBarrio, "Seleccione un Barrio");
            }
            else
            {
                e.Cancel = false;
                errorBarrio.SetError(cmbBarrio, null);
            }
        }

        private void cmCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmCategoria.Text))
            {
                e.Cancel = true;
                cmCategoria.Focus();
                errorCategoria.SetError(cmCategoria, "Seleccione una Categoria");
            }
            else
            {
                e.Cancel = false;
                errorCategoria.SetError(cmCategoria, null);
            }
        }

        private void cmbRestriccion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbRestriccion.Text))
            {
                e.Cancel = true;
                cmbRestriccion.Focus();
                errorRestriccion.SetError(cmbRestriccion, "Seleccione una Restriccion");
            }
            else
            {
                e.Cancel = false;
                errorRestriccion.SetError(cmbRestriccion, null);
            }
        }

        private void txtOrganismo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrganismo.Text))
            {
                e.Cancel = true;
                txtOrganismo.Focus();
                errorOrganismo.SetError(txtOrganismo, "Ingrese su Organismo");
            }
            else
            {
                e.Cancel = false;
                errorOrganismo.SetError(txtOrganismo, null);
            }
        }

        private void cmDepartamento_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmDepartamento.Text))
            {
                e.Cancel = true;
                cmDepartamento.Focus();
                errorDepartamento.SetError(cmDepartamento, "Seleccione un Departamento");
            }
            else
            {
                e.Cancel = false;
                errorDepartamento.SetError(cmDepartamento, null);
            }
        }

        private void AñadirDepartamento()
        {
            cmDepartamento.DataSource = usuarioService.AñadirDepartamento().Combox;
        }

        private void AñadirBarrio()
        {
            cmbBarrio.DataSource = usuarioService.AñadirBarrios().Combox;
        }

        private void AñadirRestriccion()
        {
            cmbRestriccion.DataSource = usuarioService.AñadirRestricciones().Combox;
        }


        private void AñadirCategoria()
        {
            cmCategoria.DataSource = licenciaService.AñadirCategorias().Combox;
        }

        private void cmCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = licenciaService.ObtenerPrecio(cmCategoria.Text);
        }

        private void cmDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCiudad.DataSource = usuarioService.AñadirCiudades(cmDepartamento.Text).Combox;
        }

        private void bnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarDatos();
        }

        private void RegistrarDatos()
        {
            var licencia = RegistrarLicencia();
            string mensajeLicencia = licenciaService.Guardar(licencia);
            var usuario = RegistrarUsuario(licencia);
            string mensajeUsuario = usuarioService.Guardar(usuario);
            VerificarDatosRegistrados(mensajeLicencia); 
        }

        public void VerificarDatosRegistrados(string mensajeLicencia)
        {
            if (mensajeLicencia.Equals("Se guardaron los datos Satisfactoriamente la Licencia"))
            {
                new FrmGuardar().Show();
            }
            else
            {
                new FrmError().Show();
            }
            LimpiarComponentes();
        }

        private Licencia RegistrarLicencia()
        {
            Licencia licencia = new Licencia();
            string codigo = licencia.GenerarCodigo().ToString();
            licencia.Codigo = codigo;
            licencia.Organismo = txtOrganismo.Text;
            licencia.FechaExp = dtpFechaExp.Value.Date;
            licencia.CodCat = licenciaService.ObtenerCategoria(cmCategoria.Text);
            return licencia;
        }

        private Usuario RegistrarUsuario(Licencia licencia)
        {
            Usuario usuario = new Usuario();
            usuario.Codigo = txtCedula.Text;
            usuario.Pri_nombre = txtPriNombre.Text;
            usuario.Seg_nombre = txtSegNombre.Text;
            usuario.Pri_apellido = txtPriApellido.Text;
            usuario.Seg_apellido = txtSegApellido.Text;
            usuario.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            usuario.Telefono = txtTelefono.Text;
            usuario.Grupo_Sanguineo = txtGS.Text;
            usuario.LicenciaCodigo = licencia.Codigo;
            usuario.CiudadCodigo = usuarioService.ObtenerCiudad(cmbCiudad.Text);
            usuario.BarrioCodigo = usuarioService.ObtenerBarrio(cmbBarrio.Text);
            usuario.RestriccionCodigo = usuarioService.ObtenerRestriccion(cmbRestriccion.Text);
            return usuario;
        }
    }
}
