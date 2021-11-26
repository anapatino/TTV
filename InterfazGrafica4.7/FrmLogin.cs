using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace InterfazGrafica4._7
{
    public partial class FrmLogin : Form
    {
        CuentaService cuentaService;

        public FrmLogin()
        {
            InitializeComponent();
            cuentaService = new CuentaService(ConfigConnection.ConnectionString);
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            VerificarIngreso();
        }

        private void VerificarIngreso()
        {
            string password=txtPassword.Text;
            string usuario=txtUsername.Text;
            var (mensaje, cuentaEncontrada) = cuentaService.VerificarCuenta(usuario,password);
            if(cuentaEncontrada!=null)
            {
                Hide();
                new FrmCargando().ShowDialog();
                new FrmPrincipal(cuentaEncontrada).Show();   
            }
            else
            {
                MessageBox.Show(mensaje);
                LimpiarComponentes();
            }
        }

        public void LimpiarComponentes()
        {
            txtPassword.Text=null;
            txtUsername.Text=null;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void chxOcultarPassword_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chxOcultarPassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
