namespace StudentSystem.Client
{
    using System;
    using StudentSystem.Data;
    using StudentSystem.Models;
    using System.Data.Entity;
    using StudentSystem.Data.Migrations;

    internal class Client
    {
        static void Main()
        {
            Database.SetInitializer
                (new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
            StudentSystemContext studentSystemContext = new StudentSystemContext();
            var studentHomework = new Homework() { Content = "Student Homework" };
            var student = new Student() { Name = "Ivancho", Number = 666666 };
            student.Homeworks.Add(studentHomework);
            var courseHomework = new Homework() { Content = "Course Homework" };
            var course = new Course() { Name = "Databases", Description = "Very useful course" };
            course.Homeworks.Add(courseHomework);
            course.Students.Add(student);
            student.Courses.Add(course);

            studentSystemContext.Students.Add(student);
            studentSystemContext.Courses.Add(course);
            studentSystemContext.Homeworks.Add(studentHomework);
            studentSystemContext.Homeworks.Add(courseHomework);
            studentSystemContext.SaveChanges();
        }
    }
}
