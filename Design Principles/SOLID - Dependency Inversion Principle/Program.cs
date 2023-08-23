


#region SOLID - Dependency Inversion Principle

/*
 Dependency Inversion Principle, bir sınıfın herhangi bir
türe olan bağımlılık durumuna karşı dikkatimizi çeken
ve bu bağımlılığın mümkün mertebe tersine
çevrilmesini öneren bir ilkedir.

BU prensip; geliştiricinin herhangibir türe bağımlı
olmadığını, bilakis türlerin/yani nesnelerin geliştiriciye
bağımlı OldUğı.JrlU savcını..jr.

BU ilkeyi anlayabilmek için birkaç örnek üzerinden
istişare etmekte fayda vardır.
 */
#region Not Ideal Code
MyNamespace.MailService mailService = new();
mailService.SendMail(new MyNamespace.Gmail());
#endregion

#region Ideal Code
MailService mailService1 = new();
mailService1.SendMail(new Gmail(), "...", "...");
mailService1.SendMail(new Hotmail(), "...", "...");
#endregion

#region İdeal code
class MailService
{
    public void SendMail(IMailServer mailServer, string to, string body)
    {
        mailServer.Send(to, body);
    }
}

interface IMailServer
{
    void Send(string to, string body);
}
class Gmail : IMailServer
{
    public void Send(string to, string body)
    {
        //...Send Mail...
    }
}
class Yandex : IMailServer
{
    public void Send(string to, string body)
    {
        //...Send Mail...
    }
}
class Hotmail : IMailServer
{
    public void Send(string to, string body)
    {
        //...Send Mail...
    }
}
#endregion
#region İdeal olmayan cod
namespace MyNamespace
{
    class MailService
    {
        public void SendMail(Gmail gmail)
        {
            gmail.Send("...");
        }
    }

    class Gmail
    {
        public void Send(string mail)
        {
            //...Send Mail...
        }
    }
    class Yandex
    {
        public void SendMail(string mail, string to)
        {
            //...Send Mail...
        }
    }
    class Hotmail
    {
        public void Send(string mail)
        {
            //...Send Mail...
        }
    }
}
#endregion
#endregion