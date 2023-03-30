using System.Diagnostics.Metrics;

#region Metot Nedir? Bir Programcı Gözünden Ne İşe Yarar?

//metot = fonksiyon

#region İşlevsel Açıdan Metot Bize Ne Kazandırır?

//Tekrarları kaldırır
//yonetilebilirlik artıcak dır
//maliyet kazancı sağlar


#endregion

#endregion

#region Metot Anatomisi Nasıldır? Gelin Metot İmzasını İnceleyelim
//sınıf ıcerısınde calısılmalıdır 
//metot ıcerısınde methot da tanımlana bılır localfunctıon

// [Erişim belirleyicisi] [Geri donus degeri] [methodun adı](Parametreler){   }

#region İşlevine Göre Metot Türleri Nelerdir?
//Yapılıcak ısleme gore 4 fasrklı varyasyonda methot olusturula bılır
//gerıye bır deger dondurmuyor dısarıdan parametre almıyor
//gerıye bır deger dondurmuyor dısarıdan parametre alır
//gerıye bır deger döndürür dısarıdan parametre almıyor
//gerıye bır deger döndürür dısarıdan parametre alır
#endregion
Metoticin a = new();
a.Tets11();
#endregion
class Metoticin
{
    //bu clası publıclar calıssın dıye kullandık
    #region Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndürmeyen Parametre Almayan Metot Türü

    #region gerıye bır deger dondurmuyor dısarıdan parametre almıyor
    private void Test()  //voit deger dondurmez
    {
        Console.WriteLine("test1"); //burda ekrana cıktı verır gerıye deger dondurmek bu degıl
    }
    #endregion
    #region gerıye bır deger dondurmuyor dısarıdan parametre alır
    public void Test1(string isim)
    {
        Console.WriteLine(isim);
    }
    #endregion
    #region gerıye bır deger döndürür dısarıdan parametre almıyor
    public int Tets2()
    {
        return 10;  //return deger dondurmek ıcın kullanılır nerede tetıklenırse tetıklensın dırekt olarak methottan cıkar
    }
    #endregion
    #region gerıye bır deger döndürür dısarıdan parametre alır
    public int Tets3(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    #endregion
    
    #endregion
    #region Metotlarda Optional Parameters(İsteğe Bağlı Parametreler)
    //metot parametrelı ıse parametrelerı gondermezsen haat verıcektrı
    //bu durumu engellemek ıcın bır nevı default deger atıyarak yapabılırız
    //opsıyonel durumlar hep sag tarafta tanımlanmalıdır opsıyonelden sonra normal bır sekılde atama yaparsak hata verıcektır cunku kullanım sırasında tutarsızlık meydana gelır
    public int Tets11(int sayi=0,int sayi2=0)
    {
        return sayi + sayi2;
        
    }
    /*
     Metoticin a = new();
        a.Tets11();
     */

    #endregion
}

#region Metotlarda Non Trailing Named Arguments Özelliği

metot(3, 5, "abc");
metot(c: "abc", a: 5, b: 15); //sırayı kendımıze gore ayaralamamızzı saglar

void metot(int a, int b, string c)
{

}

#endregion

#region Metotlarda In Parametreleri (C# - In Keywordü)
// x metodunun parametresındekı deger degısmesısı ıcın kullanılır sabit tutar
//In komutu ılgılı parametrenın degerını readonly sadece okunur halae getirir

void x(in int a) //a sadece okunur hale geldı
{
    // a = 123; //ın yazdıgımız ıcın burada hata verıcektır
}

#endregion

#region Local Functions(Metot İçerisinde Tanımlanabilir Yerel Metotlar)
//metot ıcerısınde metot tanımlama 
//erısım belırleyıcısı tanımlanmaz sadece o metotdun  ıcerısınde kulanılacaktır 
//isimler frklı olmalıdır hata vermez ama kullanmamak gerekir derleyıcı hata vermez

void xy()
{
    void y()
    {

    }
}
#region Static Local Functions(Metot İçerisinde Tanımlanabilir Statik Yerel Metotlar)
void xyz(int a)
{
    int b = 0;

     static void yz(int a,int b) //bunlar malıyetlıdır static eklersek a ve b ye erısım malıyetı kalkar parametre olarak gonderırısek daha az bır malıyet olur
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
#endregion

#endregion


#region Metotlarda Overloading(Çoklu Yükleme)
mat q = new();
q.emt1();//buradad 3 farklı ıslem yapabılırız
class mat
{
    public void emt1()
    {

    }
    public void emt1(int a)
    {

    }
    public void emt1(int a, string b)
    {

    }
}

#endregion