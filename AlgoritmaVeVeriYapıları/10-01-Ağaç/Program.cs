using DataStructure_Ağaç.Tree.BinarySearchTree;
using DataStructure_Ağaç.Tree.BinaryTree;
using System.Threading.Channels;

BST<int> a = new();

a.Add(23);   
a.Add(16);   
a.Add(45);   
a.Add(3);   
a.Add(22);   
a.Add(37);   
a.Add(99);   


//var data=new BinaryTree<int>().InOrder(a.Root);  //sıralı değer veriri bize

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}
var bt=new BinaryTree<int>();

bt.InOrder(a.Root)
    .ForEach(n => Console.Write($"{n,-3}"));
Console.WriteLine();

bt.InOrderNonRecursiveTraversal(a.Root)
    .ForEach(n=>Console.Write($"{n,-3}"));

Console.WriteLine();