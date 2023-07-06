using TTopluKuyrukYapısı;

var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
var stack1 = new MyStack<char>();
var stack2 = new MyStack<char>(StackType.LinkedList);

foreach (char c in charset)
{
    Console.WriteLine(c);
    stack1.Push(c);
    stack2.Push(c);

}
Console.WriteLine("peek");
Console.WriteLine("stack1 :" + stack1.Peek());
Console.WriteLine("stack2 :" + stack2.Peek());
Console.WriteLine("count");
Console.WriteLine("stack1 :" + stack1.count);
Console.WriteLine("stack2 :" + stack2.count);
Console.WriteLine("peek");
Console.WriteLine("stack1 :" + stack1.Pop());
Console.WriteLine("stack2 :" + stack2.Pop());
Console.WriteLine("count");
Console.WriteLine("stack1 :" + stack1.count);
Console.WriteLine("stack2 :" + stack2.count);

Console.WriteLine();