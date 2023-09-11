using Eticaret.Business_Process_Layer.Giriş_Ve_kayıt_İşlemleri;
using Eticaret.Datta_Access.DbGirişEntitys;
using Eticaret.Presentation_Layer.NormalKulalnıcı;
using Eticaret.Presentation_Layer.YöneticiKullanıcıc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Presentation_Layer
{
    public class GirişMenü
    {
        public static void Giriş()
        {
            Console.WriteLine("1->Giriş yap");
            Console.WriteLine("2->Kayıt Ol");
            Console.WriteLine("3->Satıcı Olma talebi ver");//en son dusunulecek

            Console.WriteLine("Lütfen birini seciniz");
            int seçilen = int.Parse(Console.ReadLine());
            switch (seçilen)
            {
                case 1:
                    Console.WriteLine("Giriş Menüsüne hoş geldiiniz");
                    Console.WriteLine("Mail");
                    string mail = Console.ReadLine();
                    Console.WriteLine("Şifre");
                    string şifre = Console.ReadLine();

                    var data = DbGirişKontrol.kontrol(mail, şifre);
                    data.Wait();
                    var data1 = data.Result;

                    switch (data1.Durum)
                    {
                        case "Normal":
                            NormalKullanıcıAnamenü.Anamenü(data1 as NkKullanıcı);
                            break;
                        case "Satıcı":
                            SatıcıAnaMenü.Menü(data1 as Satıcı);
                            break;
                        case "Yönetici":
                            YöneticiAnaMenü.Menü(data1 as Yönetici);
                            break;
                        default:
                            Console.WriteLine("Hatalı giriş yaptınız");
                            Giriş();
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("Kayıt sayfasına Hoşgeldiniz");

                    break;
                case 3:
                    Console.WriteLine("Satıcı olma isteği sayfasına hoşgeldiniz");
                    break;
                default:
                    break;
            }
        }
    }
}
