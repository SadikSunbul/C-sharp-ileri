



#region Pattern Matching Nedir?

using Pattern_Matching_Nedir;

var studentList = new List<Student>()
{
    new ITStudent(new Random().Next(0, 100)){ComputerExamResult=33},
    new MISStudent(new Random().Next(0, 100)),
}; //buradakı sınıflar Studentan kalıtıldıgı ıcın konulabıldı

var student = studentList[new Random().Next(studentList.Count)];

if (student is ITStudent) //bu student ITStudent bu mudur 
{
    // ITStudent itStudent1=student as ITStudent;//cast ettık
    ITStudent itStudent1 = (ITStudent)student;//cast ettık

    Console.WriteLine("Fulname :" + itStudent1.FullName);
}

//ustekı kullanımın aynısı eger student ITStudent ıse drekt kendısı cast edıyor ve itStudenta atıyor ustekı gıbı manuel cast etmemıze gerek kalmıyor 
if (student is ITStudent itStudent) //true olursa cast eder
{
    Console.WriteLine("Fulname :" + itStudent.FullName);
}




if (student is ITStudent itStudents) //true olursa cast eder
{
    if (itStudents.ComputerExamResult > 25 && itStudents.ComputerExamResult < 50)
    {
        Console.WriteLine("26 ile 50 arasında");
    }
    else
    {
        Console.WriteLine("arada değil", itStudents.ComputerExamResult);
    }
}

if (student is ITStudent { ComputerExamResult: > 25 and < 50 } itStudentss)
{//burada student ın ITStudent dan turedıgını ve ComputerExamResult ın 25 ıle 50 arasında oldugunu kontrol eder 
    Console.WriteLine("26 ile 50 arasında");
}
else
{
    Console.WriteLine("arada değil");
}


if (student is ITStudent || student is not MISStudent { ProjectManagementExampleResult: > 30 })
{//ITStudent ıse drekt gırer ama MISStudent ıse 30 dan buyuk ıse girme  dedik cunku not var 30 dan kucuk MISStudent lar gırıcektır ıcerıye
    Console.WriteLine(student.GetType().FullName);

    if (student is MISStudent mis)
    {
        Console.WriteLine("result:", mis.ProjectManagementExampleResult);
    }
}

var mezun = student switch
{
    ITStudent itstudent => itstudent.ComputerExamResult > 49,
    MISStudent mISStudent => mISStudent.ProjectManagementExampleResult > 69,
    Student student1 => student1.ExamResult > 29,
    _ => false
};


#endregion
