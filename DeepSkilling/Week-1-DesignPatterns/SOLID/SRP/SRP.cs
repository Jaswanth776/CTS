using System;

class Student
{
    public string Name { get; set; }
    public int RollNumber { get; set; }

    public Student(string name, int rollNumber)
    {
        Name = name;
        RollNumber = rollNumber;
    }
}

class StudentReport
{
    public void Print(Student student)
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Roll Number: " + student.RollNumber);
    }
}

class SRP
{
    static void Main()
    {
        Student student = new Student("Jaswanth", 101);

        StudentReport report = new StudentReport();

        report.Print(student);
    }
}
