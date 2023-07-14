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
bt.Root = a.Root;



Console.WriteLine();
//Console.WriteLine(a.FindMax(a.Root));
//Console.WriteLine(a.FindMin(a.Root));
//Console.WriteLine(a.Find(a.Root,37));
//a.Remove(a.Root, 37);
//bt.InOrder(a.Root).ForEach(i=>Console.Write($"{i,-3}"));
//Console.WriteLine("");
//Console.WriteLine(BinaryTree<int>.MaxDepth(a.Root)) ;
//Console.WriteLine(BinaryTree<int>.DeepestNode(a.Root).Value) ;
//Console.WriteLine(bt.DeepestNode()) ;
//Console.WriteLine(bt.NumberOfLeadfs(a.Root));
bt.PrintPaths(a.Root);

foreach (var item in a)
{
    Console.WriteLine(item);
}
Console.WriteLine();