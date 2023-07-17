
#region Explıcıty İnterface & Name Hıdıng
//Diyelimki bir sınıf 2 farklı ınterfaceden ımplament edılıyor 2 ınterface ıcerısıınde de ornegın int Topla(); olsun bunun hangisonden geldıgı anlasılamaz ve bazı sorunlar ortaya cıkar bunun engellenmesı ıcın Explıcıty gelmiştir
//Explıcıty int IMatematik.Topla() yapar ve bunlar privat tır public yapılamaz
//Buradakı memberlara cllas referansı uzerınden degıl ancak ınterface referansı uzerınden erısım gosterılebılır

//Şu amac ıle kullanılır hangı ınterfaceden turuyor ıse onun kodunun calısmasını istediğimiz durumlarda kullanılır 

//Söyle bıseyde olur A sınıfındakı x metodunu drekt olarak ımplamet ederız ama B dekını Explıcıty olarak ımplametde edebiliriz 

MyClass1 my1 = new();
MyClass my = new MyClass();

MyClass3 my3 = new();


my1.A();

IA a = my;
a.x(); //böyle bir erişim yapılır 

IB b = my;  
b.x();


class MyClass : IA, IB
{
    int IA.x() //bunlar private dir 
    {
        Console.WriteLine("a x");
        return 0;
    }

    int IB.x()
    {
        Console.WriteLine("b x");
        return 1;
    }
}
interface IA
{
    int x();
}
interface IB
{
    int x();
}


//Burada base clas ve Interfacedeki namespaceler aynı olduguzaman kalıtım alan sınıf için IRun interface nin implament edılmıs olan A() metodu calsıcaktır bu durum NameHıdıng durumu degıldır

class BaseClass
{
    public void A()
    {
        Console.WriteLine("baseclass A");
    }
}

interface IRun
{
    void A();
}
class MyClass1 : BaseClass, IRun
{
    public void A() 
    {
        Console.WriteLine("IRun ınterface ımlemantasyonu ");
    }
}

#endregion

#region Default Implementation
//Normal şartlarda interface yapılanması içerisinde sade ve sadece kullanıcagı classlara uygulatacağı memberların imzalarınıs barındırmaktadır ancak c#8.0 ile interface içerisinde kımı memberların varsayılan uygulamasını gerceklestırebılecegımız ve ımzasının eslıgınde govdesını de tanımlıyabılecegımız Default İnterface İmplementation özelligi tanımlanmıstır

//Bu özellık ıle artık ınterfaceler ıceırısınde ıstedıgımız memberların govdelerını tanımlıyabılıyor ve boylece ımplementatıon surecınde bır opsıynel durum ortaya koyabılıyoruz 

//Herhangı bır class IExample ınterfaceyı ımplament eder ıse metot1 mecbur uygulamak zorunda lakın methot2 yi uygulamaya bilir böylece methot2 nın varsayılan uygulaması devreye girmıs olucaktır


interface IExample
{
    void Metot1();
    void Metot2()
    {
        Console.WriteLine("Default implemantasyon of metot2");
    }
}

class MyClass3 : IExample
{
    public void Metot1()
    {
        throw new NotImplementedException();
    }
    //suanda metot2 yı yazmadıgımız ıcın default olarak yanı ınterface ıceırısındekı bady sı dıkkate alınır default ımplementasyon kullanılacak ıse ınterface referansı ıle alınmalıdır
}
class MyClass4 : IExample
{
    public void Metot1()
    {
        throw new NotImplementedException();
    }
    //BURADAKI GIBI EKLEDIGIMIZ ZAMAN ISE Default olanı degılde buradakı kod calısıcak tır
    public void Metot2()
    {
        Console.WriteLine("METOT2");
    }
}

#endregion
#region Default implemantasyon Kullanım için en guzel senaryo
// Diyelimki koklü bir şirketin yazılım geliştiricisi olarak çalışıyor sunuz ve yeni bişeyler ekliyorsunuz ister istemez interfacelere dokunmak mecburıyetındesızız bu interface cok fazla ımplemanent edıldı ıse oradakı kucuk bır degısıklık her yerde hata fırlatıcaktır onları halletmek ıle ugrasıtırcaktır bunun yerıen yenı ekliycegımız ımzayı default olarak eklerız sadece yenı metotdumuza ekliyebiliriz ve hatalardan buyuk olcude kurtulmus oluruz 
#endregion

//Interfaceler ısaretleme amaclı kullanılabılırler 