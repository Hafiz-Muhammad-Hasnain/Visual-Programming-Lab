using System;

public class Person
{
    public string Name { get; set; }

    public Person() 
    {
        Name = null;
    }

    public Person(string name) 
    {
        Name = name;
    }
}

public class Student : Person
{
    public string RegNo { get; set; }
    public int Age { get; set; }
    public string Program { get; set; } 

    public Student() 
    {
        RegNo = null;
        Age = 0;
        Program = null; 
    }

    public Student(string name, string regNo, int age, string program) : base(name) 
    {
        RegNo = regNo;
        Age = age;
        Program = program;
    }
}

class Program
{
    static void Main()
    {
    
        Student student1 = new Student("Hasnain", "233525", 20, "CS");

        Console.WriteLine($"Student1 - Name: {student1.Name}, RegNo: {student1.RegNo}, Age: {student1.Age}, Program: {student1.Program}");
    }
}