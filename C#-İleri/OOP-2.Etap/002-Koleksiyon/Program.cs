

//koleksıyonlar deyınce bırden fazla verı gelmelıdır aklımıza 

//Neden dızıler var ıken koleksıyonları kullanıyoruz dızılerın bellı baslı sınırlılıkları vardı o yuzden kullanıcaz koleksıyonları 

#region Koleksiyon
//Koleksiyon nedir?
//C#ta koleksiyonlar, tıpkı diziler gibi birden fazla veriyi tek bir değişken içerisinde işlemek ve yönetmek için tutmamızı sağlayan veri yapılarıdır.
/*
peki hoca, diziler varken
neden koleksiyon denen bu
veri yapılarına ihtiyaç
duyulmuş ki?
Diziler, temel programlama süreçlerinde
ihtiyaç doğrultusunda oldukça kullanılan
veri yapılarıdır.

Diziler koleksıyonlara gore cok hızlıdır 
*/

#region Dizilerin sınırlılıkları
/*
 Diziler sabit boyutludur ve ılk tanımlanırken boyutunu verılmesı gerekir

dızı boyutunun manuel belırlenmesı bellek yonetımınınde manuel yapılması anlamına gelmektedir

ekeleme silme işlemi için index ustunden gerceklestırılmelidir buda karmasıklıga neden olabılir

Kolleksıyonlar bu sınırlılıkları kaldırmak ıcın *ortaya cıkmıstır 

diziler statik verı yapılarıdır 

koleksıyonlar dınamıktır 
 */
#endregion
#endregion

#region Koleksiyon Türleri
/*
 Koleksıyon lar; davranışları ve farklı
senaryolara karşın kullanımlarından yola
çıkarak Generic, Non-Generic ve
Specialized olmak üzere üçe
ayrılmakta dırlar.
 */
#region Generik kolleksiyonlar 
//System.Collections.Generic den gelir

/*
 Farklı veri türlerini depolayabilen ve tür güvenliği sağlayan koleksiyonlardır. Yani, bir generic
koleksiyon oluşturulduğunda bu koleksiyonun içindeki öğelerin türü, koleksiyonu oluştururken
belirtilen türle sınırlı olacaktır.
 */

//List<T> a;
//Dictionary<TKey, Tvalue>;
//HashSet<T>;
//Queue<T>;
//Stack<T>;
//LinkedList<T>;
//SortedList<T>;
//ObservableCollection<T>;

/*
 Generic koleksiyonlar, tip güvenliği sayesinde kod hatası riskini oldukça azaltmakta
performans açısından da diğer koleksiyonlara nazaran(tek türde çalıştıkları için) daha etki!i davranmakmdırlar.
 */

#endregion
#region Non-Generik Koleksiyonları
//Generic koleksiyonların tip güvenliği olmayan versiyonlarıdır.
//genellıkle object turle calısırlar

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Numerics;
using System.Xml.Linq;

//ArrayList a;
//Hashtable a;
//BitArray s;
//Queue q;
//Stack w;
//LinkedList a;
//SortedList a;

#endregion
#region Specialize Koleksiyonlar
// System.Collections.Specialized dan gelir

//Özel amaçlı davranış sergileyen ve sadece belirli senaryolara uygun olarak geliştirilen koleksiyonlardır.

//NameValueCollection a;
//StringCollection a2;
//StringDictionary a3;
//HybridDictionary a4;
//ListDictionary a5;
//OrderedDictionary a6;


#endregion
#endregion


#region List<T>
//c# da encok kullanıcağımız kolleksıyondur 
//Generic T parametresi koleksiyonun türünü belirtilen tür olarak ifade edecektir.
// Dizilerden farklı olarak boyutu otomatik olarak ayarlanabilmekte ve içerisine dinamik bir şekilde öğe ekleyip ve çıkarılabilmektedir.

List<int> numbers = new List<int>();
//ekle
numbers.Add(0);
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
//cıkar
numbers.Remove(2);
//boyununu ogren
var count = numbers.Count;
//öge ara
numbers.Contains(1);
//Diziye dönüştür
var arrayNumbers = numbers.ToArray();
#endregion

#region Dictionary<TKey,TValue>
//Dictionary koleksiyonu key — value formatında kümülatif veri saklayan bir koleksiyondur.
//Key unic olmalıdır benzersiz

