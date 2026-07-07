namespace RelationshipsDemo.Models;

public class Student
{
    public int StudentId { get; set; }

    public string Name { get; set; } = string.Empty;

    public StudentProfile? StudentProfile { get; set; }

    public ICollection<Course> Courses { get; set; } = new List<Course>();
}
