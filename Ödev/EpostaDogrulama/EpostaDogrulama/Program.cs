using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;

namespace EpostaDogrulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Gönderen e-posta adresi ve şifresi
                string senderEmail = "tahasfhga@gmail.com";
                string senderPassword = "qw123-*0";

                // Alıcı e-posta adresi
                string recipientEmail = "jsjsqwe12@gmail.com";

                // Mail mesajı
                MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail);
                mailMessage.Subject = "Test Mesajı";
                mailMessage.Body = "Mesaj İçeriği";

                // Mail gönderme işlemi
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.Send(mailMessage);

                Console.WriteLine("E-posta başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("E-posta gönderirken hata oluştu: " + ex.Message);
            }

            Console.ReadKey();



        }
    }
}