Dictionary<int, string> datas = new Dictionary<int, string>();
datas.Add(1, "deneme1");
datas.Add(2, "deneme2");
datas.Add(3, "deneme3");
datas.Add(4, "deneme4");
datas.Add(5, "deneme5");
datas.Add(6, "deneme6");
datas[7] = "deneme7"; //index ustundeende ekleme yapılabılır
//degerı guncelleme
datas[2] = "DENEME 2";
//deger erısımı 
var i = datas[2]; //burada DENEME 2 getirir
var i1 = datas[3]; //burada deneme3 getirir
//Anahtar varlıgını kontrol etme 
datas.ContainsKey(2);
//Deger varlıgını kontrol etme
datas.ContainsValue("denem3");
//deher sılme 
datas.Remove(3);
//koleksıyon boyutu
var count1 = datas.Count;
#endregion

#region Queue<T>
//C# dilinde, ilk giren ilk çıkar(FlFO- First In Fırst Out) mantığında çalışan koleksiyondur.

//Bu koleksiyon, elemanların eklenme sırasına göre işlenmesini sağlamaküdır.

//Queue, mantıken bir kuyruk davranışı sergiler.

Queue<int> datas2 = new Queue<int>();
//deger ekle
datas2.Enqueue(1);
datas2.Enqueue(2);
datas2.Enqueue(3);
datas2.Enqueue(4);
datas2.Enqueue(5);
datas2.Enqueue(6);
//deger cıkarma degerı getırır ve siler
datas2.Dequeue();/*1*/
datas2.Dequeue();/*2*/
datas2.Dequeue();/*3*/
datas2.Dequeue();/*4*/
//ilk elemanı elde eder cıakrmaz peek

datas2.Peek(); // 5 ı geıtırr ama sılmez 

var count3 = datas2.Count;


/*
 Queue koleksiyonu, genellikle iş
parçacığı kuyruklarında, işlemlerin
sırasına göre işlenmesi gereken
senaryolarda ve verilerin sırasıyla
işlendiği diğer durumlarda oldukça
kullanışlıdır.
 */
/*
 İlk giren ilk çıkar mantığına dayalı olarak
çalıştığı için, bu tür senaryolarda
verilerin doğru sıra ile işlenmesini
sağlar.
 */

#endregion

#region Stack<T>
//C# dilinde, son giren ilk çıkar(LlFO — Last In First Out) mantığında çalışan koleksiyondur.

//Bu koleksiyon da tıpkı Queue koleksiyonunda olduğu gibi, elemanların eklenme sırasına göre işlenmesini sağlamaktadır.

//Ve yine Queue'da olduğu gibi Stack'de, mantıken bir kuyruk davranışı sergilemektedir.
Stack<int> ints = new();
//deger ekleme
ints.Push(1);
ints.Push(2);
ints.Push(3);
ints.Push(4);
ints.Push(5);
//deger cıkarma
ints.Pop(); //5
ints.Pop(); //4
ints.Pop(); //3
//üst elemana bakma
ints.Peek();
//koleksıyon boyutu
var count5 = ints.Count;

#endregion

#region LİnkedList<T>
//LinkedList, verileri birbirlerine bağlı düğümler(node) şeklinde saklamaya olanak tanıyan bir koleksiyondur.

LinkedList<int> lnklist = new();
//deger ekeleme
lnklist.AddFirst(3);
lnklist.AddFirst(2);
lnklist.AddFirst(1);
lnklist.AddFirst(4);
lnklist.AddFirst(5);
lnklist.AddFirst(6);
//deger cıakrma
lnklist.Remove(5);
lnklist.RemoveFirst();
lnklist.RemoveLast();
//özel noda erişim
var firstNode = lnklist.First;
var lastNode = lnklist.Last;
var firstNodeNext = firstNode.Next; //ileri
var lastNodePrev = lastNode.Previous;//geri

#endregion

#region SortedList<Tkey,Tvalue>
/*
 SortedLis 4T» koleksiyonu da key-
value tarzında veri tutan bir
koleksiyondur. Key'ler sıralı bir şekilde
tutulmakta ve bu sayede key'lere göre
hızlı erişim durumu söz konusu
olmaktadır.

SortedList koleksiyonunda key'ler
tekildir.

Ayrıca SortedList koleksiyonunda
önemli bir noküda kefleri sıralamak
için bir karşılaştırma işlemine ihtiyaç
duyulmasıdır.

Eğer koleksiyona eklenen key'lerin
sıralanmasını istiyorsanız, bu key'lerin
türüne uygun bir karşılaştırıcı
belirlemelisiniz.

Ya da key'e verilen türün default
olarak IComparable«T» interface'ini
uygulaması da beklenebilir.
 */
