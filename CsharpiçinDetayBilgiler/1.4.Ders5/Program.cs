

#region try - catch Mekanizması

try
{
	//olası calısama zamanı hatası barındıran verebılecek olan kodları buray ayazıyoruz
	Console.WriteLine("Bir sayı gırınız:");
	int sayi=int.Parse(Console.ReadLine());
    Console.WriteLine("Bir sayı gırınız:");
    int sayi1 = int.Parse(Console.ReadLine());
    Console.WriteLine("sayıların toplamı:"+(sayi1+sayi));
}
catch 
{
    //try ıcerısınde bır hata soz konusu oldugunda catch blogu tetıklenır
    //hataya dair ;log kullanıcı bılgılendırme,kontrollu kapanıs vs.
    Console.WriteLine("Girilen deger sayısal bır deger degıl");
}

#endregion

#region try - catch Mekanizması Verimlilik
//maıyetlı bır yapıdır bu yuzden try ıcrısıne sadece ıhtımal dahılınde hata fırlatıcak yerlerı koymalıyız degılse cok fazla malıyetlı olur cunku try ıcerısındekı tum kodları sureklı kontrol ettıı ıcın gereksız seylerı ıcerıye yazmamalıyız
#endregion

#region  try - catch Hata Parametreleri

//calısma zamanında alınan hataya daır bızlere bılgı veren parametrelerdir
//run tıme de hata alındıgında bız bunu kod uzerınde gorururz
//yaptıgımız ısleme gore hata fırlatır

//int s1 = 0, s2 = 10;
//int a = s2 / s1;

//object x = null;
//x.ToString();

try
{
    int s1 = 0, s2 = 10;
    int a = s2 / s1;
}
catch (Exception ex) //Exception --> bızlere hata ile lgili tum bılgılerı getıren bır ust turdur base clas yani tum hataları karsılar ex parametresı sayesınde bızler alınan hataya dair bılgıler edınebılmekteyız ve gerekli loglama vs. gibi operasyonları gerceklestıre bılmekteyız ...
{
    Console.WriteLine("Mesaj:"+ex.Message);
}
#endregion

#region try - catch Exception Dışında Farklı Bir Tür İle Hata Yakalama

try
{
    int s1 = 0, s2 = 10;
    int a = s2 / s1;
}
catch (DivideByZeroException ex)
//Exception tum hataları karsılar ama burada ozellestırdık DivideByZeroException yaptık boyle bır durumda buna aıt hataları karsılaya bılır karsılamadıgı bır hata olursa try catch ıcerısındede patlama gerceklese bılır cozum olarak bırden fazla catch kullana bılırız
{
    Console.WriteLine("Hata:"+ex.Message);
}

#endregion

#region try - catch Birden Çok Catch Durumu

try
{
    int s1=0, s2 = 10;
    int a=s2 / s1;

    //int.Parse("dxdfdhs");
}
catch (DivideByZeroException ex)
{
    //DivideByZeroException bu harta alınırsa burası calısır
}
catch (FormatException ex)
{
    //FormatException bu hata alınırsa burası calısır
}
catch (Exception ex)
{
    //ustekılerden hıcbırıı calısmazsa burası calısır ustekı hatalardan herhangı bırır calısırsa oradan sonra cıkar drekt olarak 
    //rty catch yapılandırması ozelden genele dogru sıralanmalıdır sıralama cok onemlıdır burada
    //Exception her zaman en sona konmalıdır
}


#endregion

#region  try - catch finally Bloğu
//bu blok try catch yapılandırmasında hata alınsada alınmasada her iki durumdada tetıklenen kod blogudur
try
{

}
catch ()
{

}
finally
{
    //burası her turlu calısacaktır
    //her ıkı durumdada calsır
    //sımdı pek kullanılmıyor onceden cok kullanılırdı
}
#endregion

#region try - catch when Yapısı İle Hata Filtreleme (C# 6.0)
try
{
    int s1 = 0, s2 = 10;
    int a = s2 / s1;
}
catch (DivideByZeroException ex) when (true)  //ve ıslemı yapar sol sagda true ıse calsır
{
    Console.WriteLine("mesaj:" + ex.Message);
}
#endregion