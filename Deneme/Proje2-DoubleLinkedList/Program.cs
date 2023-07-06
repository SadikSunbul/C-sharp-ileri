

using Proje2_DoubleLinkedList;

MyDoubleList<int> ints = new MyDoubleList<int>();
ints.Add(1);
ints.Add(2);
ints.Add(3);
ints.Add(4);
ints.Add(5);
ints.Remove(4);

Console.WriteLine("tumunu listele");
foreach (var item in ints)
{
    Console.WriteLine(item);
}