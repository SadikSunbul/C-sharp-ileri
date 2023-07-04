

using System.Collections;



Stack a1 = new Stack();  //almıs oldugu dataları bır komut kullanarak sıralı bır sekılde kendı lıstesınden cıkarmamıza yarıyor

//en son gelen data ılk basta cıkar


a1.Push("Bir");
a1.Push("iki");
a1.Push("üç");
a1.Push("dört"); //en son bunu aldıgı ıcın ılk ıslemı bundan yapıcak 0. ındex



object o1 = a1.Pop(); //  o1 = dort   u gonderır listeden cıkartır 
object o2 = a1.Peek();  // 02 = üç   oldu ama üçü cıkarmadı buradan


Console.ReadLine();