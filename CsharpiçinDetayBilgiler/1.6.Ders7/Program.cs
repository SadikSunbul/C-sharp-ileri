

#region diziler - Arraylar
//diziler referans turludur  --> Ramde heap te tutuluyor
//ozlerınde claslardır
//dizi içerisine her turlu deger konula bılır deger veya referans turlu degreler konula bılır ama dzı turu in ise içerisinde sadece int turlu olucaktır strıng konulamaz
//Aynı mahıyette olmalı bırının yasını bırın masını tutmamalıyız 
//dizilered eklenen elemanşar index ismini verdıgımız numaralarlaardısık bı sekıle sıralanırlar


#region Dizi nasıl tanımlanır 
// typ yanına [] bu konursa --> typ[] o turden bır dızı olustruru
//typ[] name=new typ[];
//KESINLIKLE BILINMESI GEREKEN BIR KONUDUR DIZIYI BILMIYEN BIRI YAZILIMCI OLAMAZ    
int[] yaslar = new int[20]; //20 elemanlı olsun dedık
                            //eleman sayısı bos olamaz mecbur gırılmelıdır bu bır sınırlılıktır 
//dızının uzunluug ılk basta belırlenır sonradan degıstırılemez bu da bızım ıcın bır sınırlılıktır

//Nesne yani dizi heap te tutulur 

//verilen eleman sayısı kadar eleman tahsısınde bulunur ıstersen dızıye 1 eleman koy 10 alanlık yer ayırdıysan bosu bosuna yer tahsıs edıcektır bu da bıze sınırlılık getırır  buradakı sınırlılıklar koleksıyonlarda kalkıcak

//ilgili bos alanalra turune ozgu default degerlerını atarlar

#region dizilere Deger Atama
//dizilere deger atanırken ındex numarasından yararlanılır

yaslar[0] = 12;  //0. ındex ın degerıne 12 yı vr dedık 
yaslar[1] = 13;
//gibi deger atamaları yapıla bılır
//dizilerde eleman sınırını asamazsınız
yaslar[21] = 235; //çalışma zamanında hata verıcektır cunku dızımızde boyle bır yer yok sınırı aştık 

#endregion
#region deger okuma
Console.WriteLine(yaslar[0]);
Console.WriteLine(yaslar[17]); //deger gırmesekte default deger ı gıtırır bıze
#endregion

Console.WriteLine(yaslar.Length); //dızının eleman sayısını donduru bıze 

/*
 C# programlama dilinde, bir koleksiyondaki öğe sayısını elde etmek için "Count" özelliği kullanılırken, bir dizi veya diziye benzer bir yapıdaki öğe sayısını elde etmek için "Length" özelliği kullanılır.
 */


#region Dizi tanımlamadakı varyasyonlarımız

//varyasyon 1

int[] degerler=new int[20];

//varyasyon 2  --> drekt degrler atanıcaktır ılerıde buraya deger ataması yapılamaz çünki eleman sayısı dolduy zaten 

int[] yaslar1 = {2,3,45,6 };  //kendısı length ını 4 yapıcak 
string[] isimler = { "sadık", "Taha", "Ahmet" };

//varyasyon 3 -->

int[] yaslar2 = new int[] { 2, 3, 45, 6 }; //aynı sey kendısı tanımlar uzunlugunu felan

//varyasyon 4 -->

int[] yaslar3 = new int[3] { 1,2,3};//eleman sayısı atandıysa hepsının atanması gerekır degılse hata verıcektır ,

//varyasyon 5 -->

int[] sayılar6 = new[] {3,5,7 };

var sayılar7 = new[] { 3, 5, 7 };



#endregion
#endregion

#endregion

#region Array sınıfı

Array degerler5 = new int[3];  //index ıra gerek yoktur burada
                               //dizi olarak tanımlanan degısıklıkler array sınıfından turetılmektedır.
                               //dızıler array sınıfından gelen metotlar ve ozellıkler mevcuttur
                               //array seklınde ıse fonksıyonel cozumler getırılmektedır

#region Array Türünden Dizilere Değer Atama Okuma
Array dizi = new int[3];
//dizi[0] = 12; //yapılamaz

#region Yontemler
//yontem 1
int[] dizi2 = new int[3];
dizi2[0] = 123;
dizi2[1] = 21;
dizi2[2] = 123345;

Array dizi3 = dizi; //boyle atama yapıla bılır

//yontem 2

Array dizi7 = new int[] { 2,3,5,6};
Array dizi8 = new int[4] { 2, 3, 5, 6 };
Array dizi9 = new[] { 2, 3, 5, 6 };
//Array dizi10 = { 2, 3, 5, 6 }; //kullanılamaz burası

//yontem 3
Array dizi11 = new int[3];
dizi11.SetValue(30, 0); //0. ındexe 30 degerını atadık burada
dizi11.SetValue(31, 1);
dizi11.SetValue(32, 2);

object value=dizi.GetValue(1); //degerı boyle okuruz
#endregion


#endregion

#region Methotlar
#region Clear
//dızı ıcerısındekı tum elemanları sılıyor dıye bılınır ama dızının elemanlarında dızının turune uygun default degerlerı atar aslında
//strıngı clear dersek \0 degerı atanır
Array.Clear(isimler, 0, isimler.Length);//0. ımdexten sonuna kadar default degerlerı ata dedık 

#endregion
#region Copy
//elımızdekı bır dızının verılerını baska bır dızıye kopyalanmasını saglayan bır fonksıyondur

