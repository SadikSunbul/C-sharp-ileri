
//Kendisi hariç pozitif tam sayı bölenlerinin toplamı kendisinden büyük olan sayılara zengin (abundant) sayı denir.

Console.WriteLine("Bır sayı gırınız:");
int sayi=int.Parse(Console.ReadLine());
int toplam = 0;
for (int i = (sayi-1); i > 0; i--)
{
	if (sayi%i==0)
	{
		toplam = toplam + i;
	}
}
if (toplam>sayi)
{
	Console.WriteLine("Sayi:" + sayi);
	Console.WriteLine("Sayının bolenlerı toplamı:" + toplam);
    Console.WriteLine("Girdiğiniz sayı Zemgın sayıdır");
}
else
{
    Console.WriteLine("Sayi:" + sayi);
    Console.WriteLine("Sayının bolenlerı toplamı:" + toplam);
    Console.WriteLine("Girdiğiniz sayı Zemgın sayı değildir");
}