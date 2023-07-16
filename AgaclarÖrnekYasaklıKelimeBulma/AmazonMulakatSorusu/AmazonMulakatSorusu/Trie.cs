using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMulakatSorusu
{
    internal class Trie
    {
        public bool IsEndOfWord { get; set; } //Birkelimenın son harfimi
        public Dictionary<char, Trie> Children { get; set; } = new();
        //Dictionary<char, Trie> ifadesi, her bir harfin bir düğümü temsil etmesi için kullanılır. Harfler (anahtarlar), Trie yapısındaki çocuk düğümleri (değerler) ile eşleştirilir. Böylece, hızlı bir şekilde harflere karşılık gelen düğümlere erişebiliriz.

        public void Add(string word)
        {
            Trie current=this;//içinde bulundugumuz treiden başalr
            foreach (var c in word)
            {
                if (!current.Children.TryGetValue(c,out var child)) //burada currentın cocuklarına arasında ilgili c harfı varmı yokmu ona bakıyoruz yok ıse gır ve olustur var ise o har onun adresini childe atar
                  //TryGetValue()  belirtilen anahtarın sözlükte bulunup bulunmadığını kontrol eder ve anahtarın değerini döndürür.
                {//out var child bunun eklenmesi olusturulan yeni cocugu dısarıdan erısebılmek
                    child =new Trie(); //yenı boş trie olustur
                    current.Children.Add(c,child); // c de gelen harfi yeni boş trie ekle
                }
                current = child; //yeni cocuga giriyoruz artık
            }
            current.IsEndOfWord = true; //burada current dedıgımız en son harf olmus olur onun bır kelımeyı temsıl etıgını bıldırmek gerk 
        }

        public bool ContainsWord(string word) //içeriyormu
        {
            Trie current = this; //içinde bulundugumuz treiden başalr
            foreach (var c in word) //strıng ıcındekı charları gez
            {
                if (!current.Children.TryGetValue(c,out current)) //aradıgımız yok ıse gır buraya 
                {
                    return false; //hata dondur aranan kelıme yokk de
                }
                
            }
            //burada bızım strıngın son harfıne gelrıız onun ısaretlımı yoksa degılmı ona bakarız
            return current.IsEndOfWord; //son kelıme bızım ıcın son harfmıdir onun kontrolu donsun drekt
        }

        public bool Remove(string word)
        {
            var kontrol = ContainsWord(word); //ilk once bu kelıme burada varmı onun kontrolu yapılır
            if (!kontrol) return false; // yok ıse hata frılatır
            Trie current = this; //içinde bulundugumuz treiden başalr
            Trie ayrılmaharfi = this; //ayrılma noktası tutulcak
            int i = 0; //sayma işlem, 
            int ayrılmaharfininsayısı = 0;//ayrılmaya kadar olan sayı
            foreach (var c in word) //strıng ıcındekı charları gez
            {
                if (current.Children.TryGetValue(c, out var child)) //aradıgımız harf var ise
                {
                    i++;
                    if (child.Children.Count>1)// yani farklı bi yere bağlantısı var ise gir sadık s-a-d safa s-a-f
                    {
                        ayrılmaharfininsayısı = i; //ayrılma harfıne kadar olan sayıyı tutuyorum 
                        ayrılmaharfi = child; //ayrılma harfıni atıyoruz burası sureklı degıscek bıze zaten en son ki ayrılma harfı gereklı zaten 
                    }
                }
                current = child;//sonrakı harfe gec
            }

            current.IsEndOfWord=false; //Ne olur olamz dıyerekten cumlenın sonunu false yaptık
            char data=word[ayrılmaharfininsayısı]; //gelen kelimede hangi harfin ayrılma sayısının 1 sonraki olduğunu bulduk 
            if (ayrılmaharfi.Children.TryGetValue(data,out var delet)) //aslında burayı yazmaya gerek yok ama genede bı kontrol daha olsun dıyerekten yazdım var ıse boyle bır deger girsin
            {
                ayrılmaharfi.Children.Remove(data); //ayrılma harfının cocuklarından silcez neyı kendi cümlemizdeki ayrılmadan sonraki harfi orayı silmiş oluyoruz artık 
            }
            return true; 
        }

        public void Print(int space = 0) => Print(this, space);

        public void Print(Trie trie, int space = 0)
        {
            // Trie nesnesi null ise, ona bu kökü atar.
            trie ??= this;

            // Tek bir düğümü yazdıran iç içe fonksiyon.
            static void PrintSingleNode(char word, int space = 0, bool isEndOfWord = false)
            {
                if (space > 0)
                    Console.Write(new string(' ', space));

                // İlk düğüm için kırmızı, diğerleri için beyaz renk ayarı.
                Console.ForegroundColor = space == 0 ? ConsoleColor.Red : ConsoleColor.White;

                // Düğümü ve gerekirse kelimenin sonu olduğunu yazdırır.
                Console.WriteLine($"-> {word}{(isEndOfWord ? "(*)" : "")}");
            }

            // Trie'nin her bir çocuk düğümü için işlemleri gerçekleştirir.
            foreach (var entry in trie.Children)
            {
                // Her bir çocuk düğümünü tek bir düğüm olarak yazdırır.
                PrintSingleNode(entry.Key, space, entry.Value.IsEndOfWord);

                // Çocuk düğümün alt düğümlerini recursive olarak yazdırmak için Print fonksiyonunu çağırır.
                Print(entry.Value, space + 3);
            }
        }

    }
}
