using System;

namespace _1._3.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            // myClass.MyClass2 //gelemez cunku elemanı degıldır 
            MyClass.MyClass2 myClass2 = new(); //boyle ıcındekıne erısebılrırız bu nesnenın turu myclas2 dır yanı ıcerısınde x vb seyler yok dıgerınden gelmez

            MyClass3 myClass3 = new();
        }
    }

    #region class içerisindeki tanımlanan class elemanı mıdır?

    class MyClass
    {
        int a;
        public int MyProperty { get; set; }
        public void x() { }
        public int this[int a] { get => a; }  //lıstelerde kullandıgımız zımbırtı 
        //bunlarınhepsı clas elemanıdır 

        public class MyClass2 //bu klasın elemanı degıldır 
        {

        }
    }

    #endregion
    #region Class elemanlarına acıklama satırı nasıl eklenir
    /// <summary>
    /// Acıklama satırını burada yazarız
    /// </summary>
    class MyClass3
    {
        /// <summary>
        /// buradakı property dır 
        /// </summary>
        public int MyProperty { get; set; }
    }
    #endregion
    #region This keywordü nedir? işlevi nelerdir?
    //statık yapıalrda thıs yok tur erısılemez
    #region 1. Sınıfın Nesnesini Temsil eder
    class MyClass4
    {
        public int y { get; set; }

        public void x()
        {
            this.y = 1;
        }

    }


    #endregion

    #region 2. Aynı İsimde Field ile methot parametrelerını ayırmak ıcın kullanılır

    class MyClass5
    {
        int a;
        public void x(int a)
        {
            //a  -->Bu buradakı parametre olan a yı temsil eder
            // this.a bu ıse ustekı class elemanı olan a yı temsıl eder

        }
    }

    #endregion

    #region 3. Bir ctor dan baska bır ctor ı cagırmak ıcın kullanılır

    //Burada, ikinci constructor ("Person(string name, int age)") ilk olarak "this(name)" kodu ile ilk constructor'u çağırır ve ardından "Age" özelliğine değer atar. Bu sayede, aynı işlemleri tekrar etmek yerine, daha önce tanımlanmış bir constructor'u kullanarak kod tekrarını önlemiş oluruz.
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.Age = age;
        }
    }

    #endregion

    #endregion
}
