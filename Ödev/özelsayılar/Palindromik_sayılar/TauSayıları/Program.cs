
//Pozitif bölenlerinin sayısına (PBS) tam bölünen sayılara Tau sayısı denir.

Console.WriteLine("Bır sayı gırınız:");
int sayi=int.Parse(Console.ReadLine());
int toplamsayuısı = 0;
for (int i = 1; i <= sayi; i++)
{
	if (sayi%i==0)
	{
        toplamsayuısı++;

    }
}
if (sayi%toplamsayuısı==0)
{
    Console.WriteLine("girdiginiz sayı Tau sayısıdır.");
}
else
{
    Console.WriteLine("girdiginiz sayı Tau sayı degıldır.");
}
