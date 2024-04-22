
using MainApp.Data;
using MainApp.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.WebSockets;
using System.Xml;
//1
//Выбрать всех студентов и их группы, отсортированных по курсам, а затем по фамилии студента:

var query = (from s in DataProvider.Students
             join sg in DataProvider.StudentGroups on s.Id equals sg.StudentId
             join g in DataProvider.Groups on sg.GroupId equals g.Id
             join c in DataProvider.Courses on g.CourseId equals c.Id
             orderby c.CourseName
             select new
             {
                 Student = s,
                 Group = g,
                 CourseName = c.CourseName
             }).OrderBy(x => x.Student.LastName).ToList();

//foreach (var item in query)
//{
//    Console.WriteLine("-------------------------------------------------------------");
//    Console.WriteLine();
//    Console.WriteLine($"{item.CourseName} - Student: ({item.Student.FirstName}|| Group: {item.Group.GroupName}");
//    Console.WriteLine();
//}

//2
//Выбрать всех менторов и количество групп, которые они ведут:
var mentors = (from m in DataProvider.Mentors
               let countG = DataProvider.MentorGroups.Count(x => x.MentorId == m.Id)
               select new
               {
                   Mentor = m,
                   CounrOfGroups = countG
               }).ToList();



//foreach (var m in mentors)
//{
//    Console.WriteLine($"{string.Concat(m.Mentor.FirstName + " " + m.Mentor.LastName)} - {m.CounrOfGroups}");
//}


//3
//Выбрать все курсы, в которых нет групп:
var courses = (from c in DataProvider.Courses
               let countCourse = DataProvider.Groups.Count(x => x.CourseId == c.Id)
               where countCourse == 0
               select new
               {
                   Course = c
               });

//foreach (var c in courses)
//{
//    Console.WriteLine(c.Course.CourseName);
//}


//
//4Выбрать все группы с количеством студентов и менторов в каждой группе:

var groups = (from g in DataProvider.Groups
              let countStudent = DataProvider.StudentGroups.Count(x => x.GroupId == g.Id)
              let countMentor = DataProvider.MentorGroups.Count(x => x.GroupId == g.Id)
              select new
              {
                  Group = g,
                  CountStudent = countStudent,
                  CountMentor = countMentor
              }).ToList();

// foreach (var g in groups)
// {
//     Console.WriteLine($"Group: {g.Group.GroupName}- CountStudent: {g.CountStudent}- CountMentor: {g.CountMentor} ");
// }

//5
//Выбрать всех студентов, у которых количество групп больше среднего:
var avg = DataProvider.StudentGroups.Average(x => x.StudentId);

var result = (from s in DataProvider.Students
              let count = DataProvider.StudentGroups.Count(x => x.StudentId == s.Id)
              where count > avg
              select new
              {
                  Student = s
              });



//foreach (var s in result)
//{
//    Console.WriteLine(s.Student.FirstName + " " + s.Student.LastName + " " + avg);
//} 

//6Выбрать всех менторов, у которых количество студентов в группах больше определенного значения:

var max = 5;

var mentorGroup = from g in DataProvider.Groups
                  let students = DataProvider.StudentGroups.Count(x => x.GroupId == g.Id)
                  join mg in DataProvider.MentorGroups on g.Id equals mg.GroupId
                  join m in DataProvider.Mentors on mg.MentorId equals m.Id
                  where students < max
                  select new
                  {
                      Mentor = m.FirstName,
                      Count = students

                  };


//foreach (var mg in mentorGroup)
//{

//    Console.WriteLine($"{mg.Mentor} {mg.Count}");
//}
//7
//Выбрать все группы, в которых есть студенты обоих полов:
var bothGender = (from g in DataProvider.Groups
                 join sg in DataProvider.StudentGroups on g.Id equals sg.GroupId
                 join s in DataProvider.Students on sg.StudentId equals s.Id
                 where s.Gender == MainApp.Data.Entity.Enums.Gender.Male && s.Gender == MainApp.Data.Entity.Enums.Gender.Female
                 select new
                 {
                     GroupName = g.GroupName
                 }).ToList();
