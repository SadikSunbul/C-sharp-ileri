
//mersene ASAL SAYILAR

Console.WriteLine("Bır sayı gırınız.");
int sayi=int.Parse(Console.ReadLine());
if (AsalsayıBulucu(sayi)==1)
{
    int yenısayı = (int)((Math.Pow(2, sayi)) - 1);
    if (AsalsayıBulucu(yenısayı)==1)
    {
        Console.WriteLine("Gırdıgınız sayı." + sayi);
        Console.WriteLine("ıslemler sonucundakı sayı." + yenısayı);
        Console.WriteLine("Girdiğiniz sayı mersene sayıdır..");
    }
    else
    {
        Console.WriteLine("Girdiğiniz sayı asal sayı ama ıslemeler sonucunda cıkan sayınız asal olmadıgından bu sayınız mersene sayı degıldır.");
        Console.WriteLine("Gırdıgınız sayı." + sayi);
        Console.WriteLine("ıslemler sonucundakı sayı."+yenısayı);
    }
}
else
{
    Console.WriteLine("Girdiğiniz sayı asal sayı degıldir");
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