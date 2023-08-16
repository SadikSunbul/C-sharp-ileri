using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Matching_Nedir;

public class Student
{
    public string FullName { get; set; } = "Sadık Sünbül";

    public int ExamResult { get; set; }

    public Student(int examResult)
    {
        ExamResult = examResult;
    }
}


public class ITStudent : Student
{
    public ITStudent(int examResult) : base(examResult)
    {

    }
    public int ComputerExamResult { get; set; }

}

public class MISStudent : Student
{
    public MISStudent(int examResult) : base(examResult)
    {
    }
    public int ProjectManagementExampleResult { get; set; }
}