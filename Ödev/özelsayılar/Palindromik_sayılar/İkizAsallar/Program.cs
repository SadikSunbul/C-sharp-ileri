
//Aralarındaki fark 2 olan asal sayılara ikiz asal denir

Console.WriteLine("1.  sayıyı gırınız");
int sayı1 =int.Parse( Console.ReadLine());
Console.WriteLine("2.  sayıyı gırınız");
int sayı2 = int.Parse(Console.ReadLine());

if (sayı1-sayı2==2 || sayı1-sayı2==-2)
{
    if (AsalsayıBulucu(sayı1)+AsalsayıBulucu(sayı2)==2)
    {
        Console.WriteLine("Girilen sayıalr");
        Console.WriteLine(sayı1+"  /  "+sayı2);
        Console.WriteLine("bu sayılar ikiz asal sayıdır");
    }
    else
    {
        Console.WriteLine("Sayılarınızda asal olmayan bır sayı var "); Console.WriteLine(sayı1 + "  /  " + sayı2);
        Console.WriteLine("bu sayılar ikiz asal sayı degıldır");
    }
}
else
{
    Console.WriteLine(" Gırılen Sayılar arasındakı fark 2 olmalıdır ");
}


int AsalsayıBulucu(int sayi)
{
    int kontrol = 1;
    
    for (int i = 2; i < sayi; i++)
    {
        if (sayi%i==0)
        {
            kontrol = 0; //asal sayı degıldır 
        }
    }


    return kontrol;
}
