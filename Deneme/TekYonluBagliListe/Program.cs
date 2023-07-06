

using TekYonluBagliListe;

var listyem = new LinkedLists<int>();

listyem.AddFirst(1);
listyem.AddFirst(2);
listyem.AddFirst(3);
listyem.AddFirst(4);

foreach (var x in listyem )
{
    Console.WriteLine(x);
}

Console.ReadKey();