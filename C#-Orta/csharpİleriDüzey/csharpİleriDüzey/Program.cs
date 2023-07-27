using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using csharpİleriDüzey;


#region DebuggerDisplay overide
/*

Student s = new();


Console.WriteLine(s.ToString());//burada overıde acık ıse orayı kullanır acık degılse debuggerdısplayportu kullanır







[DebuggerDisplay("{debggerDisplayMethot}")]
public class Student
{
    public string FirstName { get; set; } = "Sadık";
    public string LastName { get; set; } = "Sünbül";

    public override string ToString()   //student 
    {
        return $"{FirstName} {LastName}";

    }

    public string debggerDisplayMethot => "Class Debugger Display";

}
*/
#endregion

#region List[0] manuel yapımı


List<int> list = new List<int>() {
    1,
    2,
    3,
    4,
    5
        };

list.Add(6);

Console.WriteLine(list[4]);


MyList<int> mylıst = new();

mylıst.Add(2);

Console.WriteLine(mylıst[2]);
Console.WriteLine(mylıst[2,"SADIK"]);
Console.WriteLine("Tamam");
Console.ReadLine();
public class MyList<T> : IEnumerable<T>
{

    public string Add(int a) => $"Eklendi:{a}";  

    public string this[int a] =>$"{a}:okundu"; //burada kendı sınıflarımıza ındexer ekledik

    public string this[int a ,string b]=>$"{a}-{b}"; //ustekı ıle aldıgı paramete rurleruı farklı ıse yanı sankı bır coklu yukleme gıbı fark varsa kullanılır

    public IEnumerator<T> GetEnumerator()
    {
        throw null;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw null;
    }
}


*/
#endregion

#region Abstract detayı
/*
var d = new DerivedClass();

// var b = new BaseClass();//hata verır cunkı abstarct claslar new lenmez


public abstract class BaseClass
{
    public abstract string add();
}

public sealed class DerivedClass : BaseClass //sealed bu kılasatn sonra baska bı clas kalıtılmasın der
{
    public override string add()
    {
        throw null;
    }
}

public class DerivedClass2: DerivedClass //sealed yazdıgımız ıcın calısmıyor
{

}
*/
#endregion

#region Using kullanımı 
/*
MyMain();

void MyMain()
{//genelde server ıslemlerınde kullanılır

    using (HttpClient cl = new HttpClient())
    {
        //cl dısarıda kullanamayız
    }

    using HttpClient cl1 = new();

    using Tets tets = new Tets();   //ilk basta hata verıcektır classa IDisposable interface sını ınplament etmek gerekır

    tets.print();

    using Tets tets1 = CreateTestClass();
    Console.WriteLine(tets1.IsDisposed);
    Console.WriteLine(tets1.Connection.State);
    tets1.print();


}

Tets CreateTestClass()
{
    using Tets result = new();
    return result;
}

class Tets : IDisposable
{
    public SqlConnection Connection { get; set; }
    public bool IsDisposed { get; private set; }=false;

    public string Name { get; set; }
    
    public Tets(string name)
    {
        Name = name;
        Connection = new SqlConnection();
        //Connection.Open();
    }

    public void print()
    {
        Console.WriteLine("From Tets Class.Name:{1}.IsDisponsed:{0}",IsDisposed,Name);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
        if (Connection is not null)
        {
            if (Connection.State is not System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
            Connection.Dispose();
        }
    }
    public Tets()
    {
        IsDisposed = true; //bu metot cagrılınca true yapatık

       
    }
}
*/
#endregion

#region ErişimBelirleyicileri

/*
            public   -->heryerden

            internal  --> tanımlandıgı kutuphane ıcerısınde kullanıla bılır aynı publıc gıbı 
            
            private  -->sadece bulundugu clastan eısıle bılır

            protected --->sadece implament edılen yerlerden kullanılsın

            protected internal  -->sadece bu kutuphane ce implament(kalıtılmıs) edılen yerlerden kullanılsın 

            private protected   -->c#7.2 -->pek kullanılmaz 
 */




#endregion

#region Abstaract ve ınterface arasındakı farklar
//abstract lar new lenmez
//Interface ---> Sozlesme veya bırseyı yapabılme yetenegı belırtır
//bır class ıstedıgı kadar ınterfaceden kalıtıla bılır ama saddece 1 clas abstaactan calıtıla bılır
/*
var sqldb = new SqlServerDb();
sqldb.ExecuteSql("");

var oracle = new OracleDb();
sqldb.ExecuteSql("");

// var b = new BaseDb(); //haat verırı

*/

#endregion


