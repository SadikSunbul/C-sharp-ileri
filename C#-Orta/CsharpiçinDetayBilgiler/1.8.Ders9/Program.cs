
#region String Türü ve String Gerçeği
//strıng referans turlu oldugu halde programlama dılınde bır keyvorde karsılık gelen tek degerdır

int a = 5;  //deger turlu stac de tutulur
string b = "Hilmi";  //referans turlu burası o zamn heap de tutulur



#endregion
#region Null - Empty Durumları, Farkları

#region Null

//bellekte karsılıgı yoktur yer tahsıs etmez
string q = null;

//arsa yok
//deger turlu degıskenler null alamazlar sadece referans turluler null alabılırler

int? y = null; //boyle alabılır

//Null ustunde ıslem yaparken hata verıcektır ama empty de hata vermez

#endregion

#region Empty

//Bır degısken nullable referans eger kı emty ıse bu degısken dgeri yok anlamına gelır alan tahsısınde bulunur ama deger konulmaz ıcerısıne
//arsa var ama ev yok
//tum degerlere emty atanabılır
string w = "";
string t = string.Empty;
//ıkısıde aynı seye karsılık gelır

int a1 = 0;
//default durumlar emty olarak nıtelendırılır

int[] x = new int[55];

#endregion

#region IsNullOrEmpty
//elımızdekı strıng ıfadelerın işleme tabı tutmadan once kesınlıkle kontrol edılmesı gerekmektedir

string u = "";

if (!string.IsNullOrEmpty(u)) //x!="" da olur x!=null gibi seylerı kısaltır
{
    //operasyon...
}

//IsNullOrEmpty fonk elımızdekı strıng ıfadenın null yahut empty olup olmama durumları hakkında bır chack yapar ve bool turunde sonuc doner.

//bool doner deger null ya da emty ıse true doner degılse false doner


#endregion

#region String İfadelerde IsNullOrWhiteSpace Kontrolü
string p = "   ";  //bosluk oluncada bız ıstemeye bılırız
//null empty veya bosluk durumlarını kontrol eder 
//burada bosluk dereken "sadık sunbul" dekı bosluktan bahsetmıyoruz ful ıcerısı bosluk sa c# bunun empty oldugunu anlıyamaz 
if (!string.IsNullOrWhiteSpace(p))
{

}
else
{
    //bosluk oldugu ıcın buraya duser 
}



#endregion


#endregion
#region String özünde bir char dizisidir
//strıng ıfadeler esasında char dızısıdır yazılım acısından strıng ıfade yoktur char dızısı olarak algılanırlar ve oyle tutulurlar

//strıng ıfadeler ozunde dızı oldukları ıcn referans turludurler cunku dızılerde referans turlu ıdı  yanı nesnelerdır yanı heap te tutulurlar
string metin = "sebesız bos yere ayrılcaksan ...";
//strıng ıfadeler char dızısı oldukları ıcn dolayısıyla yapısal olarak her bir karakter bastan sona otomatık indexlenmektedir dolayısı ıle strıng bır ıfade uzerınde ındex operatoru kullana bılrız

Console.WriteLine(metin[3]);
Console.WriteLine(metin.Length);
// Array array = metin;  //strıng ozunde bır char dıszısı olabılır ama velakin yapısal olarak yinede string olduğu için array referansına atılmaz array ile karsılanamaz!!

#endregion
#region String Formatlandırma

string isim = "sadık", soyisim = "Sünbül", tcno = "76584231";

int yas = 19;

bool medenihal = false;

#region + OPERATORU
Console.WriteLine(tcno + isim + soyisim + yas + medenihal);
#endregion
#region String Değeri string.Format Metodu İle Formatlandırma
//string.format

string sonuc = string.Format("tcno:{0} olan {1} {2} şahsın bilgileri| yaş:{3}|medeni hali:{4}", tcno, isim, soyisim, yas, medenihal ? "Evli" : "Bekar");

#endregion
#region String Değeri $(String Interpolation) Operatörü İle Formatlandırma

string sonuc1 = ($"tcno:{tcno} olan {isim} {soyisim} şahsın bilgileri| yaş:{yas}|medeni hali:{(medenihal ? "Evli" : "Bekar")}{{Metınsel}}");

//{{Metınsel}} burada ezer orayı metınde {Metınsel} yazar

#endregion
#endregion
#region String Değerlerde (Escape)Kaçış Karakterleri
/*
 yaygın olarak kullanılan kaçış karakterleri ve işlevleri:
\o:null sonlandırma karakterı
\a:bip sesı cıkarır
\n: Yeni satır karakteri
\t: Sekme karakteri
\r: Satır başına dönüş karakteri
\b: Geri alma karakteri
\f: Sayfa sonu karakteri
\v:dıkey tab
\': Tek tırnak karakteri
\": Çift tırnak karakteri
\ooo: 8'li karakter dizisi, ooo sekizli sayı dizisindeki karakteri temsil eder.
\xhh: 16'lı karakter dizisi, hh onaltılı sayı dizisindeki karakteri temsil eder.
\uXXXX: Unicode karakter kodu, XXXX onaltılı sayılarla kodlanmış karakteri temsil eder.
 */

//  \ kacıs karakteri kendısınden sonra gelen karakterin özel bir karakete olmadıgını belırtır
Console.WriteLine("sadık \\ sünbül");

#endregion
#region String Türlerde @(Verbatim Strings) Operatörü
#region Kullanım 1
//bir degısken veyahut metot vs. gibi yapılanma isimlerinin programatik bir keyworde karsılık gelmesı mumkun degılsır aksı takdırde derleyıcı hatası verır egerkı ılla ben keyword ısmı kulancaksam @kullanıla bılır

int @void = 5;

#endregion
#region Kullanım 2
string metın5 = "Hava cok  \"guzel\"";
string metin6 = @"Hava cok  ""güzel"""; //kendısıyle ezdırıryor @
#endregion
#region Kullanım 3
string metin11 = @"şashldgkfgdasfasf
                    asfgsghddhjfgh
                    dfgjhfhkg
                    hjgkl
                    jhkşlkj ";
//bunu boyle yazıcakdır ekrana entrlı sekılde
#endregion
#endregion
#region String Interpolation İle Verbatim String Birlikteliği (C# 8.0)
//tek kural sıralaması
string maılmesaj = $@"alsdfjkhgas {isim}
                        asjkfhkasfsaf
                        asfgsdgda
                        ";
#endregion
//params sınırsız gırılecek demek