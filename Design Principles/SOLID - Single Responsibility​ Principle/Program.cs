

#region Single (tek sorumluluk prensibi)

/*
 Single Responsibility Principle, OOP tasarımlarında bir
sınıfı mümkün mertebe tek bir sorumluluğa odaklı inşa
edilmesi gerektiğini ilke olarak savunan bir prensiptir.
 */

#region Hatalı tasarım 


class DataBase
{
    public void Connect()
    {
        //...
        Console.WriteLine("Veri tabanına baglantı saglandı");
    }

    public void Disconnect()
    {
        Console.WriteLine("veri tabanı bağlantısı kesildi");
    }

    public string State { get; set; }
    public List<Person> GetPerson()
    {
        return new()
        {
            new Person(){Name="Sadık"},
            new Person(){Name="Ahmet"},
            new Person(){Name="Taha"},
            new Person(){Name="Tahiri"},
        };
    }
}

class Person
{
    public string Name { get; set; }
}

#endregion

#region Doğru tasarım

class DataBase2
{
    public void Connect()
    {
        //...
        Console.WriteLine("Veri tabanına baglantı saglandı");
    }

    public void Disconnect()
    {
        Console.WriteLine("veri tabanı bağlantısı kesildi");
    }
    public string State { get; set; }
}

class PersonService
{
    public List<Person> GetPerson()
    {
        return new()
        {
            new Person(){Name="Sadık"},
            new Person(){Name="Ahmet"},
            new Person(){Name="Taha"},
            new Person(){Name="Tahiri"},
        };
    }
}

#endregion

#endregion