//Array = dizi

string[] isimler3=new string[isimler.Length];
Array.Copy(isimler, isimler3, isimler.Length);
//isimler dekını isimler3 e kopyaladık 

Array.Copy(isimler,2,isimler3,0,2); //isimler de 2. ındexten basla isimler 3 un 0. ındeksınden basla 2 eleman kopyala dedık


#endregion
#region IndexOf
//dizi içerisinde  eleman aramamızı saglar
Array.IndexOf(isimler, "Rıfkı"); //bu deger var ıse du elemanın ındex degerını dondurur eger boyle bır eleman yok ıse -1 degerını dondurur

Array.IndexOf(isimler,"Rıfkı",0,3); //ismler içerisinde rıfkıyı 0. ındex ıle 3. ındex arasında ara dedı

#endregion
#region Reverse
//elemanların tersıne sıralar 

Array.Reverse(isimler3);
Array.Reverse(isimler3,0,3); //0 dan 3 e kadar olan elemanları tersıne cevırır


#endregion
#region Saort
//dizinin elemanlarını sıralar kucukten buyuge dogru a dan z ye 

Array.Sort(isimler3);


#endregion
#endregion

#region Özellikler

#region IsReadOnly
//elımızdekı dızınnın sadece okunabılırlıgını kontrol eder

Console.WriteLine(isimler3.IsReadOnly); //false doner cunku hem okunur hem yazıla bılır


#endregion
#region IsFixedSize
//eleman sayısının sabıyt olup olmamasını gosterır dızılerde hep true doner cunku hep sabıttır

Console.WriteLine(isimler3.IsFixedSize);


#endregion
#region Length
//dızıın eleman sayısını dondurur

Console.WriteLine(isimler3.Length);

#endregion
#region Rank
//derecesını dondurur

Console.WriteLine(isimler3.Rank); //1 gelıcektır

//derecelı dızı olusturma 
int[,,] x=new int[3,5,6];

Console.WriteLine(x.Rank); //3 gelıcektır

#endregion
#endregion

#endregion

#region  Array Sınıfı - CreateInstance Metodu İle Dizi Tanımlama
//aslında normal olusturdugumuz dızıler arka tarafta CreateInstance methodunu cagırır
int[] yaslarr1 = new int[3];
Array yaslarr2 = Array.CreateInstance(typeof(int), 3);  //ustekı ıle aynı ısı gorur

//derecelı dızı tanımlama
Array yaslarr3 = Array.CreateInstance(typeof(int), 3,5,6,7);
#endregion



#region Koleksiyonlar
/*
1-> List<T>: Bir listede, sıralı olarak depolanan öğeler koleksiyonudur.

2-> Dictionary<TKey, TValue>: Bir sözlük, anahtar-değer çiftleri koleksiyonudur.

3-> Queue<T>: Bir kuyruk, öğelerin sırayla eklenip çıkarıldığı bir koleksiyondur.

4->  Stack<T>: Bir yığın, öğelerin üst üste eklendiği ve son öğenin ilk öğe olarak çıkarıldığı bir koleksiyondur.

5-> HashSet<T>: Bir küme, benzersiz öğelerin koleksiyonudur.

6-> LinkedList<T>: Bir bağlı liste, bir sonraki öğenin adresini tutan öğelerin koleksiyonudur.

7-> SortedList<TKey, TValue>: Bir sıralı sözlük, anahtar-değer çiftleri sıralı olarak depolanan bir koleksiyondur.

8-> ObservableCollection<T>: ObservableCollection, ObservableCollection<T> öğeleri üzerinde değişiklik yapıldığında otomatik olarak bildirim gönderir.
 */
#endregion

#region Kolleksıyonlar
/*
 C# programlama dilinde kullanılan koleksiyon sınıflarının bir listesini ve ilgili dokümantasyon linklerini aşağıda bulabilirsiniz:

ArrayList: Nesnelerin dinamik olarak eklenebildiği ve çıkarılabildiği diziler için bir koleksiyon sağlar. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-6.0

BitArray: Boolean değerlerinin sıkıştırılmış bir şekilde depolandığı bir dizidir. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.bitarray?view=net-6.0

Hashtable: Anahtar-değer çiftleri için bir koleksiyon sağlar. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.hashtable?view=net-6.0

Queue: İlk giren ilk çıkar mantığıyla elemanları tutan bir koleksiyondur. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.queue?view=net-6.0

Stack: Son giren ilk çıkar mantığıyla elemanları tutan bir koleksiyondur. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-6.0

SortedList: Anahtar-değer çiftleri için sıralı bir koleksiyon sağlar. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.sortedlist?view=net-6.0

Dictionary: Anahtar-değer çiftleri için bir koleksiyon sağlar. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0

List: Öğelerin sırayla depolandığı bir koleksiyon sağlar. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0

LinkedList: Birbirine bağlı düğümlerden oluşan bir koleksiyon sağlar. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-6.0

HashSet: Tekrar eden öğelerin bulunmadığı bir koleksiyon sağlar. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-6.0

ObservableCollection: Veri değişikliklerini takip ederek veri değişikliklerini bildiren bir koleksiyon sağlar. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1?view=net-6.0

ConcurrentDictionary: Aynı anda birden çok iş parçacığı tarafından güvenli bir şekilde kullanılabilecek bir sözlük sağlar. Dokümantasyon: https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2?view=net-6.0

Bu sınıfların tamamı System.Collections ve System.Collections.Generic
 */
#endregion