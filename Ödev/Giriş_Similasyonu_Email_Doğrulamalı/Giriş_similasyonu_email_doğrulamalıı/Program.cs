using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Giriş_similasyonu_email_doğrulamalıı
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            Google("Sadık Sünbül", "jsjsqwe12@gmail.com", "Sa05396631688", "sunbulali84@gmail.com", "Test", "Test Maili");


            void Google(string GondericiAdSoyad, string GondericiMail, string GondericiPass, string AliciMail, string Baslik, string icerik/*,string ek*/)
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(GondericiMail, GondericiAdSoyad);
                mail.To.Add(AliciMail);
                mail.Subject = Baslik;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                //if (ek != null)
                //{
                //    mail.Attachments.Add(new Attachment(ek));
                //}
                sc.Timeout = 100;
                sc.Send(mail);

            }
        }
    }
}
