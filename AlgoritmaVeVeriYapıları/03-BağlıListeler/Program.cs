
#region Bağlı liste 
/*
 Bağlı Liste Nedir?
Linked List
• İçindeki elemanların doğrusal olarak düzenlendiği veri yapısıdır.
• Dizilere benzer bir yapısı vardır ancak içindeki elemanlara ulaşma
yaklaşımı ile dizilerden ayrılmaktadır.
• Dizilerde elemanlara ulaşmak için indisler kullanılırken; bağlı
listelerde işaretçiler kullanılır.
 */

/*
 • Bağlı Liste İşlevleri
(Main linked lists operations)
    • insert: Listeye eleman ekleme.
    • Delete: Listeden eleman silme.
• Yardımcı Bağlı Liste İşlevleri
(Auxiliary linked lists operations)
    • Delete List: Listedeki tüm elemanları siler ve listeyi yok eder.
    • Count: Listedeki eleman sayısını döner,
    • Find: Listedeki bir düğümü işaret eder.
 */

#region İnsert
/*
 • Liste başına ekleme yapma
• Kuyruğa ekleme (liste sonuna) ekleme yapma
• Araya ekleme yapma
 */

using DataStructures.LinkedList.SingleLinkedList;

var linkedList = new SingleLinkedList<int>();
linkedList.AddFirst(1);
linkedList.AddFirst(2);
linkedList.AddFirst(3);
// 3 2 1  o(1)

linkedList.AddLast(4);
linkedList.AddLast(5);
linkedList.AddLast(6);
//3 2 1  4 5 6 o(n)

linkedList.AddAfter(linkedList.Head.Next, 32);
//3 2 32 1  4 5 6 
var data = new SinglyLinkedListNode<int>(99);
linkedList.AddAfter(linkedList.Head.Next, data);
//3 2 99 32 1  4 5 6 
linkedList.AddBefore(linkedList.Head.Next,55);
//3 55 2 99 1 4 5 6
var data1 = new SinglyLinkedListNode<int>(66);
linkedList.AddBefore(linkedList.Head.Next,data1);
// 3 66 55 2 99 1 4 5 6 

foreach (var item in linkedList)
{
    Console.WriteLine(item);
}

Console.WriteLine(linkedList.Head.Next.Next);
Console.ReadKey();

//Buradaki işlemler DataStructures/LinkedList/SingleLinkedList içerisinde

#endregion

#endregion