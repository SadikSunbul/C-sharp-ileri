

using System.Collections;

ArrayList A = new(); //tur onemsız kaydeeder
A.Add("sadık");
A.Add(1);

ArrayList a1 = new();
a1.Add("taha");
a1.Add("osman");
a1.Add("furkan");

A.AddRange(a1);//A nın ıcerısıne a1 dekı degerlerını toplu kaydettik

Console.WriteLine(A.Capacity); //lıstenn ala bılecegı max deger kendısı deger geldıkce artırr
Console.WriteLine(A.Count);

Console.WriteLine("--------------");
Console.WriteLine(a1.Capacity);
Console.WriteLine(a1.Count);



object o1 = A[3];
string s1 = Convert.ToString(A[3]);
string s2 = A[3].ToString();
int ı1 = (int)A[1];


A[3] = "hamza atilla";

//deger silme remove

A.Remove("hamza atilla");
A.RemoveRange(1, 1);//1 ten baslayıp 1 tane degerı sıler
A.RemoveAt(3); //3. ındeksı sıler sadece



//array lıst sıralama
A.Reverse(); //en altakı ındeksı en uste gecırır tersteen sıralar

//A-Z ye sıralaa

A.Sort(); //a dan z ye sıralar ıcerıde ınt olmaması azım degılse hata verır

//z den a ya sıralarken ıl alfabetık sırala sonrada bastan sona sırala




//koleksıyonlar yardımcı konutlar


bool kontrol1 = A.Contains("osman"); //a ıcerısınde osmanı arar varsa true yoksa false
int index = A.IndexOf("taha"); //index degerını verır


A.Clear(); //a ıcerısındekı herseyı sıler
A.TrimToSize(); //capasıteyı 4 e lar azaltır  remde bos yer tutmaz
object[] d1 = A.ToArray();//bu lıstedekılerı dızıye dondurur

Console.ReadLine();
