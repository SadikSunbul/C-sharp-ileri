

#region Activator Sınıfı ile Nesne Oluşturma

//Type objectType = typeof(MyClass);

//MyClass instance = (MyClass)Activator.CreateInstance(objectType);

//MyClass instance = (MyClass)Activator.CreateInstance(typeof(MyClass));

#endregion

#region DynamicObject Sınıfı ile Nesne Oluşturma
/*
 DynamicObject sınıfı, C#'ın dinamik tür desteği özelliğini genişletmek için kullanılan bir sınıftır. Dinamik tür desteği sayesinde,
derleme zamanında türünü belirlemediğimiz nesneleri çalışma zamanında oluşturma ve manipüle etme yeteneğine sahip
olabilmekteyiz.
DynamicObject sınıfı ile, bir sınıfın dinamik olarak davranış sergilemesini sağlayabiliriz.
 */

using System.Dynamic;

dynamic instance = new MyClass();
// x.A(); //A nın olup olmdagıınıı run tıme da bakıcaktır 

instance.DynamicProperty1 = "123"; //trysetmember tetıkleniyor
instance.DynamicProperty2 = 123;

Console.WriteLine(instance.DynamicProperty1); // "123"

#endregion

#region dynamic Ke wordlü İle Nesne OlU turma

dynamic istance = new ExpandoObject();  //sanki nesne varmış gibi düşün aslında nesne yok 
istance.DynamicProperty1 = "123";
istance.DynamicProperty2 = 123;

Console.WriteLine($"{istance.DynamicProperty1} - {istance.DynamicProperty2}");

#endregion


class MyClass : DynamicObject
{
    public MyClass()
    {
        Console.WriteLine($"{nameof(MyClass)} instance created");
    }
    private readonly Dictionary<string, object> properties = new();
    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        properties.Add(binder.Name, value);
        return true;
    }
    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        return properties.TryGetValue(binder.Name, out result);
    }
}