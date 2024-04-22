using MainApp.Data.Entity.Enums;

namespace MainApp.Data.Entity;

public class Course:BaseEntity
{
    public required string CourseName { get; set; }
    public string? Description { get; set; }
    public CourseStatus CourseStatus { get; set; }
    public List<Group>? Groups { get; set; }
}