SortedList<int, string> deneme = new(new CustomComparable());
deneme.Add(0, "a");
deneme.Add(1, "b");
deneme.Add(2, "c");
deneme.Add(3, "d");




#endregion

#region SortedDictionary<Tkey,TValue>
/*
 SortedList«T» koleksiyonu da olduğu
gibi key-value tarzında veri tutan bir
koleksiyondur.

SortedList'ten en önemli farkı key'leri
sıralamak için bir karşılaştırma
işlemine ihtiyaç duymamasıdır.

Bu nedenle key'ler herhangi bir türe
uygun olarak eklenip direkt
sıralanabilir.

 */

SortedDictionary<int, string> deneme2 = new();
deneme2.Add(0, "a");
deneme2.Add(1, "b");
deneme2.Add(5, "c");
deneme2.Add(4, "e");
deneme2.Add(2, "d");
//deger cıkarma
deneme2.Remove(2);

/*
 SortedDictionary koleksiyonu, key'lerin
sıralı bir şekilde tutulması istendiÜ]ve
özel bir key sıralaması gerekmediği
durumlarda kullanılabilir.
 */
#endregion

#region ObservableCollection<T>
/*
 ObservableCollection; verilerin
eklendiği, çıkarıldığı veya değiştirildiği
durumlarda otomatik olarak izleme
yapan bir koleksiyondur.

Bu koleksiyon ile verilerde yapılan
değişiklikleri 'Event Notifications'
denen olay bildirimleriyle takip
edebilirsiniz.

Bu notifikasyonlar neticesinde,
CollectionChanged event'i tetiklenir.

Bu event sayesinde koleksiyona bağlı
olan bileşenlerin otomatik olarak
güncellenmesi sağlanabilir.
 */

ObservableCollection<int> ints1 = new();
ints1.CollectionChanged += (send, e) =>
{
    //kolleksıyonda yapılan degısıklıkler burada yakalanır
    //e.Action : degısıklık turunu belırtır
    //e.NewItem :Eklenen ögeyı ıcerırı
    //e.OldItem : cıkarılan ogeyı ıcerır
    Console.WriteLine(e.Action.ToString());
};
//deger ekleme
ints1.Add(3);
ints1.Add(5);
ints1.Add(6);
ints1.Add(7);
//deger cıkarma
ints1.Remove(3);
#endregion

#region ArrayList
//C#ın dizilerden koleksiyonlara evrilmenin ilk ara geçiş türüdür. hıc kullanmıycaksınız
/*
 İçerisinden farklı türlerden değerleri
Object olarak tutmaktadır. Haliyle
verilere boxing işlemini
uygulamaktadır.

boxin e bi tutulmuş verileri kendi
türlerinde kullanabilmek için
unboxing yapılması gerekeceğinden
dolayı pek önereceğimiz bir
koleksiyon değildir.

 */
ArrayList arrayList = new();
arrayList.Add(1);
arrayList.Add(2);
arrayList.Add(3);
arrayList.Add("dasaffsa");
//deger cıakr
arrayList.Remove(1);

#endregion

#region BitArray
/*
 BitArray; 0 ve I bitlerini saklayan ve b
bitler üzerinde işlemler yapmamıza
imkan tanıyan bir koleksiyondur.

Bu koleksiyon, boolean değerlerin
yerine geçen ve bellek kullanımında
avantaj sağlayan bir veri yapısıdır.
 */

BitArray data = new(3);
data[0] = true;
data[1] = false;
data[2] = true;
//dgere okuma
Console.WriteLine(data[0]);
Console.WriteLine(data[1]);
Console.WriteLine(data[2]);
//koleksıyon bıyutu
var size = data.Length;

BitArray data1 = new(3);
data[0] = true;
data[1] = false;
data[2] = true;
BitArray dataAnd = new(data);
dataAnd.And(data1); //data ile data 1 i andler


#endregion

