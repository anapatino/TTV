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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(Cuenta cuenta)
        {
            Cuenta = cuenta;
            InitializeComponent();
            customizeDesing();
        }

        public Cuenta Cuenta { get; set; }

        int m, mx, my;

        private void customizeDesing()
        {
            panelSubMenuLicencia.Visible = false;
            panelSubMenuMulta.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubMenuLicencia.Visible == true)
            {
                panelSubMenuLicencia.Visible = false;

            }
            if (panelSubMenuMulta.Visible == true)
            {
                panelSubMenuMulta.Visible = false;
            }
        }

        private void ShowMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void OpenFormHijo(Form hijoForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = hijoForm;
            hijoForm.TopLevel = false;
            hijoForm.FormBorderStyle = FormBorderStyle.None;
            hijoForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(hijoForm);
            panelContenedor.Tag = hijoForm;
            hijoForm.BringToFront();
            hijoForm.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmLogin().Show();
        }

        private void bttHome_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmHome(Cuenta));
        }

        private void bttLicencia_Click(object sender, EventArgs e)
        {
            ShowMenu(panelSubMenuLicencia);
        }

        private void bttMulta_Click(object sender, EventArgs e)
        {
            ShowMenu(panelSubMenuMulta);
        }

        private void btnRegistrarLicencia_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmRegistroLicenciaa());
            hideSubmenu();
        }

        private void btnBuscarLicencia_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmConsultaLicencia());
            hideSubmenu();
        }

        private void btnRecategorizarLicencia_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmRecategorizar());
            hideSubmenu();
        }

        private void btnRegistrarMulta_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmRegistroMulta());
            hideSubmenu();
        }

        private void btnBuscarMulta_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmConsultaMulta());
            hideSubmenu();
        }

        private void btnPagoMulta_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmPagoMulta());
            hideSubmenu();
        }

        private void btnHistorialPagoMulta_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmHistorialPagoMulta());
            hideSubmenu();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
