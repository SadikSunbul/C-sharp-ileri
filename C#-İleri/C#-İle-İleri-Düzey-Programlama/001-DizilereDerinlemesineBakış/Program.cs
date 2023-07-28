
#region Diziler ne amaca hizmet eder
//Veri depolamaya yarar aynı verı turu depolar 
//veri işleme sıralama vb ıslemler
//verı yapısı olarak kullanılır
//Verı aktarımı yaparız gecıcı verı depolar
//Veri yapıları olusturabılırız

int[] arrat = new int[10];//[] indexer
int[,] array = new int[10, 1];//2 boyutlu bır dızı

int[,] deneme = new int[2, 3] { { 3, 4, 5 }, { 6, 7, 8 } };
//2 boyutlu bır dızı = matrıx

//Düzensız dızı ıcerısınde dızı tutan dızılere denir
#endregion

#region Düzensiz dizilerin cok boyutlu dızılerden farkı nedir
/*
 Boyutlar ve Dizi Yapısı

Düzensiz Diziler
İç içe gecmiş tek ve forklı uzunluktai dizilerin bir
dizi altında bir araya gelmesi ile meydana gelirler

Çok Boyutlu Diziler
iki veya daha fazla boyutta düzenlenen, tablo benzeri yapılar olustururlar

 */

/*
 Bellek Tüketimi
• Düzensiz Diziler
Farklı uzunluktaki alt dizileri desteklediGiçin daha esnek
olabilir. Ancak bu esneklik, ekstra bellek tüketimine yol
açabilir çünkü her bir alt dizi ayrı bir dizi olarak saklanır.

Çok Boyutlu Diziler
Tek bir bellek bloGunda düzenli bir şekilde saklanır, bu
nedenle bellek tüketimi açısından daha optimize edilmiş
yapılar sunabilirler.
 
 */
/*
 Erişim ve Performans
Düzensiz Diziler
Düzensiz dizilerde, alt dizilerin farklı UZt.mlükta olabilme
ihtimaline nazaran alt dizilerin elemanlarına erişmek için
daha fazla çaba harcamak(döngü kullanmak) gerekebilir. BU
performansı etkileyebilir.

Çok Boyutlu Diziler
Verilere erişim ve işlem yapmak düzenli dizilere nazaran
daha kolay ve düzenlice şa[lbnabilir.
 */
#endregion

#region Createınsyance metodu ıle dızı tanımlama
//Dınamık kodalamdır bu
int[] _dynamicArray = (int[])Array.CreateInstance(typeof(int), 5); //tek boyutlu bır dızının eleman sayısı verırız
int[,] _dynamicArray2 = (int[,])Array.CreateInstance(typeof(int), 5, 2); //ıkı boyutlu bır dızının eleman sayısı verırız

Array a = Array.CreateInstance(typeof(int), 5, 2);//boylede kullanılır
#endregion

#region Dizilerde yeni syntax
(int a, bool i, string b)[] d3 = new (int a, bool i, string b)[] {
(1,true,"Sadık"),
(2,false,"Tahiri"),
(3,false,"Ahmet")
};
#endregion