#region NameValueCollection
/*
 NameValueCollection, key-value
formatınve veri saklayan ve key'leri
index'leyen bir koleksiyondur.

Bu koleksiyonda key ve value
değerleri direkt string olarak
tutulmaktadır.

e ellikle we .config,
appsettings.json vs. gibi
konfigürasyonel dosyalarda tutulan
yapılandırma verilerini kod kısmında
karşılamak ya da tutmak için k lanılır.

Bundan dolayı bu koleksiyon
içerisinde aynı key'e sahip olan birden
çok değer tutulabilir.

 */
NameValueCollection nameValue = new();
nameValue.Add("connectionstring", "...");
nameValue.Add("mail", "sadık.sunbul...");
//deger okuam
var value = nameValue["connectionstring"];
//tum keylerı okuma
var keys = nameValue.AllKeys;
//aynı key e karsılık bırden fazla deger okuma
var values = nameValue.GetValues("email");


#endregion

#region StringCollection
/*
 StringCollection, string değerleri
saklamak ve bu değerler üzerinde
kolayca işlem yapmak için kullanılan bir
koleksiyondur.

Bu koleksiyon ile key-value forma
gerek kalmaksızın sade ve sadece
string değerleri saklayabilirsiniz.

Yani bir nevi string diziler
yerine(string[ ]) tercih edilen
koleksiyondur diyebiliriz.
 */
StringCollection data6 = new();
//deger ekeleme
data6.Add("deger1");
data6.Add("deger2");
data6.Add("deger3");
data6.Add("deger4");
//degre okuma
var v1 = data6[0];
#endregion

#region StringDictionary
/*
 StringDictionary; sadece string
türünden değerleri key-value
formatında tutan bir koleksiyondur.

Hashtable koleksiyonunun string'e
özel bir türevidir diyebiliriz.

Key değerleri tekil olmalıdır.

Ayrıca Dictionary«TKey, TValue»
koleksiyonu varken bu koleksiyon
pek önerilmemektedir!
 */

StringDictionary stringDictionary = new();
stringDictionary.Add("key1", "value1");
stringDictionary.Add("key2", "value2");
stringDictionary.Add("key3", "value3");
stringDictionary.Add("key4", "value4");
//deger okuma
var stv1 = stringDictionary["Key1"];
#endregion

#region HybridDictionary (burası onemli işte)
/*
 HybridDictionary, birçok key-value
formatında değer tutan koleksiyonda
biridir. Amma velakin bu diğerlerine
nazaran hafızayı daha da iyi bir şekilde
yönetmek için optimize edilmiştir.

Hybrid ı ionary, arkaplanda belirli
bir eşiğe kadar basit bir dizi
kullanmaktadır. O eşik aşıldığı zaman
ListDictionary veya Hashtable gibi
daha verimli koleksiyonları kullanmaya
başlamaktadır.

Bo ce, küçük boyutlu
koleksiyonlarda düşük bellek tüketimi
ve performans avantajı sağlamakta ve
büyük boyutlu koleksiyonlarda ise
verimliliği korumaktadır.

Ve özellikle orta büyüklükteki
koleksiyonlar için ise iyi bir denge
sağlamaktadır.
 */

HybridDictionary hbrt = new();
hbrt.Add("key1", "value1");
hbrt.Add("key2", "value2");
hbrt.Add("key3", "value3");
//deger okuma
var hbrtv1 = hbrt["key1"];
var hbrtv2 = hbrt["key2"];
#endregion

#region ListDictonary
/*
 ListDictionary, düşük miktarda veri için
optimize edilmiş olan bir
koleksiyondur.

Küçük koleksiyonlar için etkili bir
şekilde çalışan davranışa sahiptir. Diğer
dictionary türlerindeki hızlı erişim ve
arama yeteneklerine nazaran düşük
bellek tüketimi ön plandadır.

Ve özellikle düşük veri setleri için
optimize edilmiş hafıza kullanımı
sunmaktadır.
 */

ListDictionary lstd = new();
//degre ekleem
lstd.Add("key1", "value1");
lstd.Add("key2", "value2");
lstd.Add("key3", "value3");
//deger okuma
var lstdv1 = lstd["key1"];

#endregion

#region Indexed Element Initialization
//boylede ekeleme ıslemı yapılabılır
List<int> asf = new()
{
    [1] = 1,
    [5] = 23
};

Dictionary<string, string> d = new()
{
    ["key1"] = "value1",
    ["key2"] = "value2"
};
#endregion
class CustomComparable : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x.CompareTo(y);
    }

}