

using DataStructures.DoubleLinkedList;

var liste = new DubleLinkedList<int>();
liste.AddFirst(12);
liste.AddFirst(23);
//23 12
liste.AddLast(32);
liste.AddLast(44);
//23 12 32 44
liste.AddAfter(liste.Head.Next, new DbNode<int>(99));
//23 12 99 32 44

var list = new DubleLinkedList<char>(new List<char>() { 'a', 'b', 'c' });
Console.WriteLine("slinen değer:"+ list.RemoveFirst());
Console.WriteLine("slinen değer:"+ list.RemoveLast());

foreach (var item in list)
{
    Console.WriteLine(item);
}
liste.Remove(22);
Console.WriteLine("-----*----");
foreach (var item in liste)
{
    Console.WriteLine(item);
}
Console.WriteLine();