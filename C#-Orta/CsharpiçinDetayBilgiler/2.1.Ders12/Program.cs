
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

// \   :Belirli karakter guruplarını içermesini istiyorsak kullanırız. Tek basına kullanılamaz

// \D  :Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiği belirtilir.
// \d  :Metinsel değerin ilgili yerinde 0-9 arasında tek bir sayı olacağı şfade edilir

//\W   :Metinsel değerin ilgili yerinde alfanümerik olmayan karakterin olması gerektığı belırtılır.Alfanümerik karakterler :a-z A-Z 0-9
// \w  :Metinsel değerin ilgili yerinde alfanümerik olan karakterin olacağı ifade edilir

//\S   :Metinsel değerin ilgili yerinde boşluk karakteri (tab/space) ışında herhangi bir karakterin olamayacağını belirtilir
//\s   :Metinsel değerin ilgili yerinde sadece boşluk karakterinin olacağı ifade edilir

//örnek;
//9 ile baslayan,2. karakteri herhangi bir sayı olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım
//^9\d\S 

string text1 = "912134sdafdafgadf";
Regex regex1 = new Regex(@"^9\d\S"); //3. karakter bosluk olmıycak dedık burada
Match match1 = regex1.Match(text1);

Console.WriteLine(match.Success);

#endregion

#region Regular Expressions Operatörleri + Operatörü
//Belirlenen  guruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanılan operatordur

//9 ile baslayan, arada herhangı bır sayısal degerı olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım

//^9\d+\S

string text3 = "912134sdafdafgadf"; //burada sonuncusu derken 4 den soraki değeri diyor bize bosluk olmadıgı ıcın s oldugu ıcın true doner 
Regex regex3 = new Regex(@"^9\d+\S");
Match match3 = regex1.Match(text1);

Console.WriteLine(match3.Success);

#endregion

#region Regular Expressions Operatörleri |(veya) Operatörü
//Birden fazla karakter gurubundan bir ya da birkaçının ilgili yerde olabileceğini belirtmek istiyorsak mantıksal veya operatorü kullanılır

//Baş harfı a ya da b yada c olan metınse ıfadeyı gırelım
//a|b|c


#endregion

#region Regular Expressions Operatörleri {n} Operatörü
//sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmeli7

//507-7514592    Telefon numarası
//\d{3}-\d{6} yazmalıyız

#endregion

#region Regular Expressions Operatörleri ? Operatörü
//Bu karakterin onune gelen karakter en fazla bir en az sıfır defa olabilmektedir.

// \d{3}B?A -->234BA, 5438A, 543A, 123BBA  //b ola bılır olmaya bılır kullanırsa en fazla 1 defa 

#endregion

#region Regular Expressions Operatörleri . Operatörü
// ilgili yerde herhangı bır sey kullanıla bılecegını belırtır
// tek kullanılmıycak ıfade \n dir


#endregion

#region Regular Expressions Operatörleri \b - \B Operatörleri
// \B : Bu ifade ile kelimenin başında ya da sonunda olmaması gereken karakterler bildirilir.
// \b : Bu ifade ilgili kelimenin belirtilen karakter dizisi ile sonlanmasını sağlar

//\d{3}dır\B  -->123dır(false),dır123(false),123dır2(true)

#endregion

#region Regular Expressions Operatörleri [n] Operatörleri
//[n] :Karakter aralığı belirtile bilir.
//Ayrıca özel karakterlerin yerinde yazılmasınıda ifade eder

//\d{3}[A-E]   --->ilk 3 karakter sayuı olsun sonrakı karakter A-B-C-D-E OLABILIR DEDIK 

//(507) 751 45 92  bu formatta alıcaksak 
//[(]\d{3}[)]\s\d{3}\s{2}\s\d{2} 

#endregion

#region Regular Expressions Match Sınıfı Özellikleri

Console.WriteLine(match.Success); //verı dogrumu onu bool turunden getırı
Console.WriteLine(match.Value);   //dogrulanan verıyı getırır
Console.WriteLine(match.Index);   // dogrulamanın hangı ındexten basladıgı bıldırır
Console.WriteLine(match.Length);   //dogrulama yapılan karakterın uzunlugunu verır

#endregion