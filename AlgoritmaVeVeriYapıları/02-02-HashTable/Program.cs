
using System.Collections;

Hashtable H1 = new Hashtable(); //h1.add(key,value) burada key degerlerı farklı ıd gıbı olucak valuee ıcın farketmez 
H1.Add("Car", "araba");
H1.Add("House", "ev");

H1.Add("Cars", "araba"); //hata vermez burada
//H1.Add("Cars", "arabalar"); //hata verir key degerı benzersız olmak zorunda


//yardımcı metotlar

bool control = H1.Contains("Hause"); //iceride haouse varmı dıye kontrol eder varsa true yoksa hause

bool control1 = H1.ContainsKey("Cars"); //contains gıbı buda ıcınde varmı yokmu ona bakar

bool control2 = H1.ContainsValue("araba"); //yukarıdakılerın tam tersı seklınde deger bakar varmı yok mu dıye

H1.Clear(); //listeyı temızler

int toplamdeger = H1.Count;
H1.Remove("cars");  //girilen degerı sıler

H1["Hause"] = "villa";  //hausenın karsılıgını vılla yaptı

Console.WriteLine(H1["Hause"]); //buranın cıktısı vılla olur...

Console.ReadLine();