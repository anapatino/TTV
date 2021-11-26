using System;
using Entidad;
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


namespace InterfazGrafica4._7
{
    public partial class FrmRegistroMulta : Form
    {
        UsuarioService usuarioService;
        MultaService multaService;
        UsuarioLicenciaService usuarioLicenciaService;

        public FrmRegistroMulta()
        {
            InitializeComponent();
            usuarioService = new UsuarioService(ConfigConnection.ConnectionString);
            multaService = new MultaService(ConfigConnection.ConnectionString);
            usuarioLicenciaService = new UsuarioLicenciaService(ConfigConnection.ConnectionString);
            AñadirDepartamento();
            AñadirBarrio();
            AñadirMulta();
            AñadirRestriccion();
          
        }

        private void LimpiarComponentes()
        {
            txtCedula.Text = null;
            txtPriNombre.Text = null;
            txtSegNombre.Text = null;
            txtPriApellido.Text = null;
            txtSegApellido.Text = null;
            txtTelefono.Text = null;
            txtValor.Text = null;
            txtGS.Text = null;
            cmbRestriccion.Text = null;
            cmbBarrio.Text = null;
            cmbCiudad.Text = null;
            cmDepartamento.Text = null;
            txtMarca.Text = null;
            txtPlaca.Text = null;
            cmDescripcion.Text = null;
            btnBuscar.Visible = false;
            txtFiltro.Text = null;
            txtFiltro.Visible = false;
            cmbOpcionLicencia.Text = null;
        }

