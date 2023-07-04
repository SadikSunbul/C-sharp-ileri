



using Deneme;

MyArray<int> ints = new MyArray<int>();
ints.Add(1);
ints.Add(2);

ints.Remove();

Console.WriteLine(ints.Count);
Console.WriteLine(ints.ToArray());