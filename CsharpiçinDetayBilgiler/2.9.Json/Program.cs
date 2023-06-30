/*
 Json Nedir ?
Json programlama dilinden bağımsız olarak javascript tabanlı veri değişim formatıdır.
Json temel kullanımı ajax işlemlerimizde veri taşımak içindir fakat az yer kaplaması ve bize
sunduğu avantajlardan dolayı noktadan noktaya veri taşıma olarak xml in yerini almıştır.
Xml formatına göre daha az yer kaplar ve kullanımı xml sistemine göre daha basittir.
 */

using _2._9.Json;
using System.Configuration;

using System.Data;

List<Personel> Personeler=new List<Personel>();

for (int i = 0; i < 1000; i++)
{
    Personel p1 = new();
    p1.Id=Guid.NewGuid();
    p1.Isim = FakeData.NameData.GetFirstName();
    p1.Soyisim= FakeData.NameData.GetSurname();
    p1.EmailAdress = $"{p1.Isim}.{p1.Soyisim}@.{FakeData.NetworkData.GetDomain()}";
    p1.TelefonNo = FakeData.PhoneNumberData.GetPhoneNumber();
    Personeler.Add(p1);
    p1.Sehir = FakeData.PlaceData.GetCounty();
}
Console.WriteLine("Bilgileriniz json formatında c:\\JsonIslemelri\\Personellerim.json olarak kayır edılcek");
#region Json işlemleri
//Newtonsoft.Json incek
#region Yazma
if (Directory.Exists("c:\\Users\\artredline\\Desktop\\jsondeneme\\"))
{
    //varsa herhangı bır ıslem yapılmıycak 
}
else
{//yok ıse olustur 
    Directory.CreateDirectory("c:\\Users\\artredline\\Desktop\\jsondeneme\\");
}
string jsonPersonellerim=Newtonsoft.Json.JsonConvert.SerializeObject(Personeler); //json formatına dondurduk 
//dosyaya kaydetmek
File.WriteAllText("c:\\Users\\artredline\\Desktop\\jsondeneme\\Personellerim.json", jsonPersonellerim); //jsonpersonellerıme kaydeder 

Console.WriteLine("Json export ıslemerı tamamlandı");
#endregion

#region Okuma
string okunandata=File.ReadAllText("c:\\Users\\artredline\\Desktop\\jsondeneme\\Personellerim.json");//bunu okuycak

var data =Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personel>>(okunandata);

Console.WriteLine("");

#endregion

#endregion



