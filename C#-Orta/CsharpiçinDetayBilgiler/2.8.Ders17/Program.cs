


#region C#'ta ref Keyword'ü Nedir? Ne Amaçla Kullanılmaktadır?

#region Ref keywordü
//referansın kısaltmasıdır
//referans oop kavramıdır
//oop de nesneler ramde heap bolgesınde tutulmaktadır
// oop de referanslar = operatoru ıle ıletısıme gecebılmektedır bir referans işaretlediği herahngı bır nesneyi = operatoru sayasınde farklı bır referansa işaretlete bilir
//yani referanslarda = operatoru netıcesınde herhangı bır verısel tureme soz konusu olmamakta, işaretlenmiş nesne diğer referans tarafından işaretlenmektedir

//

int a = 5;
int b = a; //burada int b=5; olur buda stac de 2 deger olmus olur referns etme yok deger kopyalanıp cogalmıs olur

//ref keyvordu deger turlu degıskenlerde referans operasyonları yapmamızı saglayan bir keywor dur

ref int c = ref a; //a nın referansını c ye gonderdık

//c bır referans tutucak a nın referasını tutcak

//b ustundekı degısıklık a yı etkılemez ama c nın ustunedkı degısıklıkler a yı etkıler tersıde olur
int y = 10;
x(ref y);
Console.WriteLine(y); //cıktı 10 olur cunku referas edılmedı reflerı koyasanız cıktı 25 olucaktır
void x(ref int a)
{
    a = 25;
}

#endregion

#region Ref Returns
//bu ozellık sadece methotlarda gecerlıdır
//deger turlu degıskenlerınde referansları dondurule bılır

int p = 5;
 int f = u(ref p);
Console.WriteLine(a); //ilk degerleri 5  rrefsonucu  25
Console.WriteLine(f); //ilk degerleri  25  refsonucu  25
ref int u(ref int y)
{
    y = 25;
    return ref y;
}
#endregion

#endregion

#region C#'ta out Keyword'ü Nedir? Ne Amaçla Kullanılmaktadır?

//Input dısarıdan verı gelmesıdır OutPut dısarıya verı gondermesı

//Metotların Parametrelerı uzerınden dısarıya deger gondermemize yarayan bır keyworddur

//metotakı tanımlanmıs parametreler otomatık oalrak ınputtur 
//egerki dısarıya bır deger gonderecekse o parametre out ıle ısaretlenemlıdır

//output parametre barındıran bır methot kullanılırken out parametreden gelecek olan değerleri karşılıyacak değişkenler tanımlanmalıdır

int _b = 0;
int ert = etst(out _b); //out ile ısaretlemezsek hata vaeucektır 

int ert1 = etst(out int _c); //daha kısa bı sekılde yazılısı 
int etst(out int sayi)
{
    sayi = 25;
    //bir metot out parametreler barındırıyorsa o parametrelere kendı ıcerısınde deger atanması gerekmektedir aksı takdırde derleyıcı hata alınacaktır
    return 1;
}

#region TryParse

string _1 = "213";
int.TryParse(_1, out int r); //bool doner ve donusumu r ye atar



#endregion

#endregion