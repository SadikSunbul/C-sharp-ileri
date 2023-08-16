

//yield



//IEnumerable<>

//using System.Numerics;
//using System.Runtime.CompilerServices;

//var numbers = GetNumbers();

//var enumerater=numbers.GetEnumerator();


////Aynı sekılde calısıcaktır 
//while(true)
//{
//    if(enumerater.MoveNext())
//    {
//        Console.WriteLine(enumerater.Current);
//    }
//    else
//    {
//        break;
//    }
//}


////List<int> numbers = new List<int>() { 1, 2, 3, 4 };

////list IEnuemrableden Türemiştir

////burada 1 count property sı yok ıenumerable ın 1 de indexer yok
////for (int i = 0; i < numbers.Count; i++)
////{
////    Console.WriteLine(numbers[i]);
////}

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}


using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

var oldnumbers = Generator.GetOddOlNumbers();

var oldnumberss = Generator.GetOddNUmbers().Take(10);//10 kere dondurur oradakı whileyi 10 kere dondruu ve 10 tane tek sayı geıtrir bıze burada enumeraterın ıceırısınden 10 tane data getır dedık 

var studentyield = Generator.GetStudent().ToList();
//ToList() dersek ilk once tum ogrencıler creat edılır tum verılerı aldı sonra studentyield a verdı ve ılk basta hepsının ctor u calsıtı verıelrı tutu ve en sonda verıelrı toplu uazdırdı
//To listin calsıma mantıgı soyledır altakı gıbı 

static List<Student> ToList(IEnumerable<Student> student)
{
    var result=new List<Student>();
    foreach (var str in student)
    {
        result.Add(str);
    }
    return result;
}

// var getenumerators = studentyield.GetEnumerator();
//foreach (var number in oldnumbers)
//{
//    Console.WriteLine(number);
//}
//int counter = 0;
//while (true)
//{
//    counter++;
//    if (counter == 3) //burada beklentımız 3. yu atlar dıgerlerı yazdırılır gıbı dusunuyoruz ama oyle degıl herhangıbır yerde sen donguyu kırarsan bıter artık dıgerlerını getırmez
//    {
//        break;
//    }
//    if (getenumerators.MoveNext())
//    {
//        Console.WriteLine(getenumerators.Current.FirstName);
//    }
//    else
//    {
//        break;
//    }
//}

foreach (var student in studentyield) //MoveNext ı kendısı calıstırı
{
    Console.WriteLine(student.FirstName);
}

static IEnumerable<int> GetNumbers()
{

    return new List<int>()
    {
        1,2,3,4,5
    };
}



class Generator
{
    public static IEnumerable<int> GetOddOlNumbers()
    {//tek sayılar 
        yield return 1; //gerıye ınt donmek lazım uste int dedik
        yield return 3;
        yield return 5;
        yield return 7;
        yield return 9;
    }
    /*
     Burada MoveNext ilk cagrıldıgında 1 i alır sonrakı çagrılamda ilk 1 i aldıgını bı yerde tutar ve 3 u alır boyle devam eder bu

    Foreach ın yaptıgı sey zaten bu MoveNext ı cagırır
     */

    static int counter = 0;
    public static IEnumerable<int> GetOddNUmbers()
    {
        while (true)
        {
            counter++;
            if (counter % 2 == 1)
                yield return counter;
        }
    }

    public static IEnumerable<Student> GetStudent()
    {
        yield return GetStudent("Sadik", "Sunbul");
        yield return GetStudent("Oğuz", "Kaplan");
        yield return GetStudent("Kerem", "Gün");
        yield return GetStudent("Ünal", "Top");
        yield return GetStudent("Emrah", "Yaman");
        yield break; //burada degereler bıttı dedık 
    }
    //MoveNext nezaman true doner yield return var ıse true doner false yı ne zmaan doner ya hıc bısey gormezse false doner yada yield break gorurse false doner

    private static Student GetStudent(string firstName, string lastName)
    {
        Task.Delay(1000).Wait();
        return new Student(firstName, lastName);
    }
}

class Student
{
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Console.WriteLine("student class generated");
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}