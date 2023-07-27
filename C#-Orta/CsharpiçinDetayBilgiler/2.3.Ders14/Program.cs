#region C#'da Hazır Sınıflar ve Fonksiyonlar Nedir?

#region Math Sınıfı

#region ABS
Math.Abs(-1243); //mutlak deger ıslemı yapar
#endregion
#region Celling
Math.Ceiling(234.235);//yuvarlama ıselmı yapar yukarıya yuvarlar bu
#endregion
#region Floor
Math.Floor(124.23); //yuvarlama yapar asagıya yuvarlar bu
#endregion
#region Round
Math.Round(21.2);//en yakın yere yuvarlar 
#endregion
#region Pow
//uslu ısleemlerı yapar
Math.Pow(2,5);//2 ussu 5 dır
#endregion
#region Sqrt
Math.Sqrt(49);//kare kok alır 7 verır
#endregion
#region Truncate
Math.Truncate(213.23);//sadece tam kısmını elde etmek ıstıye bılırız
#endregion
#endregion

#region DateTime Struct'ı
#region Now
//şimdiki zaman
//bu zamanı da getırı saat dk sn getırır
Console.WriteLine(DateTime.Now);
#endregion
#region Today
//sadece tarıhı getırı
Console.WriteLine(DateTime.Today);
#endregion
#region Compare
//int doner karsılatırma yapar
DateTime tarıh1 = new DateTime(2021, 01, 01);
DateTime tarıh2 = new DateTime(2022, 01, 01);

int resul=(DateTime.Compare(tarıh1,tarıh2));

if (resul<0)
{
    Console.WriteLine($"{tarıh1} kucuktur {tarıh2}");
}
else if (resul==0)
{
    Console.WriteLine($"{tarıh1} eşittir {tarıh2}");
}
else
{
    Console.WriteLine($"{tarıh1} büyüktür {tarıh2}");
}
#endregion
#region AddDays
//belı bır tarıhe gun ekle 

DateTime.Now.AddYears(99);//99 yıl sonra kı tarıhı verıcek
DateTime.Now.AddSeconds(999);//99 snıye sonra kı tarıhı verıcek

#endregion
#region AddHours

#endregion
#region AddMonths

#endregion
#region AddYears

#endregion
#region AddMiliseconds

#endregion

#endregion

#region TimeSpan Struct'ı
//ıkı tarıh arasındakı farkı tıme span doner

TimeSpan fark = tarıh1 - tarıh2;
Console.WriteLine(fark.Days);//arasında kac gun var 

#endregion

#region Random Sınıfı
//
Random rndm = new();

#region Next Fonk
int sayı = rndm.Next();//0-......
int sayı1 = rndm.Next(1000);//0-.1000dahıl degıl
int sayı2 = rndm.Next(50,1000);//50 dahıl 1000dahıl degıl
#endregion
#region NextDouble fonk
//0 la 1 arasında bır deger uretir
Console.WriteLine(rndm.NextDouble());
#endregion
#endregion

#endregion

/*
 Console sınıfı: Kullanıcıya bilgi göstermek veya kullanıcıdan girdi almak için kullanılır. Daha fazla bilgi için buraya göz atabilirsiniz: https://docs.microsoft.com/tr-tr/dotnet/api/system.console?view=net-6.0

String sınıfı: Dize işlemleri yapmak için kullanılır. Daha fazla bilgi için buraya göz atabilirsiniz: https://docs.microsoft.com/tr-tr/dotnet/api/system.string?view=net-6.0

Math sınıfı: Matematiksel işlemler yapmak için kullanılır. Daha fazla bilgi için buraya göz atabilirsiniz: https://docs.microsoft.com/tr-tr/dotnet/api/system.math?view=net-6.0

DateTime sınıfı: Tarih ve saat işlemleri yapmak için kullanılır. Daha fazla bilgi için buraya göz atabilirsiniz: https://docs.microsoft.com/tr-tr/dotnet/api/system.datetime?view=net-6.0

FileStream sınıfı: Dosya okuma ve yazma işlemleri yapmak için kullanılır. Daha fazla bilgi için buraya göz atabilirsiniz: https://docs.microsoft.com/tr-tr/dotnet/api/system.io.filestream?view=net-6.0

SqlConnection sınıfı: SQL Server veritabanına bağlanmak ve sorgular göndermek için kullanılır. Daha fazla bilgi için buraya göz atabilirsiniz: https://docs.microsoft.com/tr-tr/dotnet/api/system.data.sqlclient.sqlconnection?view=net-6.0

List sınıfı: Verileri liste şeklinde tutmak için kullanılır. Daha fazla bilgi için buraya göz atabilirsiniz: https://docs.microsoft.com/tr-tr/dotnet/api/system.collections.generic.list-1?view=net-6.0

Dictionary sınıfı: Anahtar-değer çiftleri şeklinde verileri tutmak için kullanılır. Daha fazla bilgi için buraya göz atabilirsiniz: https://docs.microsoft.com/tr-tr/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0

Convert sınıfı: Bir veri tipini başka bir veri tipine dönüştürmek için kullanılır. Daha fazla bilgi için buraya göz atabilirsiniz: https://docs.microsoft.com/tr-tr/dotnet/api/system.convert?view=net-6.0

Array sınıfı: Verileri dizi şeklinde tutmak için kullanılır. Daha fazla bilgi için buraya göz atabilirsiniz: https://docs.microsoft.com/tr-tr/dotnet/api/system.array?view=net-6.0


 */