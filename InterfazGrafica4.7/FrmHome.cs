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
    public partial class FrmHome : Form
    {
        MultaService multaService;
        LicenciaService licenciaService;

        public FrmHome(Cuenta cuenta)
        {
            Cuenta = cuenta;
            InitializeComponent();
            multaService = new MultaService(ConfigConnection.ConnectionString);
            licenciaService = new LicenciaService(ConfigConnection.ConnectionString);
            ActivarCifrasMulta();
        }

        public Cuenta Cuenta { get; set; }

        public void ActivarCifrasMulta()
        {
            ObtenerNroMultasRegistradas();
            ObtenerNroMultasPendientes();
            ObtenerNroMultasPagadas();
            ActivarUsuario();
            ActivarGrafico();
        }

        public void ActivarUsuario()
        {
            lbUsuarioPrincipal.Text = Cuenta.NombreUsuario;
            lbUsuario.Text= Cuenta.NombreUsuario;
        }

        public void ObtenerNroMultasRegistradas()
        {
            lbNroMultasRegistradas.Text = null;
            lbNroMultasRegistradas.Text = multaService.ObtenerMultasRegistradas();
        }

        public void ObtenerNroMultasPendientes()
        {
            lbNroMultasPendientes.Text = null;
            lbNroMultasPendientes.Text = multaService.ObtenerMultasPendientes();
        }

        public void ObtenerNroMultasPagadas()
        {
            lbNroMultasPagadas.Text = null;
            lbNroMultasPagadas.Text = multaService.ObtenerMultasPagadas();
        }

        public void ActivarGrafico()
        {
            string [] titulos= { "Usuarios Con Licencias","Usuarios Sin Licencias"};
            var (mensaje,datos) = licenciaService.ObtenerDatosLicencia();
            grafico.Series["grafico"].Points.DataBindXY(titulos,datos);
            grafico.Titles.Add("Estadistica De Usuarios Con Licencia");
        }
    }
}
