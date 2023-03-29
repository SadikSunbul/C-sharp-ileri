
//cok cok ılerı seviyedeki konular

#region Span, ReadOnlySpan, Memory ve ReadOnlyMemory Türleri Nedir? Nasıl Kullanılır?
//pointer işlemleri gibi burası cok cok ust duzey bır konu ılerıde ayrı bı sekılde detaylandırıcam

using System.Text.RegularExpressions;

int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

Span<int> span = new Span<int>(sayilar);
Span<int> span2 = sayilar; //ustekı ıle aynı
Span<int> span3 = new Span<int>(sayilar, 3, 5);//3den basla 5 tanesını al 

Span<int> span4 = sayilar.AsSpan();
Span<int> span5 = sayilar.AsSpan(3, 5);


string text = "ölüme gidelim dedin de mazotmu yok dedik";
//sadece span olmaz strınglerde hata verır
ReadOnlySpan<char> readonlyspan= text.AsSpan();
ReadOnlySpan<char> readonlyspan1 = text;


#endregion

#region Regular Expressions(Düzenli İfadelerde) Neyin Nesi?

//Metinsel yapılanmalarda belirli koşulları sağlayabilen ifadelerdir

//Metinsel ifade içerisinde ihtiyaca istinaden düzenlenirler

//ornek : bir metin ıcerısınde @ karakterı gecen butun aralıkları elde etmek ıstedıgımızde 
// text="saflyka@alsıfgkh@alfjksghjafs";
//dikkat edersenız bu degerlerdde karakterlerın uzunlugu ve ne oldugu onemlı degıldır yeterkı @ karakterı olsun 

//Peki bız bunu nasıl bulucaz
//donguler kullanıla bılır ama sartlar artarsa kod malıyetı artar

//Her email adresi mutlaka @ ve ardından.(nokta) karakteri barındırır egerkı bırden fazla nokta varsa,noktalardan biri mutlaka @ karakterınden sonra olmalıdır    --->sadık.sunbul@shakjfhasgj.com


//Regular ifadeler System.Text.RegularExpressions namespacei altındakı Regex sınıfı tarafından temsıl edılmektedır
//sadece c# ozgu degıllerdır 
//Düzenli ifadeler baslı basına bır konudur Ya hayat kurtarırlar ya da ömür törpülerler


#endregion

#region Regular Expressions Operatörleri ^ Operatörü, Regex Sınıfının Kullanımı

//^ Operatoru : Satır basının ıstenılen ıfade ıle baslanmasını sagalr

//^9 : 9aksfgkş,92353kjghh,asfsdg sf(hatalı)

string text2 = "9198675847ghfkasjf";

Regex regex = new Regex("^91");//burada sartı yazdık sana gelen ıfade 91 ıle baslamalı dedık

 Match match=regex.Match(text2);

bool konrol=match.Success; //bool doner burası uste kontrol etıgı metnın degerını


#endregion

#region  Regular Expressions Operatörleri \ Operatörü

// \   :Belirli karakter guruplarını içermesini istiyorsak kullanırız.

// \D  :Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiği belirtilir.
// \d  :Metinsel değerin ilgili yerinde 0-9 arasında tek bir sayı olacağı şfade edilir
//\W   :Metinsel değerin ilgili yerinde alfanümerik olmayan karakterin olması gerektığı belırtılır.Alfanümerik karakterler :a-z A-Z 0-9
// \w  :Metinsel değerin ilgili yerinde alfanümerik olan karakterin olacağı ifade edilir
//\S   :Metinsel değerin ilgili yerinde boşluk karakteri (tab/space) ışında herhangi bir karakterin olabileceği belirtilir
//\s   :Metinsel değerin ilgili yerinde sadece boşluk karakterinin olacağı ifade edilir

#endregion