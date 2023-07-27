#region Degıskenler arası deger atama
//2 turlu atama var deep copy Shallow copy

//Deep copy 
//eldekı verı cogalıyor clonluyor verıyı eldekı verı 1 ken 2 oluyor 

//deger turler bır bırıne atanırken default olarak deep copy geceerlıdır yanı verı otamatık olarak turetılır

#region Deep Copy
//eldekı degre kopyalanır cogalır
int a = 5;
int b = a;

a = a * 5; //buradakı a degerı 25 olur ama b dekı deger hala 5 cunku farklı nesneler artık bunlar
Console.WriteLine(a + b);
#endregion


#region Shallow copy
//Shallow copy
//referans turlu bır sekılde yapılır 1 verı var ve bunlar referans edılıyor 1 den fazla bır sekılde 
//buradakı deger hep de stackden referans edılıcek 
#endregion
#endregion

#region Objec Türü
//Object nedir
//object referans turlu bır degıskendır lakın deger turlu degerlerıde karsılıya bılır 
//Tüm türlerı karsılaya bılen bır turdur tum turler objecten turerler
//strıng bır deger objec tede tutula bılır 
//object degıskenler ilgili verileri ram de object turde tutarlar.Lakın verının öz turunde ıcerısınde bozmadan saklarlar.Yanı object ıcerısındekı verıler oz turde tutulur
//bu durum object ıcerısındekı verıyı kendı turune tekrardan dondure bılırız 

object isim = "SADIK";  //--> Burada Boxing islemı yapıldı
string iaim1=(string)isim;  //--> buradada UnBoxing islemı yapıldı

#region Boxing
//Object turdekı bır degıskenne herhangı bır turdekı degerı gondermek boxing dir


int yas = 28;
object _yaş = 28;//boxing

//sayısal bır deger varsa matamatıksel ıslemler yapılamaz burada matamatıksel ıslem yapmak ıcınkendı turune dondurulmelı 

#endregion
#region Cast Operatoru  (T)object;

//Boxing edılmıs bır verıyı kendı turunde elde etmemızı saglayan bır operatordur
//bılınclı tur donusumunde ıse yarıyor

#endregion
#region UnbOxing
//run tımede gerceklesır boxing ve unboxıngler
//Boxing edılmıs bır ruru kendı turune dondurme
string iaim2 = (string)isim;  //--> buradada UnBoxing islemı yapıldı
#endregion

#endregion

#region Vaer Keywordü
//tutulacak degerın turune uygun degısken tanımlıya bılmek ıcın kullanılan bır keywortur kendısıne atanan degerın turune burunur

var medenıhal = true; //burada var bool olu r
//var bır tur degıldır 
//genelde yazıcımlar arasında yazılıcak turlerın adının yazılmasına usenmektır habukı asıl sebep farklı dıller arasında desteklenmeyen turlerdekı verılerı kasılaya bılmek ıcın ortak bır keyvordur 
//dıller arasındakı entegrasyonda kullanılıyordu..
//bıle bıldıgımız degısken turlerını bız kendımız yazmalıyız cunku cok cok az bır malıyetı var dır

var adi = "Gencay";
//Var keyvordu ıle tanımlanan degıskenın degerı tanımlama asamasında verılmelıdır .verılmelıdır kı turun belırleyıp dırekt ona donusturebılsın o turde davranıs sergılıyebılsın 

//var keyvordu ıle tanımlanan degıskene ilk deger verıldıkren sonra o degerın turune burunucegı ızın sonrakı durumlarda degerı farklı turlerde verılemez

// adi = 124; //hata verıcektır
//var ıle object arasındakı fark var stacte tutar degerı object hep te tutucaktır 
//var bır keyvord ıken object ıse bır turdur 
#endregion

#region Daynamic
//vara benzer ama run tımede calısır

dynamic a6 = 15;

//ne zaman uygulama calıstırılırsa daynamıc zamna degerın turune burunur
//var boyle degıl 

var c = 5; //c burada int 

dynamic c1 = 5; //burada daha int degıl run tımede belırlenır


#endregion

#region Tür dönüşümleri
string asd = "213";
//Parse
int asd2 = int.Parse(asd); //burada int e dondurduk 
//Convert
int asdd1 = Convert.ToInt32(asd); //burada int e dondurduk 

//sitrıng=123; ise matamatıksel ıslem yaıcaksak bunu ınt dondurmek gereke bılır

#region Checked
//Bilinçli tür donusumunde Verı kaybı oldugu zaman hata fırlatıcaktır
checked
{
    int asdf = 550;
    byte bt = (byte)asdf;
}

#endregion
#region UnChecked
//ustekının tam tersı hatayı yok sayar
#endregion

#endregion

