


using Proje1_LinkedList;

MyList<int> list = new MyList<int>();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);


foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("---------*---------");
Console.WriteLine("sılınen deger:"+list.RemovePop());
Console.WriteLine("sılınen deger:"+list.RemovePop());

foreach (var item in list)
{
    Console.WriteLine(item);
}