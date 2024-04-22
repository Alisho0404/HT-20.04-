using MainApp.Data.Entity.Enums;

namespace MainApp.Data.Entity;

public class Mentor:BaseEntity
{
    public  string? FirstName { get; set; }
    public  string? LastName { get; set; }
    public  string? Email { get; set; }
    public  string? Phone { get; set; }
    public  string? Address { get; set; }
    public Gender Gender { get; set; }
    public MentorStatus MentorStatus { get; set; }
    public List<MentorGroup>? MentorGroups { get; set; }
    
}