

//Kendisi hariç pozitif tam bölenlerinin toplamı kendisine eşit olan sayılara mükemmel (perfect) sayı denir. Mükemmel sayılarla Mersenne asal sayıları arasında birebir ilişki vardır, dolayısıyla bilinen mükemmel sayıların sayısı da 51'dir.

Console.WriteLine("Bır sayı gırınız:");
int sayi = int.Parse(Console.ReadLine());
int toplam = 0;
Console.WriteLine("------------------------------------------");
Console.WriteLine("Gırdıgınız sayının bolenlerı");
for (int i = 1; i <sayi; i++)
{
	if (sayi%i==0)
	{
		toplam = toplam + i;
        Console.WriteLine(i);
    }
}
Console.WriteLine("------------------------------------------");
if (toplam==sayi)
{
	Console.WriteLine("Girdiğiniz sayı:" + sayi);
	Console.WriteLine("Bolenlerının toplamı:" + toplam);
    Console.WriteLine("Gırdıgınız sayı mukemmel sayı");
}
else
{
    Console.WriteLine("Girdiğiniz sayı:" + sayi);
    Console.WriteLine("Bolenlerının toplamı:" + toplam);
    Console.WriteLine("Gırdıgınız sayı mukemmel sayı değil");
}

