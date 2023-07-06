



using LinkedListIenumableekleme;
using System.Threading.Channels;

MyList<int> ints = new MyList<int>();

ints.AddFirst(1);
ints.AddFirst(2);
ints.AddFirst(3);
ints.AddFirst(4);
ints.AddFirst(5);


foreach (int i in ints)
{
    Console.WriteLine(i);
}


var ints1=ints.ToList();

Console.WriteLine(ints1.Min());