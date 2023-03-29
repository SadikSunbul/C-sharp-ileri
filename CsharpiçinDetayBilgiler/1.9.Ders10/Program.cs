
#region String Fonksiyonları

#region Contains  ****
//metın ıcerısınde karakterın gecıp gecmedıgını kontrol eder
string metin = "sadık sunbul taha";
metin.Contains("sunbul"); //true doner burada 
#endregion
#region StartWith  ****
//verılen degerle baslıyormu 
metin.StartsWith("sa");
#endregion
#region EndsWith  ***
//verılen degerle bitiyormu
metin.EndsWith("ha");
#endregion
#region Equals  **
//eşit mi demek bool doner

Console.WriteLine(metin.Equals("mehmet")); //false doner esıt degıl 
Console.WriteLine(metin.Equals("sadık sunbul taha"));//true doner esıt cunkı
#endregion
#region Compare   ****
//karsılatırma yapar ınt doner 
//metınsel ıfadelerı karsılastırmamızı ve ınt turde deger elde etmemızı saglar
//0:her ıkı deger bırbırıne esıt
//1:sol dakı sagdakınden sıralmada ondeyse 1 doner yanı sol a sag b
//-1:sag dakı soldakınden sıralmada ondeyse -1 doner
//Bir tamsayı değeri döndürür. Her iki dizi eşitse, 0 döndürür. İlk dize, ikinci dizeden büyükse, 1 döndürür, aksi takdirde -1 döndürür
int sonuc =string.Compare(metin,"z"); //-1 degerını dondurur
int sonuc1 = string.Compare(metin, "a");//1 degerını dondrur 
#endregion
#region CompareTo
//Compare ıle aynı amac  kullanımı biraz farklı
metin.CompareTo("a"); //1
#endregion
#region IndexOf
//verılen degerın strıng ıfade ıcerısınde olup olmamasını ımt olrarak ındex noyu dondurur aratılan bır kelıme ıse ılk harfını indexini dondurur
//ıcınde yoksa -1 doner
Console.WriteLine(metin.IndexOf("a"));
Console.WriteLine(metin.IndexOf("sa"));
Console.WriteLine(metin.IndexOf("ta"));
//ilk eşleşen degerin indexini dondurur bırden fazla a var ama ılkını yakalar
#endregion
#region Insert  *
//elımızdekı metıne ıfadeye bır deger dahil etmemızı saglayan bir fonk
string metin2 = metin.Insert(17, "merhaba"); //17. indexten eklemeye baslar degerlerı kaydırı yana ezmez oradakı degrelerı
//ılgılı ekleme operasyonu gerceklestıkten sonra metın2 ıle metın ayrı ayrı dır metı nın yapısı bozulmaz eklenmıs halı metın2 ye atanır
Console.WriteLine(metin);
Console.WriteLine(metin2);
#endregion
#region Remove
//ılgılı verıyı sıler 
//strıng olarak doner orjınal verı degısmez
metin.Remove(5);//5. indexten sonrakı tum degrelerı sıler 5.ındex dahıl 
metin.Remove(5,10);//5. indexten basla 10 tane sıl

#endregion
#region Replace  **
//elımızdekı metınsel ıfadede belirtilen degerlerın yahut karakterlerın belırtıgımız dıger degerler ya da karakterler ile değiştirmemizi sağlar
//strıng doner
metin.Replace('a','b'); //a ların hepsını b yap dedık 
metin.Replace("sa", "so");//sa ların yerıen so koyar
#endregion
#region Split   *****
//elimizdekı metınsel ıfadeyı  verılen degerı ayrac olarak kullanıp parcalayan ve sonucu strıng dızısı olarak donduren bır fonktur

string[] metındızısı=metin.Split(' '); //bosluk karakterleri bulur dızı olarak doner
string[] metındızısı2 = metin.Split(' ','a');//hem boslukta bol hemde a karakterınde bol dedık burdada
#endregion
#region Substring *****
//elındekı bır metının belırlı bır aralıgını elde etmeızı saglar

metin.Substring(5); //5. indexten sonuna kadar butun karakterlerı getırır
metin.Substring(5, 6); //5.şndexten sonra 6 karakter getır

#endregion
#region ToLower
//tum karakterlerı kucuk karaktere dondurur
Console.WriteLine(metin.ToLower());
#endregion
#region ToUpper
//tum karakterlerı buyuk karaktere dondurur
Console.WriteLine(metin.ToUpper());
#endregion
#region Trim ***
// "ahmet"  "  ahmet "  boyle gırılen degerlerı "ahmet" gırılmesı gerekır boslukları sılerız
//sagındakı ve solundakı bosluk karakterlerını sıler
string metin5 = "   skjlbfkahs ";
Console.WriteLine(metin5.Trim());

#endregion
#region TrimEnd
//sonunu sıler
#endregion
#region TrimStart
//başını siler
#endregion
#endregion