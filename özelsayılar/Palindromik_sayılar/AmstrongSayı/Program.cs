

//Belirli bir tabanda basamaklarının, sayının basamak sayısı kadar kuvvetlerinin toplamına eşit olan sayılara Armstrong sayısı denir.


Console.WriteLine("Bır sayı gırınız:");
int sayi=int.Parse(Console.ReadLine());
int temp = sayi;
int toplam = 0;
while (temp>=1) 
{
    int mod = temp % 10;
    temp=temp/10;
    toplam=toplam+(int)Math.Pow(mod, 3);
}
if (sayi==toplam)
{
    Console.WriteLine("Girdiğiniz sayı:" + sayi);
    Console.WriteLine("Sayıların basamakaları toplamı :" + toplam);
    Console.WriteLine("Gırdıgınız sayı Amstrong bır sayıdır");

}
else
{
    Console.WriteLine("Girdiğiniz sayı:" + sayi);
    Console.WriteLine("Sayıların basamakaları toplamı :" + toplam);
    Console.WriteLine("Gırdıgınız sayı Amstrong bır sayı degıldır");

}
