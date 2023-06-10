

#region Ref Keywordü

//ref keyvordu referanstan gelmektedir.
//Referans oop kavramıdır
//oop de nesneler ram de heap bolgesınde tutulmaktadırlar
//oop de referanslar = operatoru ıle ıletısıme gecebılmektedır bır referans ısaretledıgı herhangı bır nesneyı = operatorü sayesınde farklı bır referansa işaretletebilir.
//yanı referanslarda = operatoru netıcsınde herhangı bır verısel / nesnesel tureme soz konusu olmamaktadır ısaretlenmıs nesne dıger referans tarafından ısaretlenmektedır.

int a = 5;
int b = a; //deger kopyalanır yanı ramde 2 deger olur a=5,b=5  ramde 2 5 degerı var verıyo artırdık 

//ref keywordu deger turlu degıskenlerde referans operasyonları yapmamızı saglıyan bır keywoed.ref keywordu deger turlu degıskenlerın referanslarını cagırmamızı kullanmamızı saglıyan bır keyword
ref int c = ref a; //burada b bı referans tasıycak dedık ve a nın referansını tasısın dedık bellekte sadece a=5 var c anın adresını tutar sadece
//c veya a dan bırının degısıklılıgı hepsını etkıler 

//deger turlu degıskenlerde referans calısması yapmak ıstıyor ısek eger ref keywordu kullanılmalıdır 
//ref keywordu deger turlu degıskenlerın referans turlu degıskenler gıbı calısmasını saglıyan bır komuttur .
// deger turlu degıskenlerde shallow copy yapmamızı saglıyan bır keyword dur.

x(ref a);
Console.WriteLine(a); //20 yazacak buraya x metoduna adresını gonderdık 
void x(ref int x)
{
    x = 20;
}

#endregion

#region Ref returns
//bu ozzellık  sadece methotlarda kullanılır 
//methotlar gerıye deger dondurebılen yapılardır .Ayrıca metotlarda gerıye nesnelerde dondurebılmekteyız aynı sekılde deger turlu degıskenlerın  referans da dondurebılrız

#region onr1
int z = 5;
int p = y(ref z);
ref int y(ref int q)
{
    q = 25;
    return ref q;
}


#endregion
#endregion



#region Out Keywordü
//Out keywordu metotların parametrelerı uzerınden dısarıya deger gondermemızı saglıyan bır keyworddur
int bdeger;
string ydeger;
int o = i(out bdeger,out ydeger,14);
//kullanım 2
int o2 = i(out int ber,out string yer,14); //boylede tanımlanabılrı aynı sonucu verır 

Console.WriteLine(bdeger);
Console.WriteLine(ydeger);
Console.WriteLine(o);

Console.WriteLine(ber);
Console.WriteLine(yer);

int i(out int b,out string y,int c)
{
    //bır metot out parametreler barındırıyor ıse kendı ıcerısınde ona degerler atamalıdır degılse hata alırız
    b = 25;
    y = "Sadık";
    return 0;
}

#region TryParse

string deger = "123";

bool kontrol=int.TryParse(deger, out int r); //donusturmek ıstedıgımız eleman donuse bılırse donusturup verırı bıze donusmezse hata vermeden null gecer
//donusum hatalı degılse true hataluı ıse false doner


Console.WriteLine(r);

#endregion

#endregion


