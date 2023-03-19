

//

Console.WriteLine("Bır sayı gırınız:");
int sayi=int.Parse(Console.ReadLine());
int temp = sayi;
temp = temp - 1;

for (int i = 0; i < 100; i++)
{
    int ustunustu = (int)Math.Pow(2, i);
    int altınustu= (int)Math.Pow(2,ustunustu);
    if (altınustu==temp)
    {
        Console.WriteLine("Gırdıgınız sayı Fermant Sayı");
        break;
    }
    else if (altınustu>temp)
    {
        Console.WriteLine("Bu sayı fermant sayı degılır");
        break;
    } 
}