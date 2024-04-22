using MainApp.Data.Entity.Enums;

namespace MainApp.Data.Entity;

public class Student : BaseEntity
{
    public  string? FirstName { get; set; }
    public  string? LastName { get; set; }
    public  string? Email { get; set; }
    public  string? Phone { get; set; }
    public  string? Address { get; set; }
    public Gender Gender { get; set; }
    public StudentStatus Status { get; set; }
    public List<StudentGroup>? StudentGroups { get; set; }
}