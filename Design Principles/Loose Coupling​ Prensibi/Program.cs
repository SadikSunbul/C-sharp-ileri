



#region Hatalı tasarım 
//class MailSender
//{
//    public void Send()
//    {
//        Gmail gmail = new Gmail(); //Bağımlılık vardır burada drekt new kullanılmıstır
//        gmail.Send("sadik@gmail.com");
//    }
//}

//class Gmail //burayı degıstırırsem yukarıda da bu degısıklıklerı uygulamama gerekebilir buda bizim istemediğimiz bir durumdur 
//{
//    public void Send(string to)
//    {
//        //..
//    }
//}

//class HotMail
//{

//}

#endregion

#region Doğru tasarım

MailSender mailSender = new MailSender();

mailSender.Send(new Mail()); //buada kullanıcı ne isterse onu yazar buraya 


class MailSender
{
    public void Send(IMailServer mailServer)
    {
        mailServer.Send("sadik@gmail.com", "lay lay lom");
    }
}


interface IMailServer
{
    void Send(string to, string body);
}
class Mail : IMailServer
{
    public void Send(string to, string body)
    {
        //...
    }
}

class Hotmail : IMailServer
{
    public void Send(string to, string body)
    {
        //....
    }
}

class Yandex : IMailServer
{
    public void Send(string to, string body)
    {
        //....
    }
}

#endregion