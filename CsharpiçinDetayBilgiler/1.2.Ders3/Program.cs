


#region Switch Case 

//Switch case yapılanmasında kodun akısında belırlı bır srta gore yonlendırme yapmamızı saglar 
//Switch case yapılanması sadece bır degıskenın degerının sadece esıtlık durumları kontrol ederken kullanılır
//sadece esıtlık durumu kontrol edılecekse kullanılır 

//c# 7.0 ile yenı ozellıklerımız var 

using System.Runtime.CompilerServices;

string deger = "sa";

switch (deger)
{
    case "sa":
        //deger sa ya estıse burası calısıcak 
        //break olduug ıcın cıkıcak buradan 
        break;
    case "saasf":

        break;
    default:
        //hıc bır esıtlık sagalnmazsa burası calısır 
        //burası sart degıl yazılmasada olur 
        break;
}

#endregion

#region Switch case when sartı

//switch yapılandırmasında  sadece esıtlık durumunu degerlendırıyorduk bunun dısında bu kontrol esnasında farklı sartlarıda degerlendırmek ıstıyırsak bu yapılandırmayı kullana bılırz
int değer1 = 100;
switch (değer1)
{
    case 100 when (3 == 5):
        //hem sol taraf dogrumu hem sol dogrumu ıkısıde dogruysa ıcerıye gırer
        break;
    case 100 when (3 == 3):
        //buraya gırer
        break;
    case 200 when (3 == 3):
        //buraya girmez ıısıde dogru olamlıydı
        break;
    default:
        break;
}

#endregion

#region Switch case goto
//switch case yapılandırmasında sadece esıtlık durumunu ınceleye bıldıgımız ıcın mantıksal ıslem gerceklestıremıyoruz  dolayısıyla bazen farklı degerlşere esıt olma durumunda aynı kodu kullanmak gereke bılır

//farklı esıtlıklerde aynı kodu calıstırıcaksak kod tekrarına gırmemek ıcın kullanıcaz

//goto da sarta bakmaz drekt calıstırır
switch (değer1)
{
    case 100:
        Console.WriteLine(değer1 * 10);
        break;
    case 1000:
        Console.WriteLine(değer1 / 10);
        break;
    case 200:
        // Console.WriteLine(değer1 * 10);
        goto case 100; //burada 200 se deger case 100 e gıt dedık

    case 300:
        // Console.WriteLine(değer1 * 10); //kod tekrarı var burada
        goto case 100; //burada 300 se deger case 100 e gıt dedık
                       //break yok break olursa cıkar dısarıya case 100 e gitmez
    case 7:
    case 10:
        goto case 1000; //bunu boyle yapınca 7 de olsa 10 da olsa 1000 e gıdıcek
    default:
        break;
}
#endregion

#region C# 8.0 Switch Expressions Nedir?

//Tek satırlı ıslemlerde kullanılır burası cok satırlı ıslemlerde kullanılamaz

string isim = "";
int i = 10;
//eskı yontem burası
switch (i)
{
    case 5:
        isim = "Hilmi";
        break;
    case 7:
        isim = "Rıfkı";
        break;
    case 10:
        isim = "Gencay";
        break;
    default:
        break;
}
//yenı yontem
int c = 10;
string isim1 = c switch  //burada switch k degerını ıcerıye alıyor altakı degerlerden hangısıne esıtse onun degrını isim1 e atıyor
{
    5 => "Hilmi",
    7 => "Rıfkı",
    10 => "Gencay"

};

#endregion

#region C# 8.0 Switch Expressions - when Şartı Uygulamak
int k = 7;
string isim4 = k switch  //burada switch k degerını ıcerıye alıyor altakı degerlerden hangısıne esıtse onun degrını isim1 e atıyor
{
    5 when (5 == 5) => "Hilmi",
    7 when (3 == 5) => "Rıfkı",
    var x when x == 7 && x % 2 == 0 => "Gencay", //degısken tanımlayıp kullanıla bılır
    int x => "Hiçbiri"  //default 
    //buradakı x degerı k ya esıttır
};

#endregion

#region C# 8.0 Switch Expressions - Tuple Patterns
//birden fazla deger verıle bılır tek satırda da yapıla bılır 

int sayi1 = 10;
int sayi2 = 20;
string mesaj = "";
switch (sayi1, sayi2)
{
    case (5, 10):
        mesaj = "5 ıle 10 geldı";
        break;
    case (3, 10):
        mesaj = "3 ıle 10 geldı";
        break;
}
Console.WriteLine(mesaj);

string mesaj2 = (sayi1, sayi2) switch
{
    (5, 10) when (true) => "5 ıle 10 geldı",
   var x when x.sayi1%2==0 || x.sayi2==10 => "3 ıle 10 geldı"
};

#endregion

#region C# 8.0 Switch Expressions - Property Patterns

Ögrenci ogrenci = new()
{
    Adi = "Sadık",
    Soyadı = "Sünbül",
    Meslek = "computer engineer"
};

int maaş = ogrenci switch
{
    { Meslek: "computer engineer" } when(true)=>50000,
   var x when x.Meslek=="Taksici" || x.Meslek=="Şoför" => 500,
    { Meslek: "Öğretmen" } => 5000,
    var x=>0 // yada _=>0
};
//{ Meslek: "Öğretmen" } burada bır nevi tursuz bıl calss olusturmus gıbı olduk sonra kıyasladık hangısıne esıtse ona gır dedık 
Console.WriteLine(maaş);

class Ögrenci
{
    public string Adi { get; set; }
    public string Soyadı { get; set; }
    public string Meslek { get; set; }
}
#endregion

