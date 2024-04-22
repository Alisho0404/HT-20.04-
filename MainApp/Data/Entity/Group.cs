using MainApp.Data.Entity.Enums;

namespace MainApp.Data.Entity;

public class Group:BaseEntity
{
    public required string GroupName { get; set; }
    public string? Description { get; set; }
    public GroupStatus GroupStatus { get; set; }
    public int CourseId { get; set; }
    public Course? Course { get; set; }
    public List<StudentGroup>? StudentGroups { get; set; }
    public List<MentorGroup>? MentorGroups { get; set; }

}