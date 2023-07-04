

using System.Collections; 
//kuyruk yapısı

Queue Q1 = new();  //sondan ekler bastan cıkarır bu lıstede


Q1.Enqueue("bir");  //deger atar ıcerıye   eklenılen sıraya gore geır
Q1.Enqueue("iki");
Q1.Enqueue("üç");
Q1.Enqueue("dört");

object o1 = Q1.Peek();  //degerı gonderır ve degerı sıllmez tutar 
object o2 = Q1.Dequeue();  //degerı gonderır ve o degerı sıler  silmeye en bastan baslar 


Console.ReadLine();