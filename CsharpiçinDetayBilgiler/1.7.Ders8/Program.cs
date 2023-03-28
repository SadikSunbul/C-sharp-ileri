
#region  C# 8.0)Ranges and Indices Özelliği
//C# 8.0, Ranges and Indices özelliğini tanıttı. Bu özellik, bir dizinin belirli bir bölümüne erişmek için daha kolay bir yol sağlar.
#endregion

#region C# 8.0)Ranges and Indices - System.Index Türü
//dızı ve koleksıyon yapılarındakı index kavramının tip olarak belirlenmiş halidir

Index i = 3;   // 1   2   3  bastan 3. ındex demek
Index i1 = ^3; // 3   2   1  tersınden 3.ındex demek

//buradaku i i1 i [] içerisine vere biliriz

int[] sayılar = { 1,6,3,4,8,2,21,32,34,56,1,21,12};

//2 ye hem sagdan hemde soldan erısme 
Index sol = 5;
Console.WriteLine(sayılar[sol]);
Index sag = ^8;  //sagdan gelırken 1 den baslar 0 demeyız ılk elemanına
Console.WriteLine(sayılar[sag]);
//ıkısındede 2 degerını getırıcektır

#endregion

#region (C# 8.0)Ranges and Indices - System.Range Türü

//dızıde hangı aralıkla calısabılecegımızı belırtmek ıcın kullanılır operator .. ile gerceklestırılır

Range range = 3..7; //3. ındexten basla 7.sıra arasında olanı getırır range turunde doner 
//burada ilk sayı index tir ama 2. sayımız sıra sayısıdır


// 3..^6 dersek burda sondan 7 den baslar 6 yı almaz
//^6..^3 ustekı gıbı 6 degılde 7 den baslamaz bu sadece sag taraf takı degerler ıcın gecerli 

//[] icerisine range turude verilir
Range tum = ..;  //-->tum dızıye karsılık gelır
Range range1 = 3..7;
int[] deneme=sayılar[range1];
//yenı bır dızı olusturmus olduk bıurada
int[] deneme1 = sayılar[3..7]; //ustekı ıle aynı ıslemı yapar

#endregion

#region Çok boyutlu diziler

//oyun programlamada yuksek ıstatıstık calısmalarda kullanılan bır yapıdır

#region Çok Boyutlu Dizi Tanımlama
//type[,]  --> 2 boyutlu dızı tanımlama
//type[,,]  --> 3 boyutlu dızı tanımlama

int[,] cok=new int[3,5]; //3 kolon 5 satır gıbı dusun x ve y kordınatı ıle tahayur edıle bılır

int[,,] cok1 = new int[1, 3, 4]; // x   y   z

#endregion
#region Tanımlanmış Çok Boyutlu Diziye Değer Atama
int[,] cok2 = new int[3, 4];

cok2[1, 2] = 12;

int[,] cok3 = { {3,4,5 },{ 2,3,5} };//ıcındekı eleman sayıları esıt olmalı bırınde 3 bırınde 2 olamaz



#endregion
#region Çok Boyutlu Dizilerden Değer Okuma

Console.WriteLine(cok2[2,3]);
#endregion
#endregion

#region Düzensiz Diziler Nedir?
//dizi içerisinde dizi içeriyorsa duzensızdır
//cok boyutlu dızılerden tek farkı sutun sayısı farklı olabılıyor
//int[][]  --> ınt dızısı tutan dızıyı tutar 

//pek kullanılmaz

int[][] araydizisi = new int[3][] ;
araydizisi[0] = sayılar;
araydizisi[0] = new int[5] { 1,2,3,4,5};
araydizisi[0] = new int[2] { 7,8};

araydizisi[0][3] = 15; //0. dizinin 3. indexin degerını 15 yap dedık

//eleman sayısı bulmak ıcın herbırını tek tek toplamak gerekır

int totaldegerler=(araydizisi[0].Length+ araydizisi[1].Length+ araydizisi[2].Length); 
#endregion