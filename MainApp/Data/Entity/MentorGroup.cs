using MainApp.Data.Entity.Enums;

namespace MainApp.Data.Entity;

public class MentorGroup:BaseEntity
{
    public int GroupId { get; set; }
    public Group? Group { get; set; }
    public int MentorId { get; set; }
    public Mentor? Mentor { get; set; }
    public MentorGroupStatus MentorGroupStatus { get; set; }
}