using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace InterfazGrafica4._7
{
    public class ConfigConnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnetion"].ConnectionString;
    }
}
