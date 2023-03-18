using GirişSimilasyonu.BusinessLayer.Entityler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GirişSimilasyonu.Businesslayer
{
    public static class Menu
    {

        
            public static async  Task  AnaMenü()
            {
                int kontrol = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Menüye hosgeldınız ");
                    Console.WriteLine("1->Kullanıcı Girişi");
                    Console.WriteLine("2->Çalışan Girişi");
                    Console.WriteLine("3->Şifre değişimi");
                    Console.WriteLine("4->Kayıt ol");
                    int secım = int.Parse(Console.ReadLine());
                    switch (secım)
                    {
                        case 1:
                            Console.WriteLine("Kullanııc gırısıne hosgeldınız");
                            Console.WriteLine("Email");
                            string email = Console.ReadLine();
                            Console.WriteLine("Şifre");
                            string şifre = Console.ReadLine();
                            await DataBaseBaglantı.KullanıcıGirişi(email, şifre);
                            break;
                        case 2:
                            Console.WriteLine("Calısan gırısıne hosgeldınız");
                            Console.WriteLine("Email");
                            string email1 = Console.ReadLine();
                            Console.WriteLine("Şifre");
                            string şifre1 = Console.ReadLine();
                             DataBaseBaglantı.ÇalışanGirişi(email1, şifre1);
                            break;
                        case 3:
                            Console.WriteLine("Kullanııc gırısıne hosgeldınız");
                            Console.WriteLine("Email");
                            string email2 = Console.ReadLine();
                            Console.WriteLine("Şifre");
                            string şifre2 = Console.ReadLine();
                             DataBaseBaglantı.KullaniciŞifreDeğiştirme(email2, şifre2);
                            break;
                        case 4:
                            Console.WriteLine("Kayıt sayfasına hosgeldınız burada sadece kullanıcılar kayıt yapabılır calısan kayıtlarını sadece calısanalr yapabılrı");
                            NormalKullanıcılar normal = new();
                            Console.WriteLine("isim");
                            normal.İsim = Console.ReadLine();
                            Console.WriteLine("soyisim");
                            normal.Soyisim = Console.ReadLine();
                            Console.WriteLine("Email");
                            normal.Email = Console.ReadLine();
                            Console.WriteLine("şifre");
                            normal.Şifre = Console.ReadLine();
                            DataBaseBaglantı.Kayıt(normal);
                            break;
                        default:
                            break;
                    }
                System.Threading.Thread.Sleep(10000);
                    Console.WriteLine("Menuden cıkmak ıstıyorsanız 0 yazınız islemelre devam etmek ıstıyorsanız 1 yazını");
                    kontrol = int.Parse(Console.ReadLine());
                } while (kontrol == 1);

            }



        }
    }
