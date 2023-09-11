using System.Text;
using System;
using System.Security.Cryptography;

namespace OrnekVebSitesi.Busniess
{
    public class Şifreİşlemleri
    {
        public static string HashSifre(string sifre)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(sifre));

                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
