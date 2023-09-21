using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Student
{
    public string Name { get; set; }
    public int StudentId { get; set; }
    public double Grade { get; set; }

    public abstract bool IsPassed(double grade);
}

public class Undergraduate : Student
{
    public override bool IsPassed(double grade)
    {
        return grade > 70.0;
    }
}

public class Graduate : Student
{
    public override bool IsPassed(double grade)
    {
        return grade > 80.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var undergraduateStudent = new Undergraduate
        {
            Name = "Lavanya",
            StudentId = 1033386,
            Grade = 75.0
        };

        bool isUndergraduatePassed = undergraduateStudent.IsPassed(undergraduateStudent.Grade);
        Console.WriteLine($"{undergraduateStudent.Name} ID: {undergraduateStudent.StudentId} has passed: {isUndergraduatePassed}");

        var graduateStudent = new Graduate
        {
            Name = "Bhavagna",
            StudentId = 1033387,
            Grade = 85.0
        };

        bool isGraduatePassed = graduateStudent.IsPassed(graduateStudent.Grade);
        Console.WriteLine($"{graduateStudent.Name} ID: {graduateStudent.StudentId} has passed: {isGraduatePassed}");
        Console.ReadKey();
    }
}


