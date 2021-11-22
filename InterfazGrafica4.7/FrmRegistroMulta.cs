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

        public FrmRegistroMulta()
        {
            InitializeComponent();
            AñadirDepartamento();
            AñadirBarrio();
            AñadirMulta();
            AñadirRestriccion();
            usuarioService = new UsuarioService(ConfigConnection.ConnectionString);
            multaService = new MultaService(ConfigConnection.ConnectionString);
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
        }

        public void CapturarDatos()
        {
        
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
            usuario.CiudadCodigo = ObtenerCiudadCod();
            usuario.BarrioCodigo = ObtenerBarrioCod();
            usuario.RestriccionCodigo = ObtenerRestriccionCod();
            string mensaje = usuarioService.Guardar(usuario);
            Multa mul = new Multa();
            mul.Mul_Id = ObtenerMultaCod();
            mul.Descripcion = cmDescripcion.Text;
            mul.Valor = decimal.Parse(txtValor.Text);
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = txtPlaca.Text;
            vehiculo.Marca = txtMarca.Text;
            string mesaje2 = multaService.GuardarVehiculo(vehiculo);
            Multa_Usuario multa = new Multa_Usuario();
            multa.Usuario = usuario;
            multa.Multa = mul;
            string codgio = multa.GenerarCodigo().ToString();
            multa.CodigoMultaUsuario = codgio;
            multa.Vehiculo_Id = txtPlaca.Text;
            multa.VehiculoNombre = txtMarca.Text;
            multa.Estado = "PENDIENTE";
            multa.FechaExpedicion = dtpFechaExp.Value.Date;
            string mensaje3 = multaService.Guardar(multa);
            MessageBox.Show(mensaje3);
            LimpiarComponentes();
        }


      

        private string ObtenerMultaCod()
        {
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Multa WHERE MUL_DESCRIPCION = :Descripcion", conx);
            command.Parameters.Add(new OracleParameter("Descripcion", cmDescripcion.Text));
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            string barr = "";
            while (registro.Read())
            {
                barr = registro["MUL_ID_PK"].ToString();
            }
            return barr;
            conx.Close();
        }

        private string ObtenerCiudadCod()
        {
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Ciudad WHERE CIUD_NOMBRE = :Ciudad", conx);
            command.Parameters.Add(new OracleParameter("Ciudad", cmbCiudad.Text));
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            string ciud = "";
            while (registro.Read())
            {
                ciud = registro["CIUD_CODIGO_PK"].ToString();
            }
            return ciud;
            conx.Close();
        }

        private string ObtenerBarrioCod()
        {
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Barrio WHERE BARR_NOMBRE = :Barrio", conx);
            command.Parameters.Add(new OracleParameter("Barrio", cmbBarrio.Text));
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            string barr = "";
            while (registro.Read())
            {
                barr = registro["BARR_CODIGO_PK"].ToString();
            }
            return barr;
            conx.Close();
        }

        private string ObtenerRestriccionCod()
        {
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Restriccion WHERE RES_DESCRIPCION = :Descripcion", conx);
            command.Parameters.Add(new OracleParameter("Descripcion", cmbRestriccion.Text));
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            string ress = "";
            while (registro.Read())
            {
                ress = registro["RES_COD_PK"].ToString();
            }
            return ress;
            conx.Close();
        }

        private void bnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void AñadirDepartamento()
        {
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Departamento", conx);
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                cmDepartamento.Items.Add(registro["DEP_NOMBRE"].ToString());
            }
            conx.Close();
        }

        private void AñadirBarrio()
        {
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Barrio", conx);
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                cmbBarrio.Items.Add(registro["BARR_NOMBRE"].ToString());
            }
            conx.Close();
        }

        private void AñadirRestriccion()
        {
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Restriccion", conx);
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                cmbRestriccion.Items.Add(registro["RES_DESCRIPCION"].ToString());
            }
            conx.Close();
        }


        private void AñadirMulta()
        {
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Multa", conx);
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                cmDescripcion.Items.Add(registro["MUL_DESCRIPCION"].ToString());
            }
            conx.Close();
        }

        private void cmDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Multa WHERE MUL_DESCRIPCION = :Descripcion", conx);
            command.Parameters.Add(new OracleParameter("Descripcion", cmDescripcion.Text));
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            while(registro.Read())
            {
                txtValor.Text = registro["MUL_VALOR"].ToString();
            }
            conx.Close();
        }

        

        private void cmDepartamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbCiudad.Items.Clear();
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT D.dep_nombre, C.ciud_nombre FROM Ciudad C LEFT JOIN DEPARTAMENTO D ON(C.DEP_CODIGO_FK = D.DEP_CODIGO_PK) WHERE D.dep_nombre = :Departamento", conx);
            command.Parameters.Add(new OracleParameter("Departamento", cmDepartamento.Text));
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                cmbCiudad.Items.Add(registro["CIUD_NOMBRE"].ToString());
            }
            conx.Close();
        }
    }
}
