using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaMüşteriTakipSistemi
{
    public static class MüşteriManager
    {
        //oncelıkle verılerı tutabilmek için List bır database modellıycez
        public static List<Müşteri> database = new();

        static MüşteriManager()
        {
            //burada hazır 1 tane verı ekledık
            Müşteri musteri = new()
            {
                İsim = "Sadık",
                Soyisim = "Sünbül",
                Email = "Test1",
                Şifre = "1",
                Id = 1
            };

            database.Add(musteri);
        }
        public static void giriş(Müşteri müsteri)
        {
            if (!string.IsNullOrEmpty(müsteri.Email) && !string.IsNullOrEmpty(müsteri.Şifre)) //burada dedıkkı gelen musterının maıl ve sıfresı bos olmasın 
            {
                for (int i = 0; i < database.Count; i++) //database uzunlugunda doncez 
                {
                    Müşteri temp = (Müşteri)database[i]; //burada databasedekı verılerı musterıye dondurup 
                    if (temp.Email == müsteri.Email && temp.Şifre == müsteri.Şifre)  //burada donen verılerın emaıllerı ve sıfreler uyusuyormu dıye kontrol ettık 
                    {
                        Console.WriteLine("Giriş başarılı");
                        Console.WriteLine($"Hoşgeldiniz {temp.İsim}-{temp.Soyisim}");
                    }
                    else
                    {
                        Console.WriteLine("Boyle bır kullanıcı yok giriş yapılamadı");
                    }
                }
            }
        }
        public static void Ekle(Müşteri müsteri)
        {
            if (!string.IsNullOrEmpty(müsteri.Email) && !string.IsNullOrEmpty(müsteri.Şifre)) //burada dedıkkı gelen musterının maıl ve sıfresı bos olmasın 
            {
                //eklenecek verıde meillerin farklı olmasını ıstıyoruz 
                bool emailvarmı = emailkontorl(müsteri.Email);
                if (emailvarmı) //true ıse gırcek 
                {
                    Console.WriteLine("Bu maıl var kayıdını yapılamadı");
                }
                else
                {
                    database.Add(müsteri);
                    Console.WriteLine("Kaydınız basarılı bır sekılde yapıldı.");
                }
            }
            else
            {
                Console.WriteLine("Email veya şifreniz boş kaydınız yapılamaz..");
            }
            
        }
        public static void sil(Müşteri müsteri)
        {
            if (!string.IsNullOrEmpty(müsteri.Email) && !string.IsNullOrEmpty(müsteri.Şifre)) //burada dedıkkı gelen musterının maıl ve sıfresı bos olmasın 
            {
                for (int i = 0; i < database.Count; i++) //database uzunlugunda doncez 
                {
                    Müşteri temp = (Müşteri)database[i]; //burada databasedekı verılerı musterıye dondurup 
                    if (temp.Email == müsteri.Email && temp.Şifre==müsteri.Şifre)  //burada donen verılerın emaıllerı ve sıfreler uyusuyormu dıye kontrol ettık 
                    {
                        //maıl ve sıfre uyusmamıs olsaydı sılınmıycektı 
                        database.Remove(temp);
                        Console.WriteLine("Kişi başarılı bır sekılde sılındı");
                    }
                    else
                    {
                        Console.WriteLine("Boyle bır kullanıcı yok verı sılınemedi");
                    }
                }
            }
            else
            {
                Console.WriteLine("Mail ve şifreniz boş olmamalı");
            }
        }

        public static bool emailkontorl(string email)
        {
            bool kontrol = false;
            for (int i = 0; i < database.Count; i++) //database uzunlugunda doncez 
            {
                Müşteri temp =(Müşteri)database[i]; //burada databasedekı verılerı musterıye dondurup 
                if (temp.Email == email)  //burada donen verılerın emaıllerı uyusuyormu dıye kontrol ettık 
                {
                    kontrol = true;   //uyusuyorsa emaıl var true dondurduk
                }
            }
            return kontrol;
        }

    }
}
