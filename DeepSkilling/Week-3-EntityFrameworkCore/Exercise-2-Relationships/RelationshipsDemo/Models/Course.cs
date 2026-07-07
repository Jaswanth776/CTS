namespace RelationshipsDemo.Models;

public class Course
{
    public int CourseId { get; set; }

    public string Title { get; set; } = string.Empty;

    public ICollection<Student> Students { get; set; } = new List<Student>();
}
