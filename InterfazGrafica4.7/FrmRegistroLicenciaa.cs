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
        string ciud = "";
        UsuarioService usuarioService;
        LicenciaService licenciaService;

        public FrmRegistroLicenciaa()
        {
            InitializeComponent();
            AñadirDepartamento();
            AñadirBarrio();
            AñadirCategoria();
            AñadirRestriccion();
            usuarioService = new UsuarioService(ConfigConnection.ConnectionString);
            licenciaService = new LicenciaService(ConfigConnection.ConnectionString);
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
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
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Departamento",conx);
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            while(registro.Read())
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


        private void AñadirCategoria()
        {
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Categoria", conx);
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                cmCategoria.Items.Add(registro["CAT_NOM"].ToString());
            }
            conx.Close();
        }

        private void cmCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Categoria WHERE CAT_NOM = :Categoria", conx);
            command.Parameters.Add(new OracleParameter("Categoria", cmCategoria.Text));
            conx.Open();
            OracleDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                txtPrecio.Text = registro["CAT_PRECIO"].ToString();
            }
            conx.Close();
        }

        private void cmDepartamento_SelectedIndexChanged(object sender, EventArgs e)
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

        private void bnRegistrar_Click(object sender, EventArgs e)
        {
            Licencia licencia = new Licencia();
            string codigo = licencia.GenerarCodigo().ToString();
            licencia.Codigo = codigo;
            licencia.Organismo = txtOrganismo.Text;
            licencia.FechaExp = dtpFechaExp.Value.Date;
            licencia.CodCat = ObtenerCategoriaCod();
            string mensaje2 = licenciaService.Guardar(licencia);
            Usuario usuario = new Usuario();
            usuario.Codigo = txtCedula.Text;
            usuario.Pri_nombre = txtPriNombre.Text;
            usuario.Seg_nombre = txtSegNombre.Text;
            usuario.Pri_apellido = txtPriApellido.Text;
            usuario.Seg_apellido = txtSegApellido.Text;
            usuario.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            usuario.Telefono = txtTelefono.Text;
            usuario.Grupo_Sanguineo = txtGS.Text;
            usuario.LicenciaCodigo = codigo;
            usuario.CiudadCodigo = ObtenerCiudadCod();       
            usuario.BarrioCodigo = ObtenerBarrioCod();       
            usuario.RestriccionCodigo = ObtenerRestriccionCod();
            string mensaje = usuarioService.Guardar(usuario);   
            MessageBox.Show(mensaje + " y "+ mensaje2);
            LimpiarComponentes();
        }

        private string ObtenerCategoriaCod()
        {
            OracleConnection conx = new OracleConnection(ConfigConnection.ConnectionString);
            OracleCommand command = new OracleCommand("SELECT * FROM Categoria WHERE CAT_NOM = :Categoria", conx);
            command.Parameters.Add(new OracleParameter("Categoria", cmCategoria.Text));
            conx.Open();
            string cat = "";
            OracleDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                cat = registro["CAT_COD_PK"].ToString();
            }
            return cat;
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

        
    }
}
