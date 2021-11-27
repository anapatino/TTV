using System;
using Datos;
using Entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;

        public Email()
        {
            smtp = new SmtpClient();
        }

        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("sofipatino614@gmail.com", "1067590360");
        }

        private void ConfigurarEmail(Cuenta persona)
        {
            email = new MailMessage();
            email.To.Add("yeiderquintero614@gmail.com");
            email.From = new MailAddress("sofipatino614@gmail.com");
            email.Subject = "Recuperacion Contraseña  "
                + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sr {persona.Usuario}</b> <br " +
                $" > Su Contraseña es : {persona.Password} , Intente Ingresando Seccion de Nuevo";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.High;
        }

        public string EnviarEmail(Cuenta persona)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail(persona);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {
                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }
    }
 }
