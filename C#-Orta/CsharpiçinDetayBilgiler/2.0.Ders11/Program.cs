using Microsoft.Extensions.Primitives;
using System;
using System.Text;

#region Dizilerde Verisel Performans Nedir?



int[] sayilar = {10,20,30,40,50,60,70,80,90,100 };
#region ArraySegment Türü Nedir?
//Bir dizinin bütününden ziyade belirli bir kısmına yahut parcasına ihtiyaç dahilinde ilgili diziyi kopyalamak yerine(ki görece oldukça maliyetli bir operasyondur) bağımsız bir referans ile erişmemizi ve böylece salt bir şekilde temsil etmemizi sağlayan bir yapıdır

#region ArraySegment Türü İle Dizinin Belli Bir Alanını Referans Etmek

ArraySegment<int> segment1 = new ArraySegment<int>(sayilar);//ctro ıcersıne attık referans ettık burada 
//dızının tum elemanlarını temsıl eder
ArraySegment<int> segment2=new ArraySegment<int>(sayilar,2,5);//2.indexten 5 elemana kadadr olanı tut dedık burdakı degısıklık aynı dızı ustunde oldugu ıcın malıyet ten kar etmnıs oluruz 

segment1[0] *=10; // sayilar[0] verı 100 olur
segment2[0] *= 10; //segment2 nın 0. ındexı 3 eleman 300 olur orası
#endregion
#region ArraySegment Slicing(Dilimleme) Özelliği
//bir dizi uzerınde bırrden fazla parcada calısacaksak eger her bır parcayı ayrı bir arraysegment olarak tanımlıyabılırız.bu tanımlamaların dısında diziyi tek bir arraysegment ile referans edip ilgili parçalarıo segment üzerinden talep edebiliriz.Yani ilgili diziyi tek bir segment üzerinden daha rahat bir şekilde parçalayabiliriz.bu durumda bize yazılımsal acıdan efektıflik kazandırmıs olur

ArraySegment<int> segment3 = new ArraySegment<int>(sayilar);
ArraySegment<int> bolme1 = segment3.Slice(0, 3); //boyle parcalaya bılrız
ArraySegment<int> bolme2= segment3.Slice(4, 7);  //40 ıle 70 arasını alır
#endregion

#endregion
#endregion

#region StringSegment Türü Nedir?
//StringSegment ,ArraySegment ın strıng degerler nezdindeki bir muadildir.
//esasında metınsel degerlerdekı bır cok analıtık operasyonlardan bizleri kurtaramakta ve substrıng vs. gibi fonksıyonlar yerıne strıng degerde hedef kesit uzerınde işlem yapmamızı saglayan bır turdur
string text = "ölüme gidelim dedin de mazotmu yok dedik";

#region StringSegment Türü İle Dizinin Belli Bir Alanını Referans Etmek
//StringSegment Türü kullancaksak Microsoft.Extensions.Primitives paketını ındırmelıyız
StringSegment segmentt = new StringSegment(text);
StringSegment segmentt1=new StringSegment(text,4,9);//4. ındexten 9 karaktere kadar

Console.WriteLine(segmentt1); //strıng gıbı ıstedıgımız yerde yazdıra bılırız

#endregion
#region StringBuilder Sınıfı Nedir? Ne Amaçla Kullanılır?
//StringBuilder Sınıfı arka tarafında StringSegment kullanır bu yuzden daha az malıyetlıdır
string isim = "Sadık";
string soyisim = "Sünbül";
Console.WriteLine(isim+soyisim);//maliyetlidir burasi
//StringBuilder strıng bırlestırme operasyonlarında + operatorune nazaran yuksek malıyeti abzorbe edebilmek için arkaplanda strıng segment algorıtmasını kullanan ve bu algoritma ile bizlere ilgili değerleri olabilecek ennn az maliyetle birleştirip döndüren bir sınıftır.

StringBuilder builder = new StringBuilder();
builder.Append(isim);
builder.Append(" ");
builder.Append(soyisim);

Console.WriteLine(builder.ToString());

#endregion
#endregion