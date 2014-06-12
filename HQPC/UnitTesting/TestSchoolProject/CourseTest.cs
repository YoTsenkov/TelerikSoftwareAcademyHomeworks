namespace TestSchoolProject
{
    using System;
    using SchoolProject;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "The list of students exceeds the course capacity")] 
        public void InitWithTooManyStudents()
        {
            var course = new Course(new List<Student>(new Student[30]));            
        }

        [TestMethod]
        public void AddSingleStudentTest()
        {
            var course = new Course();
            var student = new Student(15000, "Ivan");
            course.AddStudent(student);
            Assert.AreEqual(course.Students[0], student, "Wrong added student");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
            "The course is full")]
        public void AddStudentToFullCourse()
        {
            var course = new Course(new List<Student>(new Student[29]));
            var student = new Student(15000, "Ivan");
            course.AddStudent(student);           
        }

        [TestMethod]
        public void RemoveSingleStudentTest()
        {
            var course = new Course();
            var student = new Student(15000, "Ivan");
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual(course.Students.Count, 0, "Student not removed from the course");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
            "Cant remove student from empty course")]
        public void RemoveStudentFromEmptyCourse()
        {
            var course = new Course();
            var student = new Student(15000, "Ivan");            
            course.RemoveStudent(student);
        }
    }
}
