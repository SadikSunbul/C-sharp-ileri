

//Bir asal sayının tersten yazılışı da farklı bir asal sayı ise bu sayıya lasa (emirp) sayısı denir. Dikkat edilirse bu sayıların adı da "asal (prime)" kelimelerinin tersten yazılışıdır.
Console.WriteLine("Bir sayı gırınız:");
int sayi = int.Parse(Console.ReadLine());
if (AsalsayıBulucu(sayi) == 1)
{
    int toplam = 0;
    int temp = sayi;

    while (temp >= 1)
    {
        int mod = temp % 10;
        temp = temp / 10;
        toplam = (toplam*10) + mod;
    }
    Console.WriteLine(toplam);
    if (AsalsayıBulucu(toplam)==1)
    {
        Console.WriteLine("Girdiğiniz asal sayı:" + sayi);
        Console.WriteLine("sayınızın tersı:" + toplam);
        Console.WriteLine("Gırdıgınız sayı Lasa sayıdır");
    }
    else
    {
        Console.WriteLine("Girdiğiniz asal sayı:" + sayi);
        Console.WriteLine("sayınızın tersı:" + toplam);
        Console.WriteLine("Gırdıgınız sayı Lasa sayıdır");
        Console.WriteLine("ilk sayınız asal sayı ama tersi asal değil");
    }
}
else
{
    Console.WriteLine("Girdiğiniz sayı asalsayı degıldır..");
}


int AsalsayıBulucu(int sayi)
{
    int kontrol = 1;
    for (int i = 2; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            kontrol = 0; //asal sayı degıldır 
        }
    }
   return kontrol;
}