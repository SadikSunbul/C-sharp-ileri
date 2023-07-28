
//Performans odalı kullanılır bunlar

#region RefReturn ifadesi nedir?
//Ref return ıfadesını anlıyabılmek ıcın temel c# daki keywordun davranışına hakim olmak gerekemetedir

//ref : keywordu bır metodun parametresıne harhangı bır degıskenın degerını degıl, referansını yanı degıskenın kendisini gondermemizi sağlıyan bir işlevselliğe sahiptir

using System.Numerics;

int _a = 5;

x(ref _a);

void x(ref int a)
{
    a = 20;
}

Console.WriteLine(_a); //cıktı sı 20 dır
#region ref return
//Nasılki ref keywordu ile degıskenın kendısını metodagonderebiliyoruz Refreturn ifadesi ile de metotdan degıskenı fızıksel olarak return edebılıyoruz :Gerıye referans döndürür

ref int x1(ref int a) //int turundn bır ref donucek dedık 
{

    return ref a; //a nın referansını döncek
}
#endregion

#region RefReturn Kullanım 
//burada _b ile __b bellekte aynı adresı tutarlar
int _b = 5;
ref var __b = ref t(ref _b); //t gerıye bır referans donuyor onu referans ıle karsılamak ıcın ref dedık hata aldıgın yerde ref yaz bı yerlere hata kalkar 

ref int t(ref int b)
{
    return ref b;
}

#endregion

#region Kritik1
//ref return ozellıgının kullanıldıgı metotdan her daıma geri dönus değeri olarak referansı karsılamak mecburıyetınde degılız Bazen ihtiyaç dogrultusunda referansa karsılık değeri de elde etmek ısteyebılırız
int _c = 5;
int w = t(ref _c); //burasıda calısıcaktır ama burada deger tutcaktır w nun degerı degısse veya _c nın degerı degıstırılse bırbıtrını etkılemz cunku referansını tutmuyor 

ref int q(ref int b)
{
    return ref b;
}
#endregion

#region Kritik2
//ref return özelliğinin kullanıldığı metotta geriye return edilen değişken referansı local olamaz

//Ee bu durumda return ref yapabılecegımız degıskenın bır sekılde global olması gerekmektedir

//ref int y(ref int a)
//{
//    int w = 123;
//    a = 124;
//    return ref w; //hata alırız
//}

//Bunun için ister ref ile işaretlenmiş bir parametre kullanabilirsinz isterssenizde metodun tanımlandığı sınıftaki herhangi bir field'ı tercih edebilirsiniz. Şöyle ki; 

//Eğerki parametreden gelen değişken ise bunun normal parametre değil ref ile işaretlenmiş parametre olması gerekiyor
//dısarıdan gelen referansı gondere bılırsın 

//MyClass m = new MyClass();
//ref int a = ref m.X(); //buradaki a ile sınıf ıcındekı fıeld aynı bellek adresını görucektır ıkısındekı değişiklikler bırbırını etkıler


//class MyClass
//{
//    public int A = 5;
//    public ref int X()
//    {
//        return ref A;
//    }
//}
#endregion

#region  Örnek

int[] numbers = { 1, 2, 3, 4, 5 };
ref int numberRef = ref FindElement(numbers, 3);
numberRef = 56;
//burada dızının ıcerıısnde aradıgımız degerın blogunu gonderdık
//burada parametrede ref int[] array demememizin sebebi diziler arraylaer zaten referans turlüdür
ref int FindElement(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] += 1;
        if (array[i] == target)
        {
            return ref array[i];
        }
    }
    throw new NotImplementedException();
}

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

/*
 ref return özelliği; performans gerektiren durumlarda kodu optimize etmek ve
özellikle değişkenlerdeki lüzumsuz yere olabilecek veri tekrarlarını engellemek
için oldukça kullanışlı bir özelliktir.
 */
#endregion

#endregion

#region Ref Locals ifadesi nedir?
//ref returne benzer bır davranıs sergıler

//ref returnde metotdan gerıye deger degılde referans dondure bılıyorduk ref locals ıle bır degıskenın degerını drekt olarak referans olarak elde edebiliyoruz

//ref locals de bu degısken ıle gerı donus degerı olmak zorunda degıl herhangı bır metodun içerisindeki yahut class elemanı olan değişken olabilir

int deneme = 10;
ref int y = ref deneme;

//Bu ornekte ref local ozellıgı sayesınde x degıskenının referansını y y değişkeni ile işaretlenmiş bulunuyoruz böylece x ile y değişkenleri aynı bellek adresinde işretleyeceklerinden dolayı biri değiştiğinde diğeride etkilencektir

/*
Özetle,
ref locals ile bir değişkenin referansı başka bir değişken tarafından
fle n e
ref return ile bir metodun geri dönüş değerinde değişken referansı
döndürülebilmektedir.
Her ikisi de değerleri referans yoluyla kullanma imkanı sağlamakta, ancak farklı
amaç ve senaryolarda devreye girmektedirler. 

 */
#endregion
