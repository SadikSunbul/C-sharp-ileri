using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

/*
 * Kullanılıcak methotlar
 * 
Curudİslemleri işlemler = new();
işlemler.Create(Kullanıcı);
işlemler.Update(_email, şifre);
işlemler.Read(email);
işlemler.Delete(_email ,şifre);
*/

Curudİslemleri işlemler = new();



//create oluşturma


Kullanıcı kullanıcı1 = new()
{
    İsim = "Sadık",
    Soyisim = "Sünbül",
    Mail = "Sadık.sunbul@gmail.com",
    Yaş = 19,
    Şifre = "Test1"
};

işlemler.Create(kullanıcı1);


//update guncelleme

işlemler.Update("Sadık.sunbul@gmail.com", "Test1");

//Read okuma burada maılı gırılen kısını bılgılerı gelır 

işlemler.Read("Sadık.sunbul@gmail.com");

//Delete silme
Console.ReadLine();
işlemler.Delete("Sadık.sunbul@gmail.com", "Test1");

class Kullanıcı
{
    public int Id { get; set; }
    public string İsim { get; set; }
    public string Soyisim { get; set; }
    public int Yaş { get; set; }
    public string Mail { get; set; }
    public string Şifre { get; set; }

}

class CrudislemleriContext : DbContext
{
    public DbSet<Kullanıcı> Kullanıcılar { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=CURDislemleri;User ID=SA;Password=Viabelli34*.;TrustServerCertificate=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kullanıcı>()
            .HasIndex(i => i.Mail)
            .IsUnique();  //benzersız olsun dedık 
    }
}


class Curudİslemleri
{
    CrudislemleriContext context = new();
    public async void Create(Kullanıcı kullanıcı)
    {
        if (!string.IsNullOrEmpty(kullanıcı.İsim) && !string.IsNullOrEmpty(kullanıcı.Soyisim) && !string.IsNullOrEmpty(kullanıcı.Mail) && !string.IsNullOrEmpty(kullanıcı.Şifre))
        {
            await context.Kullanıcılar.AddAsync(kullanıcı);
            await context.SaveChangesAsync();
        }
        else
        {
            await Console.Out.WriteLineAsync("Olusturdugunuz sınıta kı tum elemanları doldurunuz.. KAYIT YAPILAMADI");
        }

    }
    public async void Read(string _email)
    {
        var data = await context.Kullanıcılar.AsNoTracking().FirstOrDefaultAsync(i => i.Mail == _email);
        await Console.Out.WriteLineAsync($"Mail:{data.Mail}-İsim:{data.İsim}-Soyisim:{data.Soyisim}-Yaş:{data.Yaş}");
    }
    public async void Update(string _email, string _şifre)
    {
        var datas = await context.Kullanıcılar.FirstOrDefaultAsync(i => i.Mail == _email && i.Şifre == _şifre);
        if (datas != null)
        {
            int degerrr = 0;
            do
            {
                Console.Clear();
                await Console.Out.WriteLineAsync("Bu kullanıcıda degıstırmek ıstedıgınız alanı secınız...");
                await Console.Out.WriteLineAsync("1->İsim");
                await Console.Out.WriteLineAsync("2->Soyisim");
                await Console.Out.WriteLineAsync("3->Yaş");
                await Console.Out.WriteLineAsync("4->Şifre");
                await Console.Out.WriteLineAsync("Lütfen birini seçiniz:");
                int secılen = int.Parse(Console.ReadLine());
                switch (secılen)
                {
                    case 1:
                        datas.İsim = Console.ReadLine();
                        break;
                    case 2:
                        datas.Soyisim = Console.ReadLine();
                        break;
                    case 3:
                        datas.Yaş = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        datas.Şifre = Console.ReadLine();
                        break;
                }
                await Console.Out.WriteLineAsync("Başka değişiklık yapmak ıstıyorsanız 1 yazınız ıstemıyorsanız herhangı bır rakama tıkalyınız..");
                degerrr = int.Parse(Console.ReadLine());
            } while (degerrr == 1);

            await context.SaveChangesAsync();
            await Console.Out.WriteLineAsync("Değişiklikler basrılı bır sekılde yapıldı");
        }
        else
        {
            await Console.Out.WriteLineAsync("Boyle bır kullanıcı yok..");
        }
    }
    public async void Delete(string _email, string _şifre)
    {
        var datas = await context.Kullanıcılar.FirstOrDefaultAsync(i => i.Mail == _email && i.Şifre == _şifre);
        if (datas != null)
        {
            await Console.Out.WriteLineAsync("Kullanıcıyı sılmeye emınsenız 1 yazınız sılmekten vazgectıysenız herahngı bır rakama basa bılırsınız.");
            int deger = int.Parse(Console.ReadLine());
            if (deger == 1)
            {
                context.Kullanıcılar.Remove(datas);
                await context.SaveChangesAsync();
                await Console.Out.WriteLineAsync("Silme işlemi başarılı..");
            }
            else
            {
                await Console.Out.WriteLineAsync("Silme işlemnden vaz gectınız..");
            }
        }
        else
        {
            await Console.Out.WriteLineAsync("Boyle bır kullanıcı yok..");
        }
    }
}