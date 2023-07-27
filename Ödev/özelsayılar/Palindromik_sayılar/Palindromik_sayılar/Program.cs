
//Düz ve tersten (soldan ve sağdan) okunuşları aynı olan sayılara palindromik sayı denir.

int sayı = 0;
Console.WriteLine("Bır sayı gırınız:");

try
{
    sayı = int.Parse(Console.ReadLine());
}
catch (Exception)
{

    Console.WriteLine("Lutfen bır sayı gırınız");

}

//132 meselea 

int sayıtutucu = sayı;
int sonuç = 0;
while (sayıtutucu >= 1)
{
    
    int temp;
    temp = sayıtutucu % 10;
    sayıtutucu = sayıtutucu / 10;
    sonuç=(sonuç*10)+temp;
}

if (sayı==sonuç)
{
    Console.WriteLine("Gitrilen sayı:"+sayı);
    Console.WriteLine("sayının tersi:"+sonuç);
    Console.WriteLine("Sayınız Palindromik bir sayıdır");
}
else
{
    Console.WriteLine("Gitrilen sayı:" + sayı);
    Console.WriteLine("sayının tersi:" + sonuç);
    Console.WriteLine("Sayınız Palindromik bir sayı değildir");
}
