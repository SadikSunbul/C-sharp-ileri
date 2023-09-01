
//Span Performans Canavarı mı?

// String vs Span<T>

//Stringler aslında referans tipl değişkenlerdir ama atama durumlarında bu böyle değildir normal bir değer tipli değişken gibi deep copy işlemi yapar

string name = "Sadık";
string lastName = name;

name = "SADIK";

Console.WriteLine(lastName); //çıktı:Sadık

/*
 stringin çalıma mantığı:

diyelimki string olarak "Merhaba" değerini tutyoruz buna += diyerek genişletmek istersek:

string deger="merhaba";ramBellek 101="Merhaba"

deger+=" ben"; ramBellek 102="Merhaba ben"

deger+=" sadık"; ramBellek 103="Merhaba ben sadık"

burada baktığımızda 3 farklı adreste değerler tutuluyor bu bıze malıyet yaratır
 */


string input = "This is an example sentence.";
ReadOnlySpan<char> inputSpan = input.AsSpan();


Span<char> a = new[] { 'A', 'B' };

a = "Sadık".ToArray();
a = "Sadık".ToCharArray();

string c=a.Slice(0, 2).ToString();
Span<char> c1 = a.Slice(0, 2); //bruada yeni bir alan olusturulmıycaktır bellek ısrafı yapmıyoruz

string isim = "Sadık";
var newName = isim.Replace("a", "A"); //bunu bır degıskene atamazsan ıslemın olmaz 





