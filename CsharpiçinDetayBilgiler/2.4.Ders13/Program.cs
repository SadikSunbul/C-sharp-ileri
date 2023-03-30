using System.Collections;

#region Koleksiyonlar Nelerdir? Diziler Varken Neden Koleksiyon Yapıları İnşa Edilmiştir?

//dizilerdeki sınırlılıklar burada yoktur
#region ArrayList Koleksiyonu

#region ArrayList Koleksiyonu Tanımlama
//dizilerde kaç eleman tutucakları yazıldı ama koıleksıyonlarda yaılmaz cunkı kendısı gelen elemana gore degerlerını artırırlar
int[] yaslar = new int[17];//dizi

ArrayList _yaslar = new ArrayList();//koleksıyon

#endregion
#region ArrayList Tanımlanmış Koleksiyona Değer Atama
yaslar[2] = 5; //0.-1. ındexler bos kaldı
_yaslar.Add(0);//0 degerı atandı uygun yere kendısı yerlestırır
#endregion
#region ArrayList Tanımlanmış Koleksiyondan Değer Okuma
//benzer sekılde yapılır okuma ıslemlerı
Console.WriteLine(yaslar[0]);
Console.WriteLine(_yaslar[0]);

#endregion
#region  ArrayList Boxing - Unboxing Durumlarından Dolayı Sınırlılıklar
//arraylıst verılen datayı boxıng ıslemıne tutar 
//arraylıst ıcerısındekı herahngı bır verıyı talep etıgımız zaman object olarak gelıcektır dolayısıyla kendı turunde islem yapabılmek ıcın unboxing işlemıne  tabı tutmamız gerekır  buda bır malıyettır aslında
int toplam = 0;
for (int i = 0; i < _yaslar.Count; i++)
{
    toplam += (int)_yaslar[i];//unboxıng yapmak gerekır bu malıyettır 
}

#endregion
#region ArrayList Collection Initializers(Koleksiyon İlklendirici)

ArrayList arrayList1 = new()
{
    "asfsdga",
    12,
    123,
    "safsdg",
    true,
    'a'
};

#endregion
#endregion
#endregion

#region İterasyon Nedir?
//Mantıksal acıdan her tahmının altında bır ıtarasyon mantıgı yatar
// 1  3  5   7 yı sız dedınız devamını sız getırebılırsınız

//verılerı tek tek elde etmemızı saglar
#region İterasyon ile Döngü Arasındaki Fark Nedir?
//Foreach bır dongu degıldır  
//elındekı verı kumesı degısırse forech patlar hata verır

int[] sayılar4 = { 1, 2, 3, 4, 56, 7, 56, 89, 77 };

for (int i = 0; i < sayılar4.Length; i++)
{

}
#region Foreach İterasyonu Nasıl Kullanılır?

foreach (var item in sayılar4)
{

    Console.WriteLine(item);
}

#endregion


#endregion
#endregion