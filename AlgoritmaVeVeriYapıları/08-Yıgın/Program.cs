

//Yıgın 
/*
 Yığın (Stack)
    • Doğrudan kullanılan uygulamalar
    • Sembollerin dengelenmesi (Balancing of symbols)
    • Infix-to-poştfix dönüşümü
    • Postfix deyimlerinin değerIendirilmesi
    • Bir tarayıcıdaki ziyaret edilmiş sayfa listesi
    • Bir metin editöründe yapılan değişikliklerin geri alınması
    • HTML ve XML belgelerinde etiketlerin eşleşmesi
 Dolaylı kullanılan uygulamalar
    • Diğer veri yapılarında yardımcı veri yapısı olabilir, yani diğer veri yapılarının
    yardımcı bileşeni olarak kullanılabilir.
    • Tower of Hanoi, Tree Traversals, Stock span problem, histogram problem
    algoritmalarında kullanılabilir.
    • Backtracking algoritma tasarlama tekniğinde kullanılabilin
 */

using _08_Yıgın;

var charset = new char[] { 'a', 'b', 'c','d','e' };
var stack1 = new _08_Yıgın.Stack<char>();
var stack2 = new _08_Yıgın.Stack<char>(StackType.LinkedList);

foreach (char c in charset)
{
    Console.WriteLine(c);
    stack1.Push(c);
    stack2.Push(c);

}
Console.WriteLine("peek");
Console.WriteLine("stack1 :"+stack1.Peak());
Console.WriteLine("stack2 :"+stack2.Peak());
Console.WriteLine("count");
Console.WriteLine("stack1 :" + stack1.Count);
Console.WriteLine("stack2 :" + stack2.Count);
Console.WriteLine("peek");
Console.WriteLine("stack1 :" + stack1.Pop());
Console.WriteLine("stack2 :" + stack2.Pop());
Console.WriteLine("count");
Console.WriteLine("stack1 :" + stack1.Count);
Console.WriteLine("stack2 :" + stack2.Count);

Console.WriteLine();

