using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Presentacion
{
    class Program
    {

        static void Main(string[] args)
        {
            char seguir = 'S';
            do
            {
                int opcion = Menu();
                switch (opcion)
                {
                    case 1: GuardarLicencia();
                        break;
                    case 2: GuardarMulta();
                        break;
                    case 3: PagarMulta();
                        break;
                    case 4: Recategorizar();
                        break;
                    case 5: ExpedirLicencia();
                        break;
                    case 6: seguir = 'N';
                        break;

                }
            } while (seguir == 'S');
        }

        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("   APLICATIVO PARA TRANSITO Y TRANSPORTE DE VEHICULOS");
            Console.WriteLine("");
            Console.WriteLine("1. Registrar Licencia");
            Console.WriteLine("2. Registrar de Multa ");
            Console.WriteLine("3. Pago de Multa ");
            Console.WriteLine("4. Recategorizar Licencia ");
            Console.WriteLine("5. Expedir Licencia ");
            Console.WriteLine("6. Salir");
            Console.WriteLine("");

            int opcion = 0;
            do
            {
                Console.Write("    Seleccione su opcion: ");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion < 1 && opcion > 6);
            return opcion;
        }
        public static void GuardarLicencia()
        {
            Console.Clear();
            Console.WriteLine("-----------------1.REGISTRO LICENCIA----------------");
            Console.WriteLine("");
            Console.WriteLine("DATOS PERSONALES");
            var usuario = RegistrarUsuario();
            Console.WriteLine("");
            Console.WriteLine("DATOS PARA LA LICENCIA");
            var item = RegistrarLicencia(usuario);
            Console.Clear();
            Console.WriteLine("------Registros Licencias Ingresadas------");

            Console.WriteLine(item.ToString());
            Console.WriteLine("Pulse cualquier tecla para volver");
            Console.ReadKey();
        }

        public static Usuario RegistrarUsuario()
        {
            Console.Write("Cedula          :");
            string cedula = Console.ReadLine();
            Console.Write("Nombre          :");
            string nombre = Console.ReadLine();
            Console.Write("Apellido        :");
            string apellido = Console.ReadLine();
            Console.Write("GrupoSanguineo  :");
            string grupoSanguineo = Console.ReadLine();
            Console.Write("Fecha Nacimiento:");
            string fecha = Console.ReadLine();
            Console.Write("Direccion       :");
            string direccion = Console.ReadLine();
            Console.Write("Telefono        :");
            long telefono = long.Parse(Console.ReadLine());
            Usuario usuario = new Usuario(nombre, fecha, apellido, direccion, cedula, telefono, grupoSanguineo);
            return usuario;
        }
        public static Usuario_Licencia RegistrarLicencia(Usuario usuario)
        {
            Console.Write("Fecha Expedicion   :");
            string fecha = Console.ReadLine();
            Console.Write("Categoria          :");
            string categoria = Console.ReadLine();
            Usuario_Licencia lic = new Licencia(fecha, categoria, usuario);
            lic.CalcularValorLicencia();
            return lic;
          
        }
        public static void GuardarMulta()
        {
            Console.Clear();
            Console.WriteLine("-----------------2.REGISTRO MULTA----------------");
            Console.WriteLine("");
            Console.WriteLine("DATOS PERSONALES");
            var usuario = RegistrarUsuario();
            Console.WriteLine("");
            Console.WriteLine("DATOS PARA LA MULTA");
            var item = RegistrarMulta(usuario);
            Console.Clear();
            Console.WriteLine("-----------------MULTAS REGISTRADA----------------");
            Console.WriteLine(item.ToString());
            Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.ReadKey();
        }

        public static Multa_Usuario RegistrarMulta(Usuario usuario)
        {
          
            Console.Write("Descripcion   :");
            string descripcion = Console.ReadLine();
            Console.Write("Valor Multa   :");
            int valor = int.Parse(Console.ReadLine());
            Console.Write("Placa  :");
            string placa = Console.ReadLine();
            Console.Write("Tipo Vehiculo  :");
            string tipoVehiculo = Console.ReadLine();
            Multa_Usuario mul = new Multa(descripcion, valor, placa, tipoVehiculo, usuario);
            Console.WriteLine(mul.ToString());
            return mul;
        }

        public static void PagarMulta()
        {
            Console.Clear();
            Console.WriteLine("-----------------3.PAGO MULTA----------------");
            Console.WriteLine("");
            Console.WriteLine("DATOS PERSONALES");
            var usuario = RegistrarUsuario();
            Console.WriteLine("");
            Console.WriteLine("DATOS PARA LA MULTA");
            var multa = RegistrarMulta(usuario);
            Console.Clear();
            Console.WriteLine("-----------------MULTAS REGISTRADA----------------");
            Console.WriteLine(multa);
            PagoMulta pago = new PagoMulta(multa);
            Console.WriteLine("");  
            Console.WriteLine("-----------------MULTAS PAGADAS----------------");
            Console.WriteLine(pago);
            Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.ReadKey();

        }
        public static void Recategorizar()
        {
            Console.Clear();
            Console.WriteLine("-----------------4.RECATEGORIZAR LICENCIA----------------");
            Console.WriteLine("");
            Console.WriteLine("DATOS PERSONALES");
            var usuario = RegistrarUsuario();
            Console.WriteLine("");
            Console.WriteLine("DATOS PARA LA LICENCIA");
            var licencia = RegistrarLicencia(usuario);
            Console.Clear();
            Console.WriteLine("-----------------LICENCIA REGISTRADA----------------");
            Console.WriteLine(licencia);
            Console.WriteLine("");
            Console.Write("Ingrese nueva categoria: "); string categoria = Console.ReadLine();
            Recategorizar recategorizar = new Recategorizar(categoria,licencia);
            recategorizar.Licencia.CalcularValorLicencia();
            Console.WriteLine("-----------------LICENCIA RECATEGORIZADA----------------");
            Console.WriteLine(recategorizar.ToString());
            Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.ReadKey();
        }

        public static void ExpedirLicencia()
        {
            Console.Clear();
            Console.WriteLine("-----------------5.EXPEDIR LICENCIA----------------");
            
            Console.WriteLine("DATOS PERSONALES");
            var usuario = RegistrarUsuario();
            Console.WriteLine("");
            Console.WriteLine("DATOS PARA LA LICENCIA");
            var licencia = RegistrarLicencia(usuario);
            ExpedirLicencia expedir = new ExpedirLicencia(licencia);
            Console.Clear();
            Console.WriteLine("----------------- LICENCIA EXPEDIDA----------------");
            Console.WriteLine(expedir.MostrarLicencia());
            Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.ReadKey();
        }

    }
}
