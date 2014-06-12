namespace TestSchoolProject
{
    using System;
    using SchoolProject;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void JoinCourseTest()
        {
            var course = new Course();
            var student = new Student(15000, "Ivan");
            student.JoinCourse(course);
            Assert.AreEqual(student.Courses[0], course, 
                "The course is not added to the student's courses");
            Assert.AreEqual(course.Students[0], student,
                "The student is not added to the course");            
        }

        [TestMethod]
        public void LeaveCourseTest()
        {
            var course = new Course();
            var student = new Student(15000, "Ivan");
            student.JoinCourse(course);
            student.LeaveCourse(course);
            Assert.AreEqual(student.Courses.Count, 0,
                "The course is not deleted from the student's courses");
            Assert.AreEqual(course.Students.Count, 0,
                "The student is not deleted from the course");
        }
    }
}
