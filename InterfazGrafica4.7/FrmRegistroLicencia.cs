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
    public partial class FrmRegistroLicencia : Form
    {
        public FrmRegistroLicencia()
        {
            InitializeComponent();
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        public void LimpiarComponentes()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtCedula.Text = null;
            txtDireccion.Text = null;
            txtGrupoSanguineo.Text = null;
            txtPrecio.Text = null;
            txtTelefono.Text = null;
            txtFechaNacimiento.Text = null;
            txtFechaExpedicion.Text = null;
            cmCategoria.Text = null;
        }

        private void bnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void bnRegistrar_Click(object sender, EventArgs e)
        {
            new FrmGuardar().Show();
        }
    }
}
