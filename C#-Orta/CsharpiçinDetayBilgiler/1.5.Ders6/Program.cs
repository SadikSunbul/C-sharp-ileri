


#region Yardımcı manevratik komutlar

//kodun yonlendırmelerını daha efektıf daha guzel yapmamızı saglar


#region Manevratik Komutlar - break Komutu Nedir?
//1. switch case de ve 2. dongulerde kullanılır
//kullanıldıgı yapıyı sonlandırır cıkıs yapar / kullanımı --> break;
int k = 0;
switch (k)
{
    case 1:
        break;
    default:
        break;
}

for (int i = 0; i < 19; i++)
{
    break;
}
while (true)
{
    break;
}
int[] z = new int[] {1,2,3,4,5,6,7,8 };

foreach (var item in z)
{
    break;
}
do
{
    break;
} while (true);
//bunlarda kullanıla bılır

do
{
    if (true)
    {
        break; //buradada kullanılır sonuc olarak bır dongunun ıcerısınde
    }
} while (true);

#endregion

#region Manevratik Komutlar - continue Komutu Nedir?
//sadece dongulerde erısılır 
//amacı devamet demek o ankı turu atlar bı sonrakı tura atlatır senı
//kendısınden sonrakı komutları ıslemez en basa doner

for (int i = 0; i < 10; i++)
{
    if (i%2==0)
    {
        continue; //buraya gırerse burdan sonrasını calstırmadan basa doner
    }
    Console.WriteLine(i);
}

#endregion

#region Manevratik Komutlar - return komutu nedir?
//Methot =fonk  ıcersınde heryerde kullanıla bılır erısıle bılrı
//1. nerede cagrılırsa ılgılı methodu keser cıkıs yapar
//2. gerıye deger dondurmek ıcınde kullanılır
//dongulerle bı alakası yok 

return; //her yerde gelır 



#endregion

/*
Console.WriteLine("Programı sonlandırmak için bir tuşa basın...");
Console.ReadKey();
"Console.ReadKey()" metodu kullanıcının herhangi bir tuşa basmasını bekler ve programın kapatılmasına izin verir.
enrt a basmadan kendısı kapatır
*/

#region Manevratik Komutlar - goto komutu nedir?
//akısı bozdura bıır 
//kodun senkranızasyonunu bozup ters ıstıkamede gıtmesını saglayan manevraık bır keyvordudur davranıssal olarak dongulere benzer
// her yerde kullanıla bılır

Referans:




goto Referans; //akısı 91 . satıra dondurur...

//pek kullanılmaz ama dedikoduları

//tavsıye edılmez
//teknık olarak programı yavaslatmaktadır hatta yapılmıs performans testlerını ınceledıgımızde performans kaybı vardır
//goto yerıne while kullansan while daha az malıyetlıdır
//iyi bir c# programcısı gerekmedıgı surece kesınlıkle goto anahtar sozcugunu kullanmamalıdır



#endregion

#endregion