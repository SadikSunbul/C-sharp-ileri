

//Kuyruk 
/*
 Kuyruk Uygulamaları
Queue Applications
    • Doğrudan Uygulamalar
    • İşletim sistemler iş planlaması (Yazıcı kuyrukları)
    • Gerçek hayattaki kuyruk uygulamalarının modellenmesi
    • Çoklu programlama
    • Asenkron veri transferi
• Yardımcı işlevler
    • Algoritmalar için yardımcı veri türü
    • Diğer veri yapılarının bileşenleri
 */


using DataStructures._Kuyruk;

var numbers = new int[] { 1, 2, 3, 4 };


var q1 = new Kuyruk<int>();
var q2 = new Kuyruk<int>(KuyrukType.LinkedList);


foreach (var number in numbers)
{
    Console.WriteLine(number);
    q1.enQueue(number);
    q2.enQueue(number);
}

Console.WriteLine($"q1 count:{q1.count}");
Console.WriteLine($"q2 count:{q2.count}");

Console.WriteLine($"q1 eleman cıkart:{q1.DeQueue()}");
Console.WriteLine($"q2 eleman cıkart:{q2.DeQueue()}");

Console.WriteLine($"q1 count:{q1.count}");
Console.WriteLine($"q2 count:{q2.count}");

Console.WriteLine($"q1 Peek:{q1.Peek()}");
Console.WriteLine($"q2 Peek:{q2.Peek()}");

Console.WriteLine("");


