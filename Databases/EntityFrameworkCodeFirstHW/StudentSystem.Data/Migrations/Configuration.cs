namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentSystem.Data.StudentSystemContext";
        }

        protected override void Seed(StudentSystemContext studentSystemContext)
        {           
            /*var studentHomework = new Homework() { Content = "Student Homework" };
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
            studentSystemContext.SaveChanges();*/
        }
    }
}
