


using DataStructures.LinkedList.SingleLinkedList;

var rnd = new Random();
var inital = Enumerable.Range(1, 10).OrderBy(x => rnd.Next()).ToList();

var list=new SingleLinkedList<int>(inital);

foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine("Bastan sılınen deger:"+list.RemoveFirst());
Console.WriteLine("Sondan sılınen deger:"+list.RemoveLast());
list.Remove(6); //aradan sılme ıslemı yaptık 
Console.WriteLine("----------");
foreach (var item in list)
{
    Console.WriteLine(item);
}