

using DataStructures.LinkedList.SingleLinkedList;
using System.Collections;

var arr = new char[] { 'a', 'b', 'c' };
var arrList = new ArrayList(arr);

var list=new List<char>(arr);
var clinkedList=new LinkedList<char>(arr);

var linkedList = new SingleLinkedList<char>(arr);

foreach(var item in linkedList)
{
    Console.WriteLine(item);
}
