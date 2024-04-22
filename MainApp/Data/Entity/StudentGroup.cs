    using MainApp.Data.Entity.Enums;

    namespace MainApp.Data.Entity;

    public class StudentGroup:BaseEntity
    {
        public int GroupId { get; set; }
        public Group? Group { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public StudentGroupStatus StudentGroupStatus { get; set; }
    }