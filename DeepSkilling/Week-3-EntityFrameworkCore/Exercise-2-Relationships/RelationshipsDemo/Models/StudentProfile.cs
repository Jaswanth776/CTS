namespace RelationshipsDemo.Models;

public class StudentProfile
{
    public int StudentProfileId { get; set; }

    public string Address { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public int StudentId { get; set; }

    public Student Student { get; set; } = null!;
}
