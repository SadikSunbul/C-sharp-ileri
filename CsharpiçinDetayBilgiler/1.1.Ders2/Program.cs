
#region Ternary Operatoru
//Bır deıskene mothoda yada propertye deger atarken . egerkı bu deger sarta gore fark edecekse satır bazlı tek satırdea bu sart kontrolunu yaparak duruma gore degerı dondurmemızı saglayan bir kalıpsal operatordür.

//......sart/durum ..... ? ....... : .......;

bool medenihal = true;

string mesaj= medenihal  ? "Evlilere kanpanya" : "Bekarlara kanpanya";
Console.WriteLine(mesaj);
//gerı donucek degerlerı aynı turde olmalı 


#endregion

//sizeof -->verılen turun bellekte kac bytlı yer kapladıgını strıng olarak dondurur

//typof -->verılen turun typ-->turunu  ini verir

//default -->belırtılen turun default degerını dondurur 

#region İs
//Boxing e tabı tutulmus bır degerın öz turunu ogrenebılmek ıcın check edebılmek kontrol edebılmek ıcın kullanılan bır operatordur
//is operatoru denetleme netıcesınde durumu yanı true yada false olarka donecektır
object x = true;//boxin
Console.WriteLine(x is bool); //x in turu bool mu ?
#endregion
#region is null
//bir degiskenın degerını null olup olmadıgını kotrol eder ve bool doner
string a = null;
Console.WriteLine(a is null);

//is null oparetorunu sadece null olan operatorlerde kullana bılırız
//int = null veremeyız bu deger tur bool da null olamaz
//string=null verılır cunku strıng bır referans tur
#endregion
#region is not null
//elımızdekı degerın null olup olmaması ıle ılgılenmekte ve bool doner utekı ıle tam ters 
//is null oparetorunu sadece null olan operatorlerde kullana bılırız
//int = null veremeyız bu deger tur bool da null olamaz
//string=null verılır cunku strıng bır referans tur

string b = "as";
Console.WriteLine(b is not null);

#endregion

#region as operatoru
//cast operatorunun unboxıng ıslemıne alternatıf olarak tretılmıstır

//cast 
object sa = 123;
int sa1 = (int)sa;
// burada int yerıne baska bı tur olsa mesela bool hata fırlatıcaktır 
//as operatoru bu durumlarda null degerı dondurur hata fırlatmaz

object sa2 = 123;
Type sa3 =sa2 as Type;
//as operatoru tur uygun olmadıgı takdırde gerıye null dondurecegı ıcın bu nullu karsılayabılen turlerle calısmak ıstıyecektır.Halıyle as operatoru deger turlu degıskenlerde kullanılmaz!!
//Referans turlu degıskenlerle calısabılır

object qwe = "adASFSA";
string qwe1 = qwe as string;
//yukarıda bunu yapamıycaktık burada strıng null ala bılfıgı ıcın calısır
#endregion

#region Nullable operatoru  '?'
//c# da deger turlu degıskenler normal sartlarda null deger alamazlar 
//bır deger turlu degıskenın null deger alabılmesı ıcın ? operatoru kullanılmalıdır 
int? a12 = null;
bool? b124 = null; //true falsede verıle bılır extra null da alır ozamna ıs null kontrolude yapıla bılır artık as gıbı turlerı kullana bılırız
object xe = 123;
int? we1 = xe as int?;

#endregion
#region ?? null-Coalescing operatoru
//elimizdekı degıskenın degerının null olması durumuna ıstıfaden farklı bır degerın gonderılmesını gondermemızı saglayan operatordur
string a1d = null;

Console.WriteLine(a1d??"merhaba"); //a1d degerı null ıe merhaba yadırıcaktır 
//?? her ıkı taraftakı degıken yada degerler aynı turlu olmalıdır 
#endregion
#region Null Coalescing assignment '??='

string asd = null;
Console.WriteLine(asd??="Merhaba");
//asd nın degerı null ıse ekrana merhaba yazdır ve asd nın degerını merhaba yı ata


#endregion