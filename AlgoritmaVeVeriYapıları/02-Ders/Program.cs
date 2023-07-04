

using DataStructures.Array;
using System.Runtime.InteropServices;

var arr = new Array<int>();

Console.WriteLine($"{arr.Capasity} / {arr.Count}");

arr.Where(x=>x%2 == 0).ToList()
    .ForEach(x=>Console.WriteLine(x));
Console.ReadLine();