        private void txtPlaca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                e.Cancel = true;
                txtPlaca.Focus();
                errorPlaca.SetError(txtPlaca, "Ingrese una Placa");
            }
            else
            {
                e.Cancel = false;
                errorPlaca.SetError(txtPlaca, null);
            }
        }

        private void cmDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmDescripcion.Text))
            {
                e.Cancel = true;
                cmDescripcion.Focus();
                errorDescripcion.SetError(cmDescripcion, "Seleccione una Descripcion");
            }
            else
            {
                e.Cancel = false;
                errorDescripcion.SetError(cmDescripcion, null);
            }
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
                errorCedula.SetError(txtCedula, null);
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
                errorGS.SetError(txtGS, "Ingrese su Grupo Sanguineo");
            }
            else
            {
                e.Cancel = false;
                errorGS.SetError(txtGS, null);
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

        private void txtMarca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                e.Cancel = true;
                txtMarca.Focus();
                errorMarca.SetError(txtMarca, "Digite una Marca");
            }
            else
            {
                e.Cancel = false;
                errorMarca.SetError(txtMarca, null);
            }
        }

        private void txtPlaca_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                e.Cancel = true;
                txtPlaca.Focus();
                errorPlaca.SetError(txtPlaca, "Digite una Placa");
            }
            else
            {
                e.Cancel = false;
                errorPlaca.SetError(txtPlaca, null);
            }
        }

        private void cmDescripcion_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmDescripcion.Text))
            {
                e.Cancel = true;
                cmDescripcion.Focus();
                errorDescripcion.SetError(cmDescripcion, "Seleccione una Descripcion");
            }
            else
            {
                e.Cancel = false;
                errorDescripcion.SetError(cmDescripcion, null);
            }
        }

        private void bnRegistrar_Click_1(object sender, EventArgs e)
        {
            CapturarDatos();
        }

        public void CapturarDatos()
        {
            var usuario = RegistrarUsuario();
            string mensajeUsuario = usuarioService.Guardar(usuario);
            var mul = RegistrarMulta();
            var vehiculo = RegistrarVehiculo();
            string mensajeVehiculo = multaService.GuardarVehiculo(vehiculo);
            var multa = RegistrarMultaUsuario(usuario, mul);
            string mensajeMultaUsuario = multaService.Guardar(multa);
            MessageBox.Show(mensajeMultaUsuario);
            LimpiarComponentes();
        }

        public Usuario RegistrarUsuario()
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
            usuario.LicenciaCodigo = "0006";
            usuario.CiudadCodigo = usuarioService.ObtenerCiudad(cmbCiudad.Text);
            usuario.BarrioCodigo = usuarioService.ObtenerBarrio(cmbBarrio.Text);
            usuario.RestriccionCodigo = usuarioService.ObtenerRestriccion(cmbRestriccion.Text);
            return usuario;
        }

        public Multa RegistrarMulta()
        {
            Multa mul = new Multa();
            mul.Mul_Id = multaService.ObtenerCodigoMulta(cmDescripcion.Text);
            mul.Descripcion = cmDescripcion.Text;
            mul.Valor = decimal.Parse(txtValor.Text);
            return mul;
        }

        public Vehiculo RegistrarVehiculo()
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = txtPlaca.Text;
            vehiculo.Marca = txtMarca.Text;
            return vehiculo;
        }

        public Multa_Usuario RegistrarMultaUsuario(Usuario usuario,Multa mul)
        {
            Multa_Usuario multa = new Multa_Usuario();
            multa.Usuario = usuario;
            multa.Multa = mul;
            string codgio = multa.GenerarCodigo().ToString();
            multa.CodigoMultaUsuario = codgio;
            multa.Vehiculo_Id = txtPlaca.Text;
            multa.VehiculoNombre = txtMarca.Text;
            multa.Estado = "PENDIENTE";
            multa.FechaExpedicion = dtpFechaExp.Value.Date;
            return multa;
        }

        private void bnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarComponentes();
            ActivarEdicionDatos();
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


        private void AñadirMulta()
        {
            cmDescripcion.DataSource = multaService.AñadirMulta().Combox;
        }

        private void cmDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtValor.Text = multaService.ObtenerPrecioMulta(cmDescripcion.Text);
        }

        

        private void cmDepartamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbCiudad.DataSource = usuarioService.AñadirCiudades(cmDepartamento.Text).Combox;
        }

        private void cmbOpcionLicencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpcionLicencia.Text.Equals("SI"))
            {
                txtFiltro.Visible = true;
                btnBuscar.Visible = true;
            }
            else
            {
                txtFiltro.Visible = false;
                btnBuscar.Visible = false;
                cmbOpcionLicencia.Text = null;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarLicenciaRegistrada();
        }

        private void BuscarLicenciaRegistrada()
        {
            string codigo = txtFiltro.Text;
            var (mensaje, licenciaBuscada) = usuarioLicenciaService.ConsultarPorCodigoLicencia(codigo);
            if (mensaje.Equals($"Se encuentra Registrado la Licencia con Nro {codigo}"))
            {
                DesactivarEdicionDatos();
                TraerDatosLicencia(licenciaBuscada);
            }
            else
            {
                txtFiltro.Text = null;
            }

            MessageBox.Show(mensaje);
        }

        private void DesactivarEdicionDatos()
        {
            txtCedula.Enabled = false;
            txtPriNombre.Enabled = false;
            txtSegNombre.Enabled = false;
            txtPriApellido.Enabled = false;
            txtSegApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtGS.Enabled = false;
            cmbRestriccion.Enabled = false;
            cmbBarrio.Enabled = false;
            cmbCiudad.Enabled = false;
            cmDepartamento.Enabled = false;
        }

        private void ActivarEdicionDatos()
        {
            txtCedula.Enabled = true;
            txtPriNombre.Enabled = true;
            txtSegNombre.Enabled = true;
            txtPriApellido.Enabled = true;
            txtSegApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtGS.Enabled = true;
            cmbRestriccion.Enabled = true;
            cmbBarrio.Enabled = true;
            cmbCiudad.Enabled = true;
            cmDepartamento.Enabled = true;
        }

        private void TraerDatosLicencia(Usuario_Licencia licenciaBuscada)
        {
            txtCedula.Text = licenciaBuscada.Usuario.Codigo;
            txtPriNombre.Text = licenciaBuscada.Usuario.Pri_nombre;
            txtSegNombre.Text = licenciaBuscada.Usuario.Seg_nombre;
            txtPriApellido.Text = licenciaBuscada.Usuario.Pri_apellido;
            txtSegApellido.Text = licenciaBuscada.Usuario.Seg_apellido;
            txtTelefono.Text = licenciaBuscada.Usuario.Telefono;
            txtGS.Text = licenciaBuscada.Usuario.Grupo_Sanguineo;
            cmbRestriccion.Text = licenciaBuscada.Usuario.RestriccionCodigo;
            cmbBarrio.Text = licenciaBuscada.Usuario.BarrioCodigo;
            cmbCiudad.Text = licenciaBuscada.Usuario.CiudadCodigo;
            //dtpFechaNacimiento = licenciaBuscada.Usuario.FechaNacimiento.Value.Date;
            //cmDepartamento.Text = licenciaBuscada.Usuario.;
       
        }
    }
}
