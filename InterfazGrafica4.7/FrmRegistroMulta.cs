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

        private void bnRegistrar_Click(object sender, EventArgs e)
        {
         
            LimpiarComponentes();
        }

        private void LimpiarComponentes()
        {
            txtPlaca.Text = null;
            cmTipoVehiculo.Text = null;
            cmDescripcion.Text = null;
            txtBusqueda.Text = null;
            txtValor.Text = null;
        }

        public void CapturarDatos()
        {
        
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void cmTipoVehiculo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmTipoVehiculo.Text))
            {
                e.Cancel = true;
                cmTipoVehiculo.Focus();
                errorTipo.SetError(cmTipoVehiculo, "Seleccione un Tipo Vehiculo");
            }
            else
            {
                e.Cancel = false;
                errorTipo.SetError(cmTipoVehiculo, null);
            }
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
    }
}
