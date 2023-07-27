
//Belirli bir tabanda rakamları toplamına tam bölünen sayılara Harshad sayısı denir.
//162=1+6+2=9 ,(162/9=18)

Console.WriteLine("Bır sayı gırınız:");
int sayi=int.Parse(Console.ReadLine());
int temp = sayi;
int toplam = 0;

while (temp>=1)
{
    int mod = temp % 10;
    temp=temp / 10; 
    toplam=toplam + mod;
}

if (sayi%toplam==0)
{
    Console.WriteLine("Girdiğiniz sayı:" + sayi);
    Console.WriteLine("Sayınıı basamaları toplamı :" + toplam);
    Console.WriteLine("Girdiğiniz sayı Harshad Sayıdır");
}
else
{
    Console.WriteLine("Girdiğiniz sayı:" + sayi);
    Console.WriteLine("Sayınıı basamaları toplamı :" + toplam);
    Console.WriteLine("Girdiğiniz sayı Harshad Sayı değildir");
}