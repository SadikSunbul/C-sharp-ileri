
#region Recursive(Tekrarlamalı/Özyinelemeli) Metotlar
//bır fonk degıl bır yaklasımdır

//nerlerde kullanılır
//öngmrülemeyen derinliği tahmın edılemeyen,sonu bilinmeyen durumlarda tercıh edıle bılır
//parametreler ıle kontrol uygulamalıyız

using System;

x();//sonsuztane merhaba yazar durduran bısey yok 
void x()
{
    Console.WriteLine("Merhaba");
    x();
    Console.WriteLine("Dunya"); //buaryı yazarsak gene ustekı gıbı sonsuztane merhaba yazar durduran bısey yok 
}

//iradeli bi sekılde yonettık
c(1);

void c(int a)
{
    Console.WriteLine("Merhaba");
    if (a<3)
    {
        c(++a); //ilk artırdık sonra ıcerıye gonderdık
    }
    Console.WriteLine("Dünya");//burada 3 tane dunya gelıcektır
}

//burada sureklı bı oncekı komutun bıtmesını beklıyor bıtınce dunya yazacak hepsı bıtınce teker teker yazdırıyor dunyaları

#region Orenk1
//dongulerın kullanıldıgı her noktada rekursıffonk kullanıla bılır ama tam tersı olmaz

topla(10, 20);
int topla(int baslangıc,int bitiş)
{
    if (baslangıc%5==0 )
    {
        return baslangıc + topla(++baslangıc,bitiş);
    }
    if (baslangıc < bitiş)
    {
        return topla(++baslangıc, bitiş);
    }
    return 0; //gerıye donerken toplıyacagı ıcın 0 gonderdık carpma olsaydı 1 yazardık
}




#endregion
#region Ornek 2

List<FileInfo> DosyaYazdır(string path)
{
    List<FileInfo> file = new();
    DirectoryInfo directory = new(path);
    DirectoryInfo[] directoryInfos=directory.GetDirectories();
    if(directoryInfos.Any())//baska klasor varsa gır dedık
    {
        foreach (var directory1 in directoryInfos)
        {
            file.AddRange(DosyaYazdır(directory1.FullName));
        }
    }
    else
    {
       file.AddRange(directory.GetFiles());
    }
    return file;
}
#endregion


#endregion
