using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace ClasesLibreria
{
    public class EnviarMail
    {

        MailMessage m = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        public bool MailRegistro(string to, string user)
        {
            try
            {
                m.From = new MailAddress("lezav22@gmail.com");
                m.To.Add(new MailAddress(to));
                m.Body = "Bienvenido al sistema de Asesorías UDLA, su nombre de usuario es: " + user + "";
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("lezav22@gmail.com", "Realmadrid22-");
                smtp.EnableSsl = true;
                smtp.Send(m);
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }


        public bool MailRecuperacion(string to, string pass)
        {
            try
            {
                m.From = new MailAddress("lezav22@gmail.com");
                m.To.Add(new MailAddress(to));
                m.Body = "Bienvenido al sistema de Asesorías UDLA, su clave de acceso es: " + pass + "";
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("lezav22@gmail.com", "Realmadrid22-");
                smtp.EnableSsl = true;
                smtp.Send(m);
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

    }
}