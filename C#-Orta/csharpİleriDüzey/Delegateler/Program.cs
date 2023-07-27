using Delegateler;
using System;


#region Delegate

//Delegeler, metodların adreslerini dolayısıyla metodların kendilerini tutabilen, işaret edebilen yapılardır.

//[Erişim Belirleyicisi] delege [geri dönüş tipi] [delege ismi] (eğer varsa parametre)




/*IslemYapHandler delege = new IslemYapHandler(Topla);
delege += Carp;
Console.WriteLine(delege(2, 3).ToString());*/
/*
 Eğer yukarıdaki kod bloğunu derleyip çalıştırırsanız ne olur? Sanıyorsunuz ki, delegemizin içinde iki metod var ve ikiside çalıştırılacak.Yani önce Topla metodu çalıştırılıp 5 sonucunu verecek, ardından Carp metodu çalıştırılıp 6 sonucu verilecek.Yada buna benzer durumlar olacak.. Ama sandığınız gibi değil. 🙂 (bende başta bu şekilde sanmıştım.) Sonuç olarak 6 cevabı verilecektir.Çünkü delegeye bağlanan en son metod çalışır.Burada delegemize bağlanan en son metod Carp metodumuz olduğu için, o çalışacaktır.Yani Topla metodu çalışıp, ardından Carp çalışmayacaktır.
 */
/*
int Topla(int s1, int s2)
{
    return s1 + s2;
}
int Carp(int s1, int s2)
{
    return s1 * s2;
}
*/
//Şimdide delegemiz içindeki tüm metodlarımız da sırasıyla gezebilmek için,delegate referansımız üzerinden GetInvocationList() metodunu kullanıyoruz.

/*IslemYapHandler delege1 = new IslemYapHandler(Topla);
delege1 += Carp;
Delegate[] metodlarımız = delege1.GetInvocationList();//C# delegelerinde GetInvocationList() yöntemi, bir delegenin işaret ettiği tüm yöntemleri bir Delegate dizisinde döndürür.
foreach (Delegate item in metodlarımız)
{
    Console.WriteLine("Metodumuzun adı : " + item.Method.Name);
    Console.WriteLine("Metodumuzun geri dönüş tipi : " + item.Method.ReturnType);
    int sonuc = (int)item.DynamicInvoke(2, 3);
    Console.WriteLine("Şuanki metodun sonucu : " + sonuc.ToString());
}
*/
/*Yukarıda gördüğünüz gibi delegemizin içinde Topla ve Carp metodları vardır.Delegate’imizin referansına GetInvocationList() metodunu çalıştırdığımızda, geriye Delegate[] dizisi tipinden veriler dönüyor ve ben bunları Delegate[] metodlarımız dizisine alıyorum.Foreach döngüsüyle bu dizide dolasıyorum.Bu dizideki metodların özelliklerine(adı, geridönüş değeri v.s.) bakabiliyorum.Burada değinmem gereken bir metod var.DynamicInvoke(),bu metod sayesinde o anda item referansına gelen metodu çalıştırabiliyoruz.Params tipinden değişken aldığı için metodların çalıştıracağı kadar parametre yazıyorum.*/

//public delegate int IslemYapHandler(int a, int b);


#endregion

#region Event
/*Bir buton nesnesine farenin sol tuşuyla tıkladığımızda,bir textbox nesnesine bir karakter girdiğimizde ya da fareyle combobax daki elemanlardan birini seçtiğimizde bir olay gerçekleşir.İşte bu durumların hepsi bir olaydır.*/
/*class deneme
{
     class button1
    {
        public static string Click { get; set; } //BUTON ISLEMELRI
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        button1.Click += new EventHandler(Tiklandi);
    }
    void Tiklandi(object sender, EventArgs e)
    {
        *//*Click olayı Control sınıfı içinde tanımlanmış bir Event tır.O sınıf içerisinde aynı zamanda Click olayının meydana gelip gelmediği de sürekli kontrol edilmektedir.Eğer o sınıf, Click olayının oluştuğunu tespit ederse , ” += ” ile o olaya bağladığım metod çalıştırılacaktır.Halbuki o sınıf benim Click e bağladığım bu sınıftaki metottan haberdar olmayacaktır.O sınıfı, bu sınıftaki metottan haberdar etmek için,bu sınıftaki metodu çalıştırabilmek için yine o sınıfta tanımlı olan delegeyi(EventHandler) kullanıyoruz.*//*
    }
}*/

/*class SayiKontrol
{
    public delegate void SayiKontrolEtHandler();
    public event SayiKontrolEtHandler SayiDurumu;
    int sayi;
    public int Sayi
    {
        get
        {
            return sayi;
        }
        set
        {
            sayi = value;
            if (sayi < 10)
            {
                // Olay çalışsın
                // Ey olay, sana SayiKontrolEtHandler delegesinin bağladığı metodu çalıştır diyeceğiz :)
            }
        }
    }
}*/
/*ukarıda gördüğünüz SayiKontrol sınıfında,geri dönüş tipi olmayan,parametre almayan metodlara uygun SayiKontrolEtHandler adında bir delege yazılmıştır.Ve bu delege tipinde,SayiDurumu adında bir event yazılmıştır.
UNUTMAYIN!!! : Eventların tipi,kendisine metod bağlayacak delegenin tipinden olur.*/

/*class SayiKontrol1
{
    public delegate void SayiKontrolEtHandler();
    public event SayiKontrolEtHandler SayiDurumu;
    int sayi;
    public int Sayi
    {
        get
        {
            return sayi;
        }
        set
        {
            sayi = value;
            if (sayi < 10)
            {
                if (SayiDurumu != null)
                {
                    SayiDurumu();
                }
            }
        }
    }
}*/
/*Eğer Sayi propertysine 10 dan küçük bir sayı girilirse SayiDurumu eventı fırlatılacaktır.Şimdi SayiDurumu eventına metod bağlayalım.*/
/*private void Form1_Load(object sender, EventArgs e)
{
    SayiKontrol nesne = new SayiKontrol();
    nesne.SayiDurumu += new SayiKontrol.SayiKontrolEtHandler(kontrol);
    nesne.Sayi = 77;
}
void kontrol()
{
    MessageBox.Show("Sayi özelliği 10 dan küçük olamaz");
}*/
/*Gördüğünüz gibi, SayiDurumu eventına ” += ” operatörü vasıtasıyla SayiKontrolEtHandler delegesi üzerinden kontrol metodunu bağladım.Eğer bu programı çalıştırırsanız kontrol metodu çalıştırılmayacaktır.Çünkü,SayiDurumu eventına SayiKontrolEtHandler delegesi üzerinden kontrol metod bağlanıyor ve Sayi özelliğine 77 rakamı set edildiğinde,classtaki sayi fieldına gelen değerin 10 dan küçük olmadığını bildiği için if scopeları içine girmeden akışı durduruyor.Yani SayiDurumu eventı şu durumdayken atılmıyor.Eğer 10 dan küçük değer girersek kontrol metodu çalışacaktır.*/
#endregion

#region Event delegate ler ıle kullanılır
//bellı bır sart saglandıgında bellı olayları cagırırlar butomum clıc eventı vb..


eventdenemee.Tetssayfası();

#endregion
