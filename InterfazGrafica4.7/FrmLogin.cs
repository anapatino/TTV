using System;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Hide();
            new FrmCargando().ShowDialog();
            new FrmPrincipal().Show();
            
        }
    }
}
