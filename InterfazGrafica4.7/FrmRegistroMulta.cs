using System;
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
    public partial class FrmRegistroMulta : Form
    {
        public FrmRegistroMulta()
        {
            InitializeComponent();
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

        }

        private void bnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }
    }
}
