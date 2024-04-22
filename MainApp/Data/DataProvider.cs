using MainApp.Data.Entity;
using MainApp.Data.Entity.Enums;

namespace MainApp.Data;

public static class DataProvider
{
    #region Courses

    public static List<Course> Courses { get; private set; } = new()
    {
        new Course()
        {
            Id = 1,
            CourseName = "C++",
            CourseStatus = CourseStatus.Active,
            Description = "Only forwards",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
        },
        new Course()
        {
            Id = 2,
            CourseName = "Java",
            CourseStatus = CourseStatus.Completed,
            Description = "Platform independent language",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
        },
        new Course()
        {
            Id = 3,
            CourseName = "Python",
            CourseStatus = CourseStatus.Completed,
            Description = "Interpreted high-level programming language",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
        },
        new Course()
        {
            Id = 4,
            CourseName = "C#",
            CourseStatus = CourseStatus.Active,
            Description = "Object-oriented programming language",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
        },
        new Course()
        {
            Id = 5,
            CourseName = "JavaScript",
            CourseStatus = CourseStatus.Active,
            Description = "Client-side scripting language",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
        }
    };

    #endregion

    #region Groups

    public static List<Group> Groups { get; private set; } = new()
    {
        // Для курса "C++"
        new Group()
        {
            Id = 1,
            GroupName = "1-C++",
            Description = "Introductory C++ group for beginners",
            GroupStatus = GroupStatus.Active,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 1,
        },
        new Group()
        {
            Id = 2,
            GroupName = "2-C++",
            Description = "Intermediate C++ group for those with some experience",
            GroupStatus = GroupStatus.Active,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 1,
        },
        new Group()
        {
            Id = 3,
            GroupName = "3-C++",
            Description = "Advanced C++ group for experienced programmers",
            GroupStatus = GroupStatus.Active,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 1,
        },

        // Для курса "Java"
        new Group()
        {
            Id = 4,
            GroupName = "1-Java",
            Description = "Introduction to Java programming language",
            GroupStatus = GroupStatus.Completed,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 2,
        },
        new Group()
        {
            Id = 5,
            GroupName = "2-Java",
            Description = "Java fundamentals and best practices",
            GroupStatus = GroupStatus.Completed,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 2,
        },
        new Group()
        {
            Id = 6,
            GroupName = "3-Java",
            Description = "Advanced Java topics and frameworks",
            GroupStatus = GroupStatus.Completed,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 2,
        },

        // Для курса "Python"
        new Group()
        {
            Id = 7,
            GroupName = "1-Python",
            Description = "Python basics and syntax",
            GroupStatus = GroupStatus.Completed,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 3,
        },
        new Group()
        {
            Id = 8,
            GroupName = "2-Python",
            Description = "Intermediate Python programming concepts",
            GroupStatus = GroupStatus.Completed,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 3,
        },
        new Group()
        {
            Id = 9,
            GroupName = "3-Python",
            Description = "Advanced Python programming and applications",
            GroupStatus = GroupStatus.Completed,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 3,
        },

        // Для курса "C#"
        new Group()
        {
            Id = 10,
            GroupName = "1-C#",
            Description = "Getting started with C# programming language",
            GroupStatus = GroupStatus.Active,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 4,
        },
        new Group()
        {
            Id = 11,
            GroupName = "2-C#",
            Description = "Intermediate C# programming concepts and techniques",
            GroupStatus = GroupStatus.Active,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 4,
        },
        new Group()
        {
            Id = 12,
            GroupName = "3-C#",
            Description = "Advanced C# programming topics and applications",
            GroupStatus = GroupStatus.Active,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 4,
        },

        // Для курса "JavaScript"
        new Group()
        {
            Id = 13,
            GroupName = "1-JavaScript",
            Description = "JavaScript essentials and front-end development",
            GroupStatus = GroupStatus.Active,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 5,
        },
        new Group()
        {
            Id = 14,
            GroupName = "2-JavaScript",
            Description = "Intermediate JavaScript programming and frameworks",
            GroupStatus = GroupStatus.Active,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 5,
        },
        new Group()
        {
            Id = 15,
            GroupName = "3-JavaScript",
            Description = "Advanced JavaScript concepts and full-stack development",
            GroupStatus = GroupStatus.Active,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            CourseId = 5,
        }
    };

    #endregion

    #region Students

    public static List<Student> Students { get; private set; } = new()
    {
        new Student()
        {
            Id = 1,
            Address = "Tajikistan,Dushanbe",
            Email = "tajik@gmail.com",
            Phone = "+992123456789",
            FirstName = "Ali",
            LastName = "Aliev",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            Status = StudentStatus.Active,
        },
        new Student()
        {
            Id = 2,
            Address = "Russia, Moscow",
            Email = "ivan.russian@example.com",
            Phone = "+79123456789",
            FirstName = "Ivan",
            LastName = "Ivanov",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            Status = StudentStatus.Active
        },
        new Student()
        {
            Id = 3,
            Address = "USA, New York",
            Email = "emily.american@example.com",
            Phone = "+12123456789",
            FirstName = "Emily",
            LastName = "Smith",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Female,
            Status = StudentStatus.InActive
        },
        new Student()
        {
            Id = 4,
            Address = "France, Paris",
            Email = "pierre.french@example.com",
            Phone = "+33123456789",
            FirstName = "Pierre",
            LastName = "Dupont",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            Status = StudentStatus.Active
        },
        new Student()
        {
            Id = 5,
            Address = "Germany, Munich",
            Email = "felix.german@example.com",
            Phone = "+4987654321",
            FirstName = "Felix",
            LastName = "Schmidt",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            Status = StudentStatus.InActive
        },
        new Student()
        {
            Id = 6,
            Address = "Canada, Toronto",
            Email = "john.canadian@example.com",
            Phone = "+141612345678",
            FirstName = "John",
            LastName = "Smith",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            Status = StudentStatus.Active
        },
        new Student()
        {
            Id = 7,
            Address = "Germany, Berlin",
            Email = "sarah.german@example.com",
            Phone = "+49123456789",
            FirstName = "Sarah",
            LastName = "Müller",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Female,
            Status = StudentStatus.InActive
        },
        new Student()
        {
            Id = 8,
            Address = "Australia, Sydney",
            Email = "chris.australian@example.com",
            Phone = "+61123456789",
            FirstName = "Chris",
            LastName = "Jones",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            Status = StudentStatus.Active
        },
        new Student()
        {
            Id = 9,
            Address = "Spain, Madrid",
            Email = "maria.spanish@example.com",
            Phone = "+34123456789",
            FirstName = "Maria",
            LastName = "Garcia",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Female,
            Status = StudentStatus.InActive
        },
        new Student()
        {
            Id = 10,
            Address = "Brazil, Rio de Janeiro",
            Email = "rodrigo.brazilian@example.com",
            Phone = "+551123456789",
            FirstName = "Rodrigo",
            LastName = "Silva",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            Status = StudentStatus.Active
        },
        new Student()
        {
            Id = 11,
            Address = "UK, London",
            Email = "olivia.british@example.com",
            Phone = "+44123456789",
            FirstName = "Olivia",
            LastName = "Taylor",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Female,
            Status = StudentStatus.Active
        },
        new Student()
        {
            Id = 12,
            Address = "India, Mumbai",
            Email = "raj.indian@example.com",
            Phone = "+91123456789",
            FirstName = "Raj",
            LastName = "Patel",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            Status = StudentStatus.Active
        },
        new Student()
        {
            Id = 13,
            Address = "China, Beijing",
            Email = "wei.chinese@example.com",
            Phone = "+86123456789",
            FirstName = "Wei",
            LastName = "Li",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            Status = StudentStatus.Active
        },
        new Student()
        {
            Id = 14,
            Address = "South Africa, Cape Town",
            Email = "lindiwe.southafrican@example.com",
            Phone = "+27123456789",
            FirstName = "Lindiwe",
            LastName = "Mkhize",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Female,
            Status = StudentStatus.Active
        },
        new Student()
        {
            Id = 15,
            Address = "Japan, Tokyo",
            Email = "haruto.japanese@example.com",
            Phone = "+81123456789",
            FirstName = "Haruto",
            LastName = "Suzuki",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            Status = StudentStatus.Active
        }
    };

    #endregion

    #region Mentors

    public static List<Mentor> Mentors { get; private set; } = new()
    {
        new Mentor()
        {
            Id = 1,
            Address = "Tajikistan",
            Email = "tajik@gmail.com",
            Phone = "+992987654321",
            FirstName = "Ehson",
            LastName = "Murodov",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            MentorStatus = MentorStatus.Active
        },
        new Mentor()
        {
            Id = 2,
            Address = "USA",
            Email = "susan@example.com",
            Phone = "+11234567891",
            FirstName = "Susan",
            LastName = "Johnson",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Female,
            MentorStatus = MentorStatus.Active
        },
        new Mentor()
        {
            Id = 3,
            Address = "Canada",
            Email = "michael@example.com",
            Phone = "+141612345678",
            FirstName = "Michael",
            LastName = "Smith",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            MentorStatus = MentorStatus.Active
        },
        new Mentor()
        {
            Id = 4,
            Address = "Australia",
            Email = "sophie@example.com",
            Phone = "+611234567890",
            FirstName = "Sophie",
            LastName = "Brown",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Female,
            MentorStatus = MentorStatus.Active
        },
        new Mentor()
        {
            Id = 5,
            Address = "France",
            Email = "antoine@example.com",
            Phone = "+33123456789",
            FirstName = "Antoine",
            LastName = "Martin",
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            Gender = Gender.Male,
            MentorStatus = MentorStatus.InActive
        },
    };

    #endregion

    #region StudentGroups

    public static List<StudentGroup> StudentGroups { get; private set; } = new()
    {
        new StudentGroup()
        {
            Id = 1,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 1,
            StudentId = 1
        },
        new StudentGroup()
        {
            Id = 2,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 1,
            StudentId = 3
        },
        new StudentGroup()
        {
            Id = 3,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 1,
            StudentId = 7
        },


        new StudentGroup()
        {
            Id = 4,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 2,
            StudentId = 4
        },
        new StudentGroup()
        {
            Id = 5,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 2,
            StudentId = 6
        },
        new StudentGroup()
        {
            Id = 6,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 3,
            StudentId = 2
        },
        new StudentGroup()
        {
            Id = 7,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 3,
            StudentId = 12
        },
        new StudentGroup()
        {
            Id = 8,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 4,
            StudentId = 8
        },
        new StudentGroup()
        {
            Id = 9,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 4,
            StudentId = 10
        },
        new StudentGroup()
        {
            Id = 10,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 5,
            StudentId = 11
        },
        new StudentGroup()
        {
            Id = 11,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 5,
            StudentId = 13
        },
        new StudentGroup()
        {
            Id = 12,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 6,
            StudentId = 1
        },
        new StudentGroup()
        {
            Id = 13,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 6,
            StudentId = 7
        },
        new StudentGroup()
        {
            Id = 14,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 7,
            StudentId = 10
        },
        new StudentGroup()
        {
            Id = 15,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 7,
            StudentId = 9
        },
        new StudentGroup()
        {
            Id = 16,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 8,
            StudentId = 12
        },
        new StudentGroup()
        {
            Id = 17,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 8,
            StudentId = 4
        },
        new StudentGroup()
        {
            Id = 18,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 9,
            StudentId = 13
        },
        new StudentGroup()
        {
            Id = 19,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.InActive,
            GroupId = 9,
            StudentId = 15
        },
        new StudentGroup()
        {
            Id = 20,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 10,
            StudentId = 6
        },
        new StudentGroup()
        {
            Id = 21,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 10,
            StudentId = 7
        },
        new StudentGroup()
        {
            Id = 22,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 10,
            StudentId = 8
        },
        new StudentGroup()
        {
            Id = 23,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 11,
            StudentId = 9
        },
        new StudentGroup()
        {
            Id = 24,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 11,
            StudentId = 13
        },
        new StudentGroup()
        {
            Id = 25,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 12,
            StudentId = 4
        },
        new StudentGroup()
        {
            Id = 26,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 12,
            StudentId = 5
        },
        new StudentGroup()
        {
            Id = 27,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 13,
            StudentId = 13
        },
        new StudentGroup()
        {
            Id = 28,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 13,
            StudentId = 14
        },
        new StudentGroup()
        {
            Id = 29,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 14,
            StudentId = 9
        },
        new StudentGroup()
        {
            Id = 30,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 14,
            StudentId = 8
        },
        new StudentGroup()
        {
            Id = 31,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 15,
            StudentId = 5
        },
        new StudentGroup()
        {
            Id = 32,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            StudentGroupStatus = StudentGroupStatus.Active,
            GroupId = 15,
            StudentId = 6
        }
    };

    #endregion

    #region MentorGroups

    public static List<MentorGroup> MentorGroups { get; private set; } = new()
    {
        new MentorGroup()
        {
            Id = 1,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 1,
            MentorId = 3
        },
        new MentorGroup()
        {
            Id = 2,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 3,
            MentorId = 1
        },
        new MentorGroup()
        {
            Id = 3,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.InActive,
            GroupId = 5,
            MentorId = 1
        },
        new MentorGroup()
        {
            Id = 4,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 2,
            MentorId = 2
        },
        new MentorGroup()
        {
            Id = 5,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 4,
            MentorId = 2
        },
        new MentorGroup()
        {
            Id = 6,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 6,
            MentorId = 2
        },
        new MentorGroup()
        {
            Id = 7,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 7,
            MentorId = 3
        },
        new MentorGroup()
        {
            Id = 8,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.InActive,
            GroupId = 9,
            MentorId = 3
        },
        new MentorGroup()
        {
            Id = 9,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 11,
            MentorId = 3
        },
        new MentorGroup()
        {
            Id = 10,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.InActive,
            GroupId = 8,
            MentorId = 4
        },
        new MentorGroup()
        {
            Id = 11,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 10,
            MentorId = 4
        },
        new MentorGroup()
        {
            Id = 12,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 12,
            MentorId = 4
        },
        new MentorGroup()
        {
            Id = 13,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 13,
            MentorId = 5
        },
        new MentorGroup()
        {
            Id = 14,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.Active,
            GroupId = 14,
            MentorId = 5
        },
        new MentorGroup()
        {
            Id = 15,
            CreateAt = DateTime.UtcNow,
            UpdateAt = DateTime.UtcNow,
            MentorGroupStatus = MentorGroupStatus.InActive,
            GroupId = 15,
            MentorId = 5
        },
    };

    #endregion
};