foreach (var item in bothGender)
{
    Console.WriteLine(item.GroupName);
}

//
//8Выбрать всех студентов, которые не состоят в группе с определенным ментором:
var mentorId = 123;

var stnotmentor = DataProvider.Groups
    .Where(s => !s.MentorGroups!.Any(g => g.MentorId == mentorId))
    .ToList();


//
//9Выбрать всех менторов, которые ведут группу на курсе с наименьшим количеством студентов:
// Получить все группы с минимальным количеством студентов
// Получить всех менторов, связанных с этими группами
//var minStudents = DataProvider.Groups
//    .GroupBy(g => g.GroupName)
//    .Where(g => g.Count() == DataProvider.StudentGroups.Count(sg => sg.GroupId == g.Key))
//    .Select(g => g.Key)
//    .ToList();

//10
//Выбрать всех студентов, которые состоят в группе на курсе с наибольшим количеством менторов:
var studentsInGroupWithMaxMentors = DataProvider.Students
    .Join(DataProvider.StudentGroups, s => s.Id, sg => sg.StudentId, (s, sg) => new { Student = s, GroupId = sg.GroupId })
    .Join(DataProvider.Groups, sg => sg.GroupId, g => g.Id, (sg, g) => new { sg.Student, CourseId = g.CourseId })
    .Join(DataProvider.Courses, sg => sg.CourseId, c => c.Id, (sg, c) => new { sg.Student, MentorCount = })
    .GroupBy(x => x.Student)
    .OrderByDescending(x => x.First().MentorCount)
    .FirstOrDefault()
    .Select(x => x.Student)
    .ToList();
//11
//Выбрать всех студентов, принадлежащих курсу, который имеет больше всего групп:
//var students = DataProvider.Students
//    .Where(s => DataProvider.StudentGroups.Count(sg => sg.StudentId == s.Id) == DataProvider.Groups
//        .Where(g => g.CourseId == DataProvider.Groups
//            .GroupBy(gr => gr.CourseId)
//            .OrderByDescending(gr => gr.Count())
//            .FirstOrDefault()
//            .Key)
//        .Count())
//    .ToList();
//12
//Выбрать все группы, в которых количество студентов превышает количество менторов более чем в два раза:


//13
//Выбрать все группы, которые имеют одинаковое количество студентов и менторов:
//var groupsSM = DataProvider.Groups
//    .Where(g => DataProvider.StudentGroups.Count(sg => sg.GroupId == g.Id) 
//    == DataProvider.MentorGroups.Count(mg => mg.GroupId == g.Id))
//    .ToList();

//14
//Выбрать всех студентов, которые состоят во всех группах на всех курсах:
//var students = DataProvider.Students
//    .Where(s => DataProvider.Groups
//        .Select(g => g.Id)
//        .Distinct()
//        .All(groupId => DataProvider.StudentGroups.Any(sg => sg.StudentId == s.Id && sg.GroupId == groupId)))
//    .ToList();

//15
//Выбрать все курсы, в которых количество групп превышает количество студентов:
//var course = DataProvider.Courses
//    .Where(c => c.Groups!.Count() > DataProvider.StudentGroups.Select(sg => sg.GroupId).Distinct().Count())
//    .ToList();

//16
//Выбрать всех студентов, которые состоят во всех группах на курсе с наименьшим количеством менторов:
//var allStudents= DataProvider.Students
//    .Where(s => DataProvider.Groups
//        .Where(g => g.Course!.Groups.All(group => group.MentorGroups!.Count() == DataProvider.Groups
//            .Where(gr => gr.CourseId == group.CourseId)
//            .Min(gr => gr.MentorGroups!.Count())))
//        .Select(g => g.Id)
//        .Distinct()
//        .All(groupId => DataProvider.StudentGroups.Any(sg => sg.StudentId == s.Id && sg.GroupId == groupId)))
//    .ToList();
