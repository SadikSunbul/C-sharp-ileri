

#region Open/Closed (Açık / kapalı) Principal

/*
 Open Closed Principle, OOP tasarımlarında bir sınıfın
gereksinimler doğrultusunda değiştirmeye gerek
duyulmaksızın genişletilebilir bir şekilde tasarlanmasını
savunan bir prensiptir.

Kodun Değiştirilmesi: adı üzerinde kodun değiştirilmesidir. Var olanın
yerine yeni gereksinime göre güncel halinin işlenmesidir,

Kodun Genişletilmesi; kodu değiştirmeksizin yeni gereksinime göre
gelecek olan davranışın uygulamaya eklenebilmesidir.
 */

#region Hatalı tasarım

using System.Runtime.CompilerServices;

class ParaGönderici1
{
    public void Gönder(int turar)
    {
        //Garanti garanti = new();
        //garanti.HesapNo = "....";
        //garanti.ParaGönder(123);

        HalkBnk halkBnk = new HalkBnk();
        halkBnk.GönderilcekHesapNo("....");
        halkBnk.ParaGönder(123);


    }
}

class Garanti1
{
    public string HesapNo { get; set; }
    public void ParaGönder(int tutar)
    {
        //...
    }
}

class HalkBnk1
{
    string HesapNo;
    public void GönderilcekHesapNo(string hesapNo)
    {
        HesapNo = hesapNo;
    }
    public void ParaGönder(int tutar)
    {
        //...
    }
}

#endregion

#region Doğru tasarım

class ParaGönerici
{
    public void Gönder(IBanka banka, int tutar, string hesapNo)
    {
        banka.ParaTransferi(tutar, hesapNo);
    }
}

interface IBanka
{
    bool ParaTransferi(int tutar, string hesapNo);
}
class Garanti : IBanka
{
    public string HesapNo { get; set; }
    public void ParaGönder(int tutar)
    {
        //..
    }
    public bool ParaTransferi(int tutar, string hesapNo)
    {
        try
        {
            HesapNo = hesapNo;
            ParaGönder(tutar);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}

class HalkBank : IBanka
{
    string _hesapNo;

    public void GönderilecekHesapNo(string hesapno)
    {
        _hesapNo = hesapno;
    }
    public void Gönder(int tutar)
    {
        //...
    }
    public bool ParaTransferi(int tutar, string hesapNo)
    {
        try
        {
            _hesapNo = hesapNo;
            Gönder(tutar);
            return true;
        }
        catch (Exception)
        {
            return false;
            throw;
        }
    }
}

#endregion